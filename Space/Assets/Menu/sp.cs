using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp : MonoBehaviour
{
    public GameObject objectPrefab; // Prefab do objeto a ser recriado
    public Transform spawnPoint; // Ponto de spawn do novo objeto

    private GameObject currentObject; // Referência para o objeto atualmente em cena

    private void Start()
    {
        SpawnObject();
    }

    private void SpawnObject()
    {
        // Cria um novo objeto a partir do prefab no spawn point
        currentObject = Instantiate(objectPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    private void DestroyObject()
    {
        // Destroi o objeto atual
        Destroy(currentObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto atual colidiu com algum outro objeto
        if (other.CompareTag("Player"))
        {
            DestroyObject();
            SpawnObject();
        }
    }
}
