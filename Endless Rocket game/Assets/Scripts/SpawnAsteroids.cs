using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    [SerializeField] private GameObject[] asteroidsToInstantiate;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    [SerializeField] private float timeBetweenSpawn;
    private float spawnTime;

    void Update()
    {
        if(Time.time>spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }
    void Spawn()
    {
        float RandomX = Random.Range(minX, maxX);
        float RandomY = Random.Range(minY, maxY);

        int n = Random.Range(0, asteroidsToInstantiate.Length);
        Instantiate(asteroidsToInstantiate[n], transform.position + new Vector3(RandomX, RandomY, 0), Quaternion.identity);
    }
}
