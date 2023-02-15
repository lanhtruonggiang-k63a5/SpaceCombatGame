using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : GiangMonoBehavior
{
    [SerializeField] private List<Transform> listObject;
    [SerializeField] private List<Transform> poolObjects;

    [SerializeField] private Transform holder;
    protected override void LoadComponent()
    {
        LoadPrefabs();
    }
    protected virtual void LoadPrefabs()
    {
        if (listObject.Count > 0) return;

        Transform prefabObj = transform.Find("prefabs");
        foreach (Transform item in prefabObj)
        {
            listObject.Add(item);
            HideItem(item);
        }
    }
    protected virtual void LoadHolder()
    {
        holder = transform.Find("holder");

    }
    protected virtual void HideItem(Transform item)
    {
        item.gameObject.SetActive(false);
    }
    public virtual void Spawn(string prefabName, Vector3 position, Quaternion rotation)
    {
        Transform newPrefab = Instantiate(GetPrefabByName(prefabName), position, rotation);
        newPrefab.parent = holder;
        newPrefab.gameObject.SetActive(true);

    }
    protected virtual Transform GetPrefabByName(string prefabName)
    {
        foreach (Transform item in listObject)
        {
            if (prefabName == item.name) return item;
        }
        return null;
    }
    protected virtual Transform GetPrefabFromPool(Transform prefab){
        return null;

    }



}
