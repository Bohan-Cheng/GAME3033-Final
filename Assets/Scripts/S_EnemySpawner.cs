using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            if (transform.childCount == 0) { Instantiate(enemyPrefab, transform); }
            yield return new WaitForSeconds(Random.Range(10, 50));
        }
    }
}
