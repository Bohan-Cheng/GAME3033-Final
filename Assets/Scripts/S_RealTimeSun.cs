using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_RealTimeSun : MonoBehaviour
{
    public float RotateTime;

    private Transform sunT;
    private Light sunL;
    private bool dies;
    private bool next;

    private void Start()
    {
        SetOther();
        SetVar();
        StartFlash();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            sunT.Rotate(Vector3.right, 20 * Time.deltaTime);
        }
        else
        {
            Pasttime();
        }

        CheckSun();
        Sunintance();
    }

    private void SetVar()
    {
        RotateTime = 0.14f;
    }

    private void SetOther()
    {
        sunT = transform;
        sunL = GetComponent<Light>();
    }

    private void Pasttime()
    {
        if (dies != true)
        {
            sunT.Rotate(Vector3.right, RotateTime * Time.deltaTime);
        }
        else
        {
            sunT.Rotate(Vector3.right, RotateTime * Time.deltaTime * 3);
        }
    }

    private void StartFlash()
    {
        sunL.intensity = 0;
    }

    private void EndFlash()
    {
        sunL.intensity = 1;
    }

    private void CheckSun()
    {
        if (sunT.eulerAngles.x >= 350 && sunT.eulerAngles.x <= 360 && next != true)
        {
            next = true;
        }

        if (sunT.eulerAngles.x >= 330 && sunT.eulerAngles.x <= 340 && next == true)
        {
            DieSwitch();
        }

        if (sunT.eulerAngles.x >= 0 && sunT.eulerAngles.x <= 10 && next == true)
        {
            DieSwitch();
        }
    }

    private void DieSwitch()
    {
        if (dies != false)
        {
            dies = false;
            next = false;
        }
        else
        {
            dies = true;
            next = false;
        }
    }

    private void Sunintance()
    {
        if (dies == true)
        {
            if (sunL.intensity != 0)
            {
                sunL.intensity -= 0.05f;
            }
        }
        else
        {
            if (sunL.intensity < 1.38f)
            {
                sunL.intensity += 0.05f;
            }
        }
    }
}