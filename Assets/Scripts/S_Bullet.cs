using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Bullet : MonoBehaviour
{
    [Header("Bullet")]
    [SerializeField] private float bulletForce;
    [SerializeField] private float LifeTime;
    public int Damage = 3;

    [Header("Components")]
    [SerializeField] private GameObject hitParticle;
    [SerializeField] private Rigidbody rigid;
    [SerializeField] private AudioSource sound;

    // Start is called before the first frame update
    private void Start()
    {
        rigid.AddForce(transform.forward * bulletForce);
        StartCoroutine(KillBullet());
    }

    // Update is called once per frame
    private IEnumerator KillBullet()
    {
        yield return new WaitForSeconds(LifeTime);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (sound.enabled)
        {
            sound.Play();
        }
        GameObject p = Instantiate(hitParticle, transform.position, Quaternion.LookRotation(collision.contacts[0].normal * 10.0f));
        if (collision.gameObject.GetComponent<MeshRenderer>())
        {
            p.GetComponent<S_HitParticle>().ChangeParticleMat(collision.gameObject.GetComponent<MeshRenderer>().material);
            CheckForDamageble(collision.gameObject);
        }
        CheckForOther(collision);
    }

    void CheckForDamageble(GameObject obj)
    {
        S_Destroyable ds = obj.GetComponent<S_Destroyable>();
        if(ds)
        {
            ds.ApplyDamage(Damage);
            Destroy(gameObject);
        }
    }

    void CheckForOther(Collision col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<S_Enemy>().TakeDamage(Damage);
            Destroy(gameObject);
        }
    }
}