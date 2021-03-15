using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_LifeTime : MonoBehaviour
{
    [SerializeField] float LifeTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(KillSelf());
    }

    IEnumerator KillSelf()
    {
        yield return new WaitForSeconds(LifeTime);
        Destroy(gameObject);
    }
}
