using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnRandom : GiangMonoBehavior
{
    [SerializeField] protected JunkSpawnController JunkSpawnController;
    [SerializeField] protected float randomDelay;
    [SerializeField] protected float randomTimer;

    [SerializeField] protected int junkLimit;
    protected override void LoadComponents()
    {
        LoadJunkController();
    }
    protected virtual void LoadJunkController()
    {
        if (JunkSpawnController != null) return;
        JunkSpawnController = GetComponent<JunkSpawnController>();
        Debug.Log(transform.name + ": LoadJunkController", gameObject);

    }

    private void Update()
    {
        JunkSpawning();
    }
    protected virtual void JunkSpawning()
    {
        if (SpawnLimit()) return;

        randomTimer += Time.deltaTime;
        if (randomTimer < randomDelay) return;
        randomTimer = 0f;

        Transform point = JunkSpawnController.JunkSpawnPoint.RandomPoint();
        Vector3 pos = point.position;
        Quaternion rot = point.rotation;

        Transform prefab = JunkSpawnController.JunkSpawner.RandomPrefabs();
        Transform junk = JunkSpawnController.JunkSpawner.Spawn(prefab, pos, rot);
        junk.gameObject.SetActive(true);
    }
    protected virtual bool SpawnLimit()
    {
        return junkLimit == JunkSpawnController.JunkSpawner.SpawnedCount;
    }
}
