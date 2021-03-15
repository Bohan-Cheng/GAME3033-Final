using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_PickUp : MonoBehaviour
{
    [SerializeField] string WeaponName;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<S_WeaponHolder>().UseWeapon(WeaponName);
        }
    }
}
