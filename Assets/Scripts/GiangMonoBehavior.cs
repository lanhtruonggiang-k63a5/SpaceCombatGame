using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GiangMonoBehavior : MonoBehaviour
{
    protected virtual void Reset()
    {
        LoadComponent();
    }
    protected virtual void Awake()
    {
        LoadComponent();
    }
    protected abstract void LoadComponent();
    
}
