using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 1f;
    public GameObject DG;
    public GameObject DG1;
    
    private void Start()
    {
        
        InvokeRepeating("SpawnObject", 17f, spawnInterval);

        StartCoroutine(ActivateDG());
    }

    private void Update()
    { 
        if (Player.Q == 30)
        {
            CancelInvoke("SpawnObject");
            DG1.SetActive(true);
            
        }
    }
    

    private void SpawnObject()
    {
        int randomIndex = Random.Range(0, prefabs.Length);
        GameObject prefab = prefabs[randomIndex];

        int randomSpawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomSpawnIndex];

        Instantiate(prefab, spawnPoint.position, Quaternion.identity);
    }
    
    private IEnumerator ActivateDG()
    {
        DG.SetActive(true);
        yield return new WaitForSeconds(13f);
        DG.SetActive(false);
        
    }

    public void Cena()
    {
        DG1.SetActive(false);
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }
    
    
}
