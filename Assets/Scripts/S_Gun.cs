using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Gun : MonoBehaviour
{
    [Header("Gun")]
    [SerializeField] private float FireRate = 0.5f;
    bool canFire = true;

    [Header("Components")]
    [SerializeField] private Transform gunBarral;
    [SerializeField] private GameObject bulletprefab;
    [SerializeField] private AudioSource sound;
    [SerializeField] private Animator anim;
    [SerializeField] private ParticleSystem FireParticle;

    // Update is called once per frame
    private void Update()
    {
        if (canFire && Input.GetMouseButton(0))
        {
            sound.Play();
            FireParticle.Play();
            anim.SetTrigger("Fire");
            Instantiate(bulletprefab, gunBarral.position, gunBarral.rotation);
            canFire = false;
            StartCoroutine(ResetFireRate());
        }
    }

    IEnumerator ResetFireRate()
    {
        yield return new WaitForSeconds(FireRate);
        canFire = true;
    }

    public void ResetItem()
    {
        canFire = true;
    }
}