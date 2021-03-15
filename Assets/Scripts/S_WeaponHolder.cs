using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_WeaponHolder : MonoBehaviour
{
    [SerializeField] GameObject Axe;
    [SerializeField] GameObject Gun;

    public void UseWeapon(string name)
    {
        Axe.GetComponent<S_Axe>().ResetItem();
        Gun.GetComponent<S_Gun>().ResetItem();
        if(name == "Axe")
        {
            Gun.SetActive(false);
            Axe.SetActive(true);
        }
        else if(name == "Gun")
        {
            Axe.SetActive(false);
            Gun.SetActive(true);
        }
    }
}
