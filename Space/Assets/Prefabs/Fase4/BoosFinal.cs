using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoosFinal : MonoBehaviour
{

    public float Mhealth;
    public float health; 
    public Image healthBar;
    public GameObject Fim;
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
        if (health <= 0)
        {
            Fim.SetActive(true);
            Destroy(gameObject);
        }
        
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        
        UpdateB();
    }
    
    private void UpdateB()
    {
        healthBar.fillAmount = health / Mhealth;


    }

    void Atirar()
    {
        foreach (Transform pontoDeSaida in pontosDeSaida)
        {
            GameObject tiro = Instantiate(tiroPrefab, pontoDeSaida.position, pontoDeSaida.rotation);
            tiro.GetComponent<Rigidbody2D>().velocity = pontoDeSaida.up * velocidadeDoTiro;
        }
    }

    public void Damage(int dano)
    {
        health -= dano;
    }

    
}
