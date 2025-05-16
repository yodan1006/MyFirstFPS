using UnityEngine;

[CreateAssetMenu(fileName = "LootItemData", menuName = "Loot Item")]
public class LootItemData : ScriptableObject
{
    public string m_itemName;
    public string m_itemDescription;
    public int m_price;
    public Sprite m_icon;
}