using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInputSystem : SystemBase
{
    private EntityBase _targetUnit;


    public override void Update()
    {
        if(_targetUnit != null)
        {
            int x = 0;
            if (Input.GetKey(KeyCode.D))
                x += 1;
            if (Input.GetKey(KeyCode.A))
                x -= 1;

            if(x != 0)
            {
                GameRoot.instance.GetSystem<FieldSystem>().MoveUnitHorizontal(_targetUnit, x * Time.deltaTime);
            }
        }
    }


    /// <summary>
    /// 입력을 받을 유닛을 지정합니다.
    /// </summary>
    /// <param name="unit"></param>
    public void RegisterInputUnit(EntityBase unit)
    {
        _targetUnit = unit;
    }

    /// <summary>
    /// 유닛들이 입력을 받지 않습니다.
    /// </summary>
    public void UnregisterAllInputUnit()
    {
        _targetUnit = null;
    }
}
