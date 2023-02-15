using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawn : MonoBehaviour
{
    
    private void Update()
    {
        if (CanDespawn()) DespawnObject(); 
    }
    protected abstract bool CanDespawn();
    
    protected virtual void DespawnObject(){
        // Destroy(transform.parent.gameObject);
        
    }
   


}
