using System;
using UnityEngine;

public enum ConsumableType
{
    Health,
    Damage,
    Other
}
[Serializable]
public class ItemDataConsumable
{
    public ConsumableType type;
    public float value;
}
[CreateAssetMenu(fileName = "Item", menuName = "New Item")] 
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public GameObject dropPrefab;
    public ItemDataConsumable[] consumables;

    public void ApplyEffect(PlayerCondition player)
    {
        if (player == null || consumables == null) return;
        foreach(var item in consumables)
        {
            switch (item.type)
            {
                case ConsumableType.Health:
                    player.Heal(item.value);
                    break;
                case ConsumableType.Damage:
                    break;
                case ConsumableType.Other:
                    break;
            }
        }
    }
}
