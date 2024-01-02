using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosFinal : MonoBehaviour
{

    public GameObject tiroPrefab;
    public Transform[] pontosDeSaida;
    public float velocidadeDoTiro;
    public float rotationSpeed;

    private void Start()
    {
        InvokeRepeating("Atirar", 2f,4f);
    }

    void Update()
    {
           
        
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    void Atirar()
    {
        foreach (Transform pontoDeSaida in pontosDeSaida)
        {
            GameObject tiro = Instantiate(tiroPrefab, pontoDeSaida.position, pontoDeSaida.rotation);
            tiro.GetComponent<Rigidbody2D>().velocity = pontoDeSaida.up * velocidadeDoTiro;
        }
    }

    
}
