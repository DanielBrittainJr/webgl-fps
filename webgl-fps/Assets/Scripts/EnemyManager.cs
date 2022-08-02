using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
        SpawnNewEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnNewEnemy()
    {
        
        int randomNumber = Mathf.RoundToInt(Random.Range(0f,spawnPoints.Length-1));
        Instantiate(enemyPrefab,spawnPoints[randomNumber].transform.position, Quaternion.identity);
    }
}
