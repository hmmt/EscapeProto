using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemBase
{
    private bool _isActiveated = false;
    public bool isActiveated => _isActiveated;

    public void SetActivate(bool b)
    {
        _isActiveated = b;
    }

    public virtual void Update()
    {

    }

    public virtual void FixedUpdate()
    {

    }
}
