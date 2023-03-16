using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSpawner : Spawner
{
    public static FXSpawner Instance { get => instance; }
    private static FXSpawner instance;
    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }
    public static string smokeOne = "smoke_1";
    public static string hitOne = "hit_1";

}
