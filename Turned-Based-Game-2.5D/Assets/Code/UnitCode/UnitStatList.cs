using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Unit Stats List")] // to create the prefab for the Unit Stat list
public class UnitStatList : ScriptableObject
{
    public UnitClass unitClass; //to stat player class
    [Header("Player Heal")]
    public int Health;
    [Header("Player Damage Range")]
    public int MinDamage;
    public int MaxDamage;

    [Header("Player Stat")]
    public int Range;
    public int Armor;
    public int Speed;
    public string UnitName;
    
    public enum UnitClass //class type
    {
        SwordMen,
        Archers,
        Tanks,
        Spears,
        Mages,
    }
}
