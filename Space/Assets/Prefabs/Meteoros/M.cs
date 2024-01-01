using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M : MonoBehaviour
{
    private Transform player;
    public float speed = 3f;
    public float rotationSpeed = 100f;

    private void Start()
    {
        
        
        
    }

    private void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Rotaciona o meteoro em torno do eixo Z
        //transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);

        if (Player.Q >= 30)
        {
            seguirJo();
        }
        
    }

    void seguirJo()
    {
        
            speed = 4f;
            player = GameObject.FindGameObjectWithTag("Player").transform;
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        
    }
}
