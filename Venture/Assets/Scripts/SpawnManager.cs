using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private GameObject _enemyContainer;

    [SerializeField]
    private float _spawnTimer;

    [SerializeField]
    private GameObject _diamondPrefab;

    [SerializeField]
    private GameObject _diamondContainer;

    [SerializeField]
    private float _DiamondSpawnTimer;

    private bool _stopSpawning = false;

    void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
        StartCoroutine(SpawnDiamondRoutine());
    }  

    // Spawn an enemy every 5 seconds.
    // while loop -> infinite loop that keeps going until the game ends. 
    IEnumerator SpawnEnemyRoutine()
    {
        while(_stopSpawning == false )
        {
            Vector3 spawnPos = new Vector3(transform.position.x, Random.Range(-3.7f, 3.7f), 0);

            GameObject newEnemy = Instantiate(_enemyPrefab, spawnPos, Quaternion.identity);
            newEnemy.transform.SetParent(_enemyContainer.transform);

            // wait for 5 seconds
            yield return new WaitForSeconds(_spawnTimer);
        }
    }

    IEnumerator SpawnDiamondRoutine()
    {
        while(_stopSpawning == false )
        {
            Vector3 spawnPos = new Vector3(transform.position.x, Random.Range(-3.7f, 3.7f), 0);

            GameObject newDiamond = Instantiate(_diamondPrefab, spawnPos, Quaternion.identity);
            newDiamond.transform.SetParent(_diamondContainer.transform);

            // wait for 5 seconds
            yield return new WaitForSeconds(_DiamondSpawnTimer);
        }
    }

    public void OnPlayerDeath()
{
    _stopSpawning = true;
}

}
