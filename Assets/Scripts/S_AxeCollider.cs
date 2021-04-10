using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_AxeCollider : MonoBehaviour
{
    [SerializeField] S_Axe axeScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        S_Destroyable dest = other.GetComponent<S_Destroyable>();
        if(dest)
        {
            axeScript.playHit();
            dest.ApplyDamage(axeScript.Damage);
        }

        if (other.tag == "Enemy")
        {
            axeScript.playHit();
            other.GetComponent<S_Enemy>().TakeDamage(axeScript.Damage);
        }
    }
}
