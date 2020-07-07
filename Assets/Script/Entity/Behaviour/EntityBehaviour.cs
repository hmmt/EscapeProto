using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBehaviour : MonoBehaviour
{
    private EntityBase _entity;

    private bool _initalized = false;

    public void SetEntity(EntityBase entity)
    {
        _entity = entity;
    }

    // Update is called once per frame
    void Update()
    {
        if (_entity == null)
            return;
        var pos = _entity.GetDataComponent<PositionComp>();
        if(pos != null)
        {
            transform.localPosition = new Vector3(pos.x, pos.y);
        }
    }


    /// <summary>
    /// 스프라이트 렌더러를 가진 객체로 초기화
    /// </summary>
    public void Initialize()
    {
        if (_initalized)
            return;

        var renderer = gameObject.AddComponent<SpriteRenderer>();
        renderer.sprite = Resources.Load<Sprite>("Square100");
        _initalized = true;
    }
}
