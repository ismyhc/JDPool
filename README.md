# JDPool
Simple object pooling for use with Unity/Futile 2D Framework.

[Futile 2D Framework for Unity](https://github.com/MattRix/Futile)

### Interface
The class in which you want to pool should adhere to the IJDPoolable interface. 
You should reset any variables in OnItemFree()
```c#
void OnItemFree();
```

### Initialize
```c#
public JDPool<ObjectToPool> objectPool = new JDPool<ObjectToPool>(() => new ObjectToPool());
```

### Use
```c#
var pooledObject = objectPool.GetItem();
```

### Free 
```c#
objectPool.FreeItem(pooledObject);
```
