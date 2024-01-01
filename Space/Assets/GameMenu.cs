using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    
    public GameObject[] prefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 2f, spawnInterval);
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
