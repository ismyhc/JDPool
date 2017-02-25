# JDPool
Simple object pooling

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
