using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireinimigo1 : MonoBehaviour
{
    public float Speed;
    public int damage;

    public Rigidbody2D Rig;
    public Animator A;

    
    
    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
        A = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D CO)
    {
        if (CO.gameObject.tag == "Player")
        {
            CO.GetComponent<Player>().damage(damage);
            //A.SetBool("hit", true);
            Destroy(gameObject);
        }
    }
}
