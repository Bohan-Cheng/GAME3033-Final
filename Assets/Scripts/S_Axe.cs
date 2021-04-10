using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Axe : MonoBehaviour
{
    public int Damage = 2;
    [SerializeField] private float FireRate = 1.0f;
    [SerializeField] private Animator anim;
    [SerializeField] private AudioSource sound;
    [SerializeField] private ParticleSystem HitParticle;
    bool canFire = true;

    private void Update()
    {
        if (canFire && Input.GetMouseButton(0))
        {
            anim.SetTrigger("Attack");
            canFire = false;
            StartCoroutine(ResetFireRate());
        }
    }

    IEnumerator ResetFireRate()
    {
        yield return new WaitForSeconds(FireRate);
        canFire = true;
    }

    public void playHit()
    {
        sound.Play();
        HitParticle.Play();
    }


    public void ResetItem()
    {
        canFire = true;
    }
}
