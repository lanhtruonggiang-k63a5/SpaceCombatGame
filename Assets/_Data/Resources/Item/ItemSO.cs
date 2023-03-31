using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "Item", menuName = "SO/Item")]
public class ItemSO : ScriptableObject
{
    public ItemEnum itemCode = ItemEnum.NoName;
    public string itemName = "Item";


}
