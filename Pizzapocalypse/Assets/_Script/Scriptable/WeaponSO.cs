using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "GunType")]
public class WeaponSO : ScriptableObject
{
    public enum WeaponType { Pistal , AssultRifle, Knife};

    public float weaponMaxDamage;
    public int weaponMaxAmmo; 

    public WeaponType weaponType;


}
