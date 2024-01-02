using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosFinal : MonoBehaviour
{

    public int vidaMaxima = 100;
    public int vidaAtual; 
    
    public GameObject tiroPrefab;
    public Transform[] pontosDeSaida;
    public float velocidadeDoTiro;
    public float rotationSpeed;
    public float tempodeintervalo;
    public float tempodeINCIO;

    private void Start()
    {
        InvokeRepeating("Atirar", tempodeINCIO,tempodeintervalo);
    }

    void Update()
    {
        if (vidaAtual <= 0)
        {
            Destroy(gameObject);
        }
        
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
    
    void ReceberDano(int dano)
    {
        vidaAtual -= dano;
    }

    
}
