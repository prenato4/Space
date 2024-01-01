using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sla : MonoBehaviour
{
    public float velocidade = 5f; // Velocidade de movimento do objeto

    void Update()
    {
        // Movendo o objeto para baixo
        transform.Translate(Vector3.down * velocidade * Time.deltaTime);
        
        
        Destroy(gameObject, 3f);
    }
}
