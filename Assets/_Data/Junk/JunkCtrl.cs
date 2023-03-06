using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : GiangMonoBehavior
{
    public Transform Model { get => model; }
    [SerializeField] protected Transform model;

    public JunkDespawn JunkDespawn { get => junkDespawn; }
    [SerializeField] protected JunkDespawn junkDespawn;

    public JunkSO JunkSO { get => junkSO; }
    [SerializeField] protected JunkSO junkSO;

    protected override void LoadComponents()
    {
        LoadJunkModel();
        LoadJunkDespawn();
        LoadJunkSO();
    }
    protected virtual void LoadJunkModel()
    {
        if (model != null) return;
        model = transform.Find("JunkSprite");
        Debug.Log(transform.name + ": JunkSprite ", gameObject);

    }
    protected virtual void LoadJunkDespawn()
    {
        if (junkDespawn != null) return;
        junkDespawn = transform.GetComponentInChildren<JunkDespawn>();
        Debug.Log(transform.name + ": LoadJunkDespawn ", gameObject);
    }
    protected virtual void LoadJunkSO()
    {
        if (junkSO != null) return;
        string resPath = "Junk/" + transform.name;
        junkSO = Resources.Load<JunkSO>(resPath);
        Debug.Log(transform.name + ": LoadJunkSO " + resPath, gameObject);
    }
}
