using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : GiangMonoBehavior
{
    public static Spawner Instance { get => instance; }
    private static Spawner instance ;
    [SerializeField] private List<Transform> listObject;

    protected override void Awake()
    {
        instance = this;
        base.Awake();     
    }
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
    protected virtual void HideItem(Transform item)
    {
        item.gameObject.SetActive(false);
    }
    public virtual void ShowItem(Vector3 position, Quaternion rotation)
    {
        Transform newBullet = Instantiate(listObject[0], position, rotation);
        newBullet.gameObject.SetActive(true);
    }




}
