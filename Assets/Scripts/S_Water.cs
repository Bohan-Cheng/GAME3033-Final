using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Water : MonoBehaviour
{
    [SerializeField]GameObject ParticlePrefab;
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(ParticlePrefab, other.transform.position, new Quaternion());
    }
}
