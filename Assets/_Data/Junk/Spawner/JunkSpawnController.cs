using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnController : GiangMonoBehavior

{
    public JunkSpawner JunkSpawner { get => junkSpawner; }
    [SerializeField] protected JunkSpawner junkSpawner;

    public JunkSpawnPoint JunkSpawnPoint { get => junkSpawnPoint; }
    [SerializeField] protected JunkSpawnPoint junkSpawnPoint;

    


    protected override void LoadComponents()
    {
        LoadJunkSpawner();
        LoadJunkSpawnPoint();
    }
    protected virtual void LoadJunkSpawner()
    {
        if (junkSpawner != null) return;
        junkSpawner = GetComponent<JunkSpawner>();
        Debug.Log(transform.name + ": LoadJunkSpawner", gameObject);

    }
    protected virtual void LoadJunkSpawnPoint()
    {
        if (junkSpawnPoint != null) return;
        // junkSpawnPoint = transform.FindObjectOfType<JunkSpawnPoint>();
        junkSpawnPoint = GetComponentInChildren<JunkSpawnPoint>(false);
        Debug.Log(transform.name + ": LoadJunkSpawnPoint", gameObject);

    }


    



}
