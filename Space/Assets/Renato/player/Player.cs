using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Health;
    public float MHealth;
    public float QM;
    public static float Q;
    public Image QQ;
    public GameObject GameOver;
    public Image healthBar;
    public float Speed;
    public bool BP;
    public GameObject Fire1;
    public Transform SpawnU;
    public Transform SpawnU1;
    private Rigidbody2D rig;
    private BoxCollider2D box;
    private Animator An;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
        An = GetComponent<Animator>();
        GameOver.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //Movimentação na Vertical e Horizontal;
        float MH = Input.GetAxis("Horizontal");
        float MV = Input.GetAxis("Vertical");
        Vector3 M = new Vector3(MH, MV, 0);
        transform.position += M.normalized * Speed * Time.deltaTime;
        
        UpdateB();

        if (Input.GetKeyDown(KeyCode.F))
        {
            Fire();
        }

        if (Q >= 30)
        {
            Speed = 5;
        }

        if (Health <= 0)
        {
            An.SetBool("explo", true);
            GameOver.SetActive(true); // Ativar o objeto GameOver quando a saúde for zero
        }

    }

    private void UpdateB()
    {
        healthBar.fillAmount = Health / MHealth;
        QQ.fillAmount = Q / QM;

        
    }
    
    

    public void damage(int DM)
    {
        An.SetBool("Ishit", true);
        Health -= DM;
        Invoke("RH", 0.3f);
    }

    void RH()
    {
       An.SetBool("Ishit", false);
    }

    void Fire()
    {
        Instantiate(Fire1, SpawnU.position, SpawnU.rotation);
        Instantiate(Fire1, SpawnU1.position, SpawnU1.rotation);
    }

    public string collisionTag = "Wall";

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            // Impede o jogador de passar por dentro do trigger
            transform.position = Vector3.MoveTowards(transform.position, other.transform.position, -0.1f);
        }

        if (other.gameObject.tag == "Met")
        {
            An.SetBool("explo", true);
            Health = 0;

        }
        
        if (other.gameObject.tag == "N1")
        {
            An.SetBool("explo", true);
            Health = 0;

        }
    }
    
    
}
