using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawn : GiangMonoBehavior
{
    private void Update()
    {
        if (CanDespawn()) DespawnObject(); 
    }
    protected abstract bool CanDespawn();
    
    public virtual void DespawnObject(){
        Destroy(transform.parent.gameObject);
    }
}
