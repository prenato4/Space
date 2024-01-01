using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBossFinal : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D Rig;

    
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
       

    }

    private void Update()
    {
        // Mover a bala em linha reta na direção da rotação da nave espacial
        Rig.velocity = transform.right * speed;
        Destroy(gameObject, 2f);
    }

    /*private void OnTriggerEnter2D(Collider2D CO )
    {
        if (CO.gameObject.tag == "Player")
        {
            CO.GetComponent<Player>().damage(damage);
            Destroy(gameObject);
        }
        
    }*/
}
