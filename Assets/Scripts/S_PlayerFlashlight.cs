using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_PlayerFlashlight : MonoBehaviour
{
    private Light Flashlight;

    // Use this for initialization
    private void Start()
    {
        Flashlight = transform.Find("Flashlight").GetComponent<Light>();
    }

    // Update is called once per frame
    private void Update()
    {
        OnAndOffFlashlight();
    }

    private void OnAndOffFlashlight()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Flashlight.intensity == 0)
            {
                Flashlight.intensity = 1f;
            }
            else
            {
                Flashlight.intensity = 0;
            }
        }
    }
}