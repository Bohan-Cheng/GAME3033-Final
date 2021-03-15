using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_HitParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystemRenderer ParticleR;
    [SerializeField] private float LifeTime;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(KillSelf());
    }

    private IEnumerator KillSelf()
    {
        yield return new WaitForSeconds(LifeTime);
        Destroy(gameObject);
    }

    public void ChangeParticleMat(Material mat)
    {
        ParticleR.material = mat;
    }
}