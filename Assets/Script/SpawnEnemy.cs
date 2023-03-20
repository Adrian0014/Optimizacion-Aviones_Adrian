using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    public int enemyType;

  


    int randEnemy;

    void Start()
    {
       
        StartCoroutine(waitSpawner());
    }

    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
     
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while(!stop)
        {
            randEnemy = Random.Range (0,enemies.Length);
            Vector3 spawnPosition = new Vector3(Random.Range (-spawnValues.x, spawnValues.x), 1, transform.position.z);
            GameObject enemy = PoolManager.Instance.GetPooledObjects(enemyType, spawnPosition, transform.rotation);
            enemy.SetActive(true);
            Debug.Log("Saca enemigo");
            yield return new WaitForSeconds (spawnWait);
        }
    }


 

}
