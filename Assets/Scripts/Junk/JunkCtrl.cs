using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : GiangMonoBehavior
{
    public Transform Model { get => model; }
    [SerializeField] protected Transform model;


    protected override void LoadComponent()
    {
        LoadJunkModel();
    }

    protected virtual void LoadJunkModel()
    {
        if (model != null) return;
        GameObject junk = GameObject.Find("junk_1/JunkSprite");
        model = junk.GetComponent<Transform>();
        Debug.Log(model);
    }
}
