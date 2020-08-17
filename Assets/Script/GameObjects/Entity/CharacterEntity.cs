using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEntity : EntityBase
{
    public override void Initialize()
    {
        AddDataComponent<PositionComp>();
        AddDataComponent<MovableComp>();
    }
}
