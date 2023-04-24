using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropSpawner : Spawner
{
    public static ItemDropSpawner Instance { get => instance; }
    private static ItemDropSpawner instance;

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) Debug.Log("only 1 DropManager ");
        instance = this;
    }
    public virtual void Drop(List<DropRate> listDrop, Vector3 pos, Quaternion rot)
    {
        ItemEnum itemEnum = listDrop[0].itemProfileSO.itemEnum;
        Transform itemDrop = Spawn(itemEnum.ToString(), pos, rot);
        itemDrop.gameObject.SetActive(true);
    }
}
