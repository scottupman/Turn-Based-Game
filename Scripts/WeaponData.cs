using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "weaponObject", menuName = "Weapon")]
public class WeaponData : ScriptableObject
{
    [Header("Weapon Stats")]
    public string weapon;
    public string atkDamage;
    public string hitAmount;
    public string critChance;

    [Header("Weapon Description")]
    [TextArea]
    public string weaponDescription;

    public void displayWeaponData()
    {

    }
}
