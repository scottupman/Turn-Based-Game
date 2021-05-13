using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayWeaponData : MonoBehaviour
{
    public WeaponData weapon;
    // Start is called before the first frame update
    void Start()
    {
        weapon.displayWeaponData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
