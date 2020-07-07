using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataComponentBase
{
    private EntityBase _entity;
    public EntityBase entity;

    private bool _init = false;

    public void Initialize(EntityBase entity)
    {
        if(_init)
        {
            Debug.LogError("already initialzed");
        }
        _init = true;

        _entity = entity;
    }
}
