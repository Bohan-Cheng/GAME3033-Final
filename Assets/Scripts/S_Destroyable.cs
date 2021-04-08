using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Destroyable : MonoBehaviour
{
    [SerializeField] GameObject parent;
    [SerializeField] int Health = 9;
    Vector3 OriScale;
    bool isOnDamage = false;

    private void Start()
    {
        OriScale = transform.localScale;
    }

    private void Update()
    {
        if(isOnDamage)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, OriScale, 5.0f * Time.deltaTime);
        }
    }

    public void ApplyDamage(int dmg)
    {
        Health -= dmg;
        if(Health <= 0)
        {
            ObjectDeath();
        }
        transform.localScale *= 0.8f;
        isOnDamage = true;
        CancelInvoke();
        Invoke("ResetResize", 2.0f);

        switch (gameObject.tag)
        {
            case "Crystal":
                FindObjectOfType<S_ResourceHolder>().Crystals += dmg;
                break;
            case "Stone":
                FindObjectOfType<S_ResourceHolder>().Stones += dmg;
                break;
            case "Wood":
                FindObjectOfType<S_ResourceHolder>().Woods += dmg;
                break;
            default:
                break;
        }

        FindObjectOfType<S_ResourceHolder>().UpdateUI();
    }

    void ResetResize()
    {
        isOnDamage = false;
    }

    void ObjectDeath()
    {
        Destroy(parent);
    }
}
