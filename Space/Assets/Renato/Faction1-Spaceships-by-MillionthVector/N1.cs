using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class N1 : MonoBehaviour
{

    public float Health;
    public float mHealth;
    public Image healthBar;
    public int damage;
    
    public GameObject tiroPrefab;
    public Transform[] pontosDeSaida;
    public float velocidadeDoTiro;

    public GameObject Fim;
    

    private Animator An;
    private Rigidbody2D Rig;


    public float TempodeTiro;
    public float TempodeInicio;
    
    public Transform[] patrolPoints;
    public float moveSpeed = 5f;

    private int currentPatrolIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Atirar", TempodeInicio,TempodeTiro);
        
        An = GetComponent<Animator>();
        Rig = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateB();
    }
    
    private void UpdateB()
    {
        healthBar.fillAmount = Health / mHealth;


    }

    private void FixedUpdate()
    {
        /*Timer += Time.deltaTime;

        if (Timer >= Wtimer)
        {
            Walk = !Walk;
            Timer = 0f;
            
        }

        if (Walk)
        {
            Rig.velocity = Vector2.left * speed;
        }
        else
        {
            Rig.velocity = Vector2.right * speed;
        }*/
        
        // Move towards the current patrol point
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPatrolIndex].position, moveSpeed * Time.deltaTime);

        // If the enemy reaches the patrol point, move to the next one
        if (Vector3.Distance(transform.position, patrolPoints[currentPatrolIndex].position) < 0.1f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        }

        
        
            
        
    }

    public void Damage(int D)
    {
        //An.SetBool("Ishit", true);
        Health -= D;
        Invoke("RH", 0.3f);

        if (Health <= 0)
        {
            Fim.SetActive(true);
            Destroy(gameObject);
        }
    }
    
    void RH()
    {
        An.SetBool("Ishit", false);
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
