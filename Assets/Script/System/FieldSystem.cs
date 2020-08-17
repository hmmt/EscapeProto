using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldSystem : SystemBase
{
    //  무언가 맵에 관한 변수

    public void MoveUnitHorizontal(EntityBase entity, float x)
    {
        if (!isActiveated)
            return;

        var position = entity.GetDataComponent<PositionComp>();
        if (position == null)
            return;

        position.x += x;
    }
}