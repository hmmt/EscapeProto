using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSystem : SystemBase
{
    private List<CharacterEntity> _list = new List<CharacterEntity>();
    
    public CharacterEntity CreateCharacter()
    {
        CharacterEntity newEntity = new CharacterEntity();
        newEntity.Initialize();
        _list.Add(newEntity);

        // unity setting
        GameObject g = new GameObject("Character");
        var entityObject = g.AddComponent<EntityBehaviour>();
        entityObject.SetEntity(newEntity);
        entityObject.Initialize();

        return newEntity;
    }
}
