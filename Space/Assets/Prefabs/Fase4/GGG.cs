using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGG : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 1f;
    public float Interval = 1f;
    void Start()
    {
        InvokeRepeating("SpawnObject", Interval, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void SpawnObject()
    {
        int randomIndex = Random.Range(0, prefabs.Length);
        GameObject prefab = prefabs[randomIndex];

        int randomSpawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomSpawnIndex];

        Instantiate(prefab, spawnPoint.position, Quaternion.identity);
    }
}
