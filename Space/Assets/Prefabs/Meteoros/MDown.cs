using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MDown : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 0f;
    public float MT;
    private Vector3 direction;

    public bool DD = false;





    private void Start()
    {
        Destroy(gameObject, MT);
        
        
    }

    private void Update()
    {
        if (Player.Q < 30)
        {
            // Move o objeto para baixo
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            // Rotaciona o meteoro em torno do eixo Z
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
            
        }
        
        if (Player.Q >= 30 && !DD)
        {
            rotationSpeed = 100;
            // Define uma direção de movimento aleatória para o meteoro
            direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
            DD = true;
        }
        
        if (Player.Q >= 30)
        {
            // Move o meteoro na direção definida
            transform.position += direction * speed * Time.deltaTime;

            // Rotaciona o meteoro em torno do eixo Z
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
    }
}
