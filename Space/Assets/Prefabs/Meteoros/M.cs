using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;

    private Vector3 direction;

    private void Start()
    {
        // Define uma direção de movimento aleatória para o meteoro
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
    }

    private void Update()
    {
        // Move o meteoro na direção definida
        transform.position += direction * speed * Time.deltaTime;

        // Rotaciona o meteoro em torno do eixo Z
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
