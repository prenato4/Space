using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour
{
    public float rotationSpeed = 100f; // Velocidade de rotação do objeto

    private void Update()
    {
        // Rotaciona o objeto em torno do eixo Z
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
