using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : GiangMonoBehavior
{
    [SerializeField] protected JunkController JunkController;

    protected override void LoadComponent()
    {
        LoadJunkController();
    }
    protected virtual void LoadJunkController()
    {
        if (JunkController != null) return;
        JunkController = GetComponent<JunkController>();
    }
    private void Start()
    {
        JunkSpawning();
    }
    protected virtual void JunkSpawning()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        Transform junk = JunkController.JunkSpawner.Spawn(JunkSpawner.junkOne, pos, rot);
        junk.gameObject.SetActive(true);
        Invoke(nameof(JunkSpawning), 1f);
    }
}
