using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 1f;

    private void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
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
