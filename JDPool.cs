using System;
using System.Collections.Generic;

public interface IJDPoolable
{
    void Free();
}

public class JDPool<T>
{
    
    readonly List<T> _items = new List<T>();
    readonly Queue<T> _freeItems = new Queue<T>();
    readonly Func<T> _createItemAction;

    public JDPool(Func<T> createItemAction)
    {
        _createItemAction = createItemAction;
    }

    public sealed void FreeItem(T item)
    {
        
        var poolableItem = item as IJDPoolable;

        if (poolableItem != null)
            poolableItem.Free();

        _freeItems.Enqueue(item);

    }

    public sealed void Clear()
    {

        _items.Clear();
        _freeItems.Clear();
    
    }

    public sealed T GetItem()
    {

        if (_freeItems.Count == 0)
        {

            T item = _createItemAction();
            _items.Add(item);

            return item;
        
        }

        return _freeItems.Dequeue();
    
    }

    public sealed int FreeItemCount()
    {
		return _freeItems.Count;
    }

}
