using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Campfire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, transform.position) <= 3.3f)
        {
            FindObjectOfType<S_ResourceHolder>().Health += 0.05f;
            FindObjectOfType<S_ResourceHolder>().UpdateUI();
            if (FindObjectOfType<S_ResourceHolder>().Health >= 100)
            {
                FindObjectOfType<S_ResourceHolder>().Health = 100;
            }
        }
    }

}
