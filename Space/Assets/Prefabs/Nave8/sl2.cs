using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sl2 : MonoBehaviour
{
    public float velocidade = 5f; // Velocidade de movimento do objeto

    void Update()
    {
        // Movendo o objeto para baixo
        transform.Translate(Vector3.right * velocidade * Time.deltaTime);
        // Girando o objeto em 180 graus no eixo Y
        transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        
        Destroy(gameObject, 3f);
    }
}
