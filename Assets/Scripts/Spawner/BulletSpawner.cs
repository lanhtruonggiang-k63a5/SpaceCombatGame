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
        instance = this;
    }
    public static string bulletOne = "bullet_1";
    public static string bulletTwo = "bullet_2";

    
}
