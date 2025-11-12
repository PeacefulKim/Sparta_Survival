using JetBrains.Annotations;
using System;
using UnityEngine;

public enum ConsumableType
{
    Health,
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
    
}
