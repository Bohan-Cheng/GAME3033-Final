using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_LookAtCam : MonoBehaviour
{
    [SerializeField] Transform CamTransform;

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = CamTransform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(-relativePos, Vector3.up);
    }
}
