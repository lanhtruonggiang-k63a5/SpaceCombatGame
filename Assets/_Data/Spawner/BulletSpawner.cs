using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    public static BulletSpawner Instance { get => instance; }
    private static BulletSpawner instance;
    protected override void Awake()
    {
        base.Awake();
        if(instance != null) Debug.Log("only 1 bullet spawner");
        instance = this;
        
    }
    public static string bulletOne = "bullet_1";

    
}
