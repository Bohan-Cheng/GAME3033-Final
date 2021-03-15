using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_WaterFlip : MonoBehaviour
{
    private Transform PlayerCamTrans;
    private Camera PlayerCam;
    private float OrFOV;

    // Use this for initialization
    private void Start()
    {
        PlayerCam = Camera.main;
        PlayerCamTrans = Camera.main.transform;
        OrFOV = PlayerCam.fieldOfView;
    }

    // Update is called once per frame
    private void Update()
    {
        CheckForPosition();
    }

    private void CheckForPosition()
    {
        if (PlayerCamTrans.position.y < transform.position.y)
        {
            if (transform.eulerAngles.x != 180)
            {
                transform.eulerAngles = new Vector3(180, 0, 0);
                PlayerCam.fieldOfView = 50;
                RenderSettings.fogDensity = 0.23f;
            }
        }
        else
        {
            if (transform.eulerAngles.x != 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                PlayerCam.fieldOfView = OrFOV;
                RenderSettings.fogDensity = 0f;
            }
        }
    }
}