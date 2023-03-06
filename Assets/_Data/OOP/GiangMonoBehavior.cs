using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GiangMonoBehavior : MonoBehaviour
{
    protected virtual void OnEnable()
    {

    }
    protected virtual void Reset()
    {
        LoadComponents();
        ResetValue();
    }
    protected virtual void Awake()
    {
        LoadComponents();
        ResetValue();
    }
    protected virtual void Start()
    {

    }
    protected virtual void ResetValue()
    {

    }
    protected virtual void LoadComponents() { }



}
