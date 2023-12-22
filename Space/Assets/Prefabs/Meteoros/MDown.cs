using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDown : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 0f;

    private void Update()
    {
        // Move o objeto para baixo
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        // Rotaciona o meteoro em torno do eixo Z
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
