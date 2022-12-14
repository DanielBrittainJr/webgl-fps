using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;

    [SerializeField] private float spawnTime;
    [SerializeField] private float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {

        for(int spawnCount =0;spawnCount <=10; spawnCount++)
        {
            SpawnNewEnemy();
        }    
        
    }

    private void Update()
    {
        
    }


    void SpawnNewEnemy()
    {
        
        int randomNumber = Mathf.RoundToInt(Random.Range(0f,spawnPoints.Length-1));
        Instantiate(enemyPrefab,spawnPoints[randomNumber].transform.position, Quaternion.identity);
    }
}
