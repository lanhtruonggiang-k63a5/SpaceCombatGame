using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "ItemProfileSO", menuName = "SO/ItemProfile")]
public class ItemProfileSO : ScriptableObject
{
    public ItemType itemType = ItemType.NoType;
    public ItemEnum itemEnum = ItemEnum.NoName;
    public string itemName = "no-name";
    public int defaultMaxStack = 7;
    public List<ItemRecipe> upgradeLevels; 

}
