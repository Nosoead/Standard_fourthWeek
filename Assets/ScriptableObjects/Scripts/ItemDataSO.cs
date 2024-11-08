using System;
using UnityEngine;


//강의내용에서 필요한 만큼 추가했습니다.
[Serializable]
public class ItemDataConsumable
{
    public ConsumableType type;
    public float value;
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemDataSO : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType itemType;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Equip")]
    public EquipmentSlotType equipmentSlotType;
    public GameObject equipPrefab;

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;

}
