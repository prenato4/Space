using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1 : MonoBehaviour
{

    public int Health;
    public int damage;
    
    public float speed;

    public float Timer;
    public float Wtimer;

    public bool Walk;

    private Animator An;
    private Rigidbody2D Rig;


    public Transform Spawn1;
    public Transform Spawn2;

    public GameObject Fire1;
    
    
    
    public Transform[] patrolPoints;
    public float moveSpeed = 5f;

    private int currentPatrolIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        An = GetComponent<Animator>();
        Rig = GetComponent<Rigidbody2D>();
        Invoke("StartFire", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
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
        An.SetBool("Ishit", true);
        Health -= D;
        Invoke("RH", 0.3f);

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    void RH()
    {
        An.SetBool("Ishit", false);
    }


    void StartFire()
    {
        InvokeRepeating("IFire", 0f, 5f);
    }
    
    
    void IFire()
    {
        Instantiate(Fire1, Spawn1.position, Spawn1.rotation);
        Instantiate(Fire1, Spawn2.position, Spawn2.rotation);
    }
}
