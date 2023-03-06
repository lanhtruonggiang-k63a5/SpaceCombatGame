using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    public static JunkSpawner Instance { get => instance; }
    private static JunkSpawner instance;
    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }
    // public static string junkOne = "junk_1";
    
}
