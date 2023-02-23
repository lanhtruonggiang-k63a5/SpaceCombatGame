using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GiangMonoBehavior : MonoBehaviour
{
    protected virtual void OnEnable(){
        
    }
    protected virtual void Reset()
    {
        LoadComponent();
        ResetValue();
    }
    protected virtual void Awake()
    {
        LoadComponent();
        ResetValue();
    }
    protected virtual void ResetValue(){

    }
    protected virtual void LoadComponent(){

    }
    
}
