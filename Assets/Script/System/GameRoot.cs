using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
    private static GameRoot _instance;
    public static GameRoot instance => _instance;

    private List<SystemBase> _systems = new List<SystemBase>();

    public void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        Initialize();
        Tester();
    }

    private void Initialize()
    {
        _systems.Clear();

        _systems.Add(new GameInputSystem());
        _systems.Add(new FieldSystem());
        _systems.Add(new UnitSystem());

        GetSystem<GameInputSystem>().SetActivate(true);
        GetSystem<FieldSystem>().SetActivate(true);
    }

    private void Tester()
    {
        CreateUnit();
    }

    private void CreateUnit()
    {
        var c = GetSystem<UnitSystem>().CreateCharacter();
        GetSystem<GameInputSystem>().RegisterInputUnit(c);
    }

    private void Update()
    {
        foreach(var system in _systems)
        {
            if(system.isActiveated)
            {
                system.Update();
            }
        }
    }




    public T GetSystem<T>() where T : SystemBase
    {
        return _systems.Find(x => x.GetType() == typeof(T)) as T;
    }
}
