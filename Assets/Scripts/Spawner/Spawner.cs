using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : GiangMonoBehavior
{
    [SerializeField] protected Transform holder;
    [SerializeField] protected List<Transform> prefabs;
    [SerializeField] protected List<Transform> poolObjects;

    public int SpawnedCount { get; private set; }

    protected override void LoadComponents()
    {
        LoadPrefabs();
        LoadHolder();
    }
    protected virtual void LoadHolder()
    {
        if (holder != null) return;

        holder = transform.Find("holder");
        Debug.Log(transform.name + ": LoadHolder", gameObject);
    }
    protected virtual void LoadPrefabs()
    {
        if (prefabs.Count > 0) return;
        Transform prefabObj = transform.Find("prefabs");
        foreach (Transform prefab in prefabObj)
        {
            prefabs.Add(prefab);

        }
        Debug.Log(transform.name + ": LoadPrefabs", gameObject);
        HidePrefabs();
    }
    protected virtual void HidePrefabs()
    {
        foreach (Transform prefab in prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }


    public virtual Transform Spawn(string prefabName, Vector3 position, Quaternion rotation)
    {
        Transform prefab = GetPrefabByName(prefabName);
        if (prefab == null)
        {
            Debug.LogError("Cant get prefab " + prefabName + " by name");
            return null;
        }
        
        return Spawn(prefab,position,rotation);

    }
    public virtual Transform Spawn(Transform prefab, Vector3 position, Quaternion rotation){
        Transform newPrefab = GetObjectFromPool(prefab);
        newPrefab.SetPositionAndRotation(position, rotation);
        newPrefab.parent = holder;
        SpawnedCount++;
        return newPrefab;
    }
    public virtual Transform RandomPrefabs(){
        int rand = Random.Range(0, prefabs.Count);
        return prefabs[rand];
    }
    protected virtual Transform GetObjectFromPool(Transform prefab)
    {
        foreach (Transform poolObj in poolObjects)
        {
            if (poolObj.name == prefab.name)
            {
                poolObjects.Remove(poolObj);
                return poolObj;
            }
        }
        Transform newPrefab = Instantiate(prefab);
        newPrefab.name = prefab.name;
        return newPrefab;

    }
    public virtual void Despawn(Transform obj)
    {
        this.poolObjects.Add(obj);
        obj.gameObject.SetActive(false);
        SpawnedCount--;
    }

    protected virtual Transform GetPrefabByName(string prefabName)
    {
        foreach (Transform prefab in prefabs)
        {
            if (prefabName == prefab.name) return prefab;
        }
        return null;
    }





}
