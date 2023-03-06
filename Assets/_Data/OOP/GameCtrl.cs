using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : GiangMonoBehavior
{
    public static GameCtrl Instance { get => instance; }
    [SerializeField] protected static GameCtrl instance;

    public Camera MainCamera { get => mainCamera; }
    [SerializeField] protected Camera mainCamera;

    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }
    protected override void LoadComponents()
    {
        LoadCamera();
    }
    protected virtual void LoadCamera(){
        if(mainCamera != null) return;
        mainCamera =  FindObjectOfType<Camera>();
        Debug.Log(transform.name + ": LoadCamera", gameObject);

    }
    
}
