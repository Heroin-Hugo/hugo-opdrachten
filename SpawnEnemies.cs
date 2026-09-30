using System.Collections;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject[] enemiesToSpawn;
    [SerializeField] private float enemySpawnDelay;

    private void Start() => StartCoroutine(SpawnEnemy());
    private IEnumerator SpawnEnemy()
    {
        int randInt = Random.Range(0, enemiesToSpawn.Length);
        Instantiate(enemiesToSpawn[randInt], transform.position, Quaternion.identity);
        yield return new WaitForSeconds(enemySpawnDelay);
        StartCoroutine(SpawnEnemy());
    }
}
