using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : GiangMonoBehavior
{
    public Transform Model { get => model; }
    [SerializeField] protected Transform model;

    public JunkDespawn JunkDespawn { get => junkDespawn; }
    [SerializeField] protected JunkDespawn junkDespawn;


    protected override void LoadComponents()
    {
        LoadJunkModel();
        LoadJunkDespawn();
    }
    protected virtual void LoadJunkDespawn(){
        if(junkDespawn != null) return;
        junkDespawn = FindObjectOfType<JunkDespawn>();
        Debug.Log(transform.name + ": LoadJunkDespawn", gameObject);

    }

    protected virtual void LoadJunkModel()
    {
        if (model != null) return;
        GameObject junk = GameObject.Find("junk_1/JunkSprite");
        model = junk.GetComponent<Transform>();
        Debug.Log(transform.name + ": LoadJunkModel", gameObject);

    }
}
