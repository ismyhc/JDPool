# JDPool
Simple object pooling for use with Unity/Futile 2D Framework.

### Interface
The class in which you want to pool should adhere to the JDIPoolable interface. 
You should reset any variables in Free()
```c#
void Free();
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
