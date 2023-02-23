using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : GiangMonoBehavior
{
    [SerializeField] protected JunkSpawnController JunkSpawnController;

    protected override void LoadComponent()
    {
        LoadJunkController();
    }
    protected virtual void LoadJunkController()
    {
        if (JunkSpawnController != null) return;
        JunkSpawnController = GetComponent<JunkSpawnController>();
    }
    private void Start()
    {
        JunkSpawning();
    }
    protected virtual void JunkSpawning()
    {
        Transform point = JunkSpawnController.JunkSpawnPoint.RandomPoint();
        Vector3 pos = point.position;
        Quaternion rot = point.rotation;
        
        Transform junk = JunkSpawnController.JunkSpawner.Spawn(JunkSpawner.junkOne, pos, rot);
        junk.gameObject.SetActive(true);
        Invoke(nameof(JunkSpawning), 1f);
    }
}
