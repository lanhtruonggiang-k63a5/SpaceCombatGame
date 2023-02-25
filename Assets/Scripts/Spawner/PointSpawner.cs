using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PointSpawner : GiangMonoBehavior
{
    [SerializeField] protected List<Transform> points;

    protected override void LoadComponents()
    {
        LoadPoints();        
    }

    protected virtual void LoadPoints(){
        if(points.Count >0 ) return;
        foreach (Transform item in transform)
        {
            points.Add(item);
        }
        Debug.Log(transform.name + ": LoadPoints", gameObject);
    }
    public virtual Transform RandomPoint(){
        int rand = Random.Range(0, points.Count);
        return points[rand];
    }
}
