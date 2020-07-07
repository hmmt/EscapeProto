using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBase
{
    private List<DataComponentBase> _componets = new List<DataComponentBase>();

    public virtual void Initialize()
    {

    }

    public T AddDataComponent<T>() where T : DataComponentBase
    {
        var found = _componets.Find(x => x is T);
        if (found != null)
            return found as T;


        var result = System.Activator.CreateInstance<T>();
        _componets.Add(result);
        return result;
    }

    public T GetDataComponent<T>() where T : DataComponentBase
    {
        return _componets.Find(x => x is T) as T;
    }
}
