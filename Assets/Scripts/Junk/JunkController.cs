using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkController : GiangMonoBehavior

{
    public JunkSpawner JunkSpawner  { get => junkSpawner; }
    [SerializeField] protected JunkSpawner junkSpawner;

    
    protected override void LoadComponent()
    {
        LoadJunkSpawner();
    }
    protected virtual void LoadJunkSpawner(){
        if(junkSpawner != null) return;
        junkSpawner = GetComponent<JunkSpawner>();
    }


}
