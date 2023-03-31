using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : GiangMonoBehavior
{
    [SerializeField] protected int maxItem = 70;
    [SerializeField] protected List<ItemInventory> items;


    protected override void Start()
    {
        base.Start();
        this.AddItem(ItemEnum.GoldOre, 3);
    }
    protected virtual bool AddItem(ItemEnum itemEnum, int addCount)
    {
        ItemInventory itemInventory = this.GetItemByCode(itemEnum);

        int newCount = itemInventory.itemCount + addCount;
        if (newCount > itemInventory.maxStack) return false;
        itemInventory.itemCount = newCount;
        return true;
    }
    public virtual ItemInventory GetItemByCode(ItemEnum itemEnum)
    {
        ItemInventory itemInventory = this.items.Find((item) => item.itemProfile.itemEnum == itemEnum);
        if (itemInventory == null) itemInventory = AddEmptyProfile(itemEnum);
        return itemInventory;
    }
    public virtual ItemInventory AddEmptyProfile(ItemEnum itemEnum)
    {
        var profiles = Resources.LoadAll("ItemProfiles", typeof(ItemProfileSO));
        foreach (ItemProfileSO profile in profiles)
        {
            if (profile.itemEnum != itemEnum) continue;
            ItemInventory itemInventory = new ItemInventory { itemProfile = profile , maxStack = profile.defaultStack};
            this.items.Add(itemInventory);
            return itemInventory;
        }

        return null;
    }
}
