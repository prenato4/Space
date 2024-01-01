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
    public GameObject Barra;
    public GameObject Play;
    public GameObject Vida;
    public bool Ex = false;
    
    private void Start()
    {
        Barra.SetActive(false);
        Play.SetActive(false);
        Vida.SetActive(false);

        DG.SetActive(true);
        Ex = false;
        
    }

    private void Update()
    { 
        if (Player.Q == 30 && !Ex)
        {
            Play.SetActive(false);
            CancelInvoke("SpawnObject");
            DG1.SetActive(true);
            Ex = true;

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
    
    public void Cena1()
    {
        
        DG.SetActive(false);
        Barra.SetActive(true);
        Play.SetActive(true);
        Vida.SetActive(true);
        InvokeRepeating("SpawnObject", 1f, spawnInterval);
        
    }

    public void Cena()
    {
        DG1.SetActive(false);
        Play.SetActive(true);
        InvokeRepeating("SpawnObject", 0f, 0.5f);
    }
    
    
}
