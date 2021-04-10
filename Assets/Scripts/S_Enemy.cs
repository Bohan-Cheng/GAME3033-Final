using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class S_Enemy : MonoBehaviour
{
    public int Health = 15;
    private NavMeshAgent agent;
    [SerializeField] GameObject player;
    [SerializeField] float visionRange = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        if(dist <= visionRange)
        {
            agent.isStopped = false;
            agent.SetDestination(player.transform.position);
        }
        else
        {
            agent.isStopped = true;
        }
    }

    public void TakeDamage(int dmg)
    {
        Health -= dmg;
        if(Health <= 0)
        {
            Health = 0;
            ApplyDeath();
        }
    }

    void ApplyDeath()
    {
        Destroy(gameObject);
    }
}
