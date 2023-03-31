using UnityEngine;

[CreateAssetMenu(fileName = "ItemProfileSO", menuName = "SO/ItemProfile")]
public class ItemProfileSO : ScriptableObject
{
    public ItemType itemType = ItemType.NoType;
    public ItemEnum itemEnum = ItemEnum.NoName;
    public string itemName = "no-name";
    public int defaultStack = 7;

}
