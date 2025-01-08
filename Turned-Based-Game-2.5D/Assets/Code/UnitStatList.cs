using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Unit Stats List")]
public class UnitStatList : ScriptableObject
{
    public UnitClass unitClass;

    public int Health;

    public int MinDamage;
    public int MaxDamage;

    public int Range;

    public int Armor;
    
    public enum UnitClass
    {
        SwordMen,
        Archers,
        Tanks,
        Spears,
        Mages,
    }
}
