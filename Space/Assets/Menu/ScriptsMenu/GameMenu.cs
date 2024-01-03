using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    
    public GameObject[] prefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 5f;
    public float spawnincial = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        InvokeRepeating("SpawnObject", spawnincial, spawnInterval);
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

    public void Play()
    {
        SceneManager.LoadScene("Tutorial 1");
    }
    
}
