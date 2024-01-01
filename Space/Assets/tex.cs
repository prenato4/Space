using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tex : MonoBehaviour
{
    public float amplitude = 0.1f; // Amplitude do balanço
    public float speed = 1f; // Velocidade do balanço

    private Vector3 initialPosition; // Posição inicial do texto

    private void Start()
    {
        initialPosition = transform.position; // Armazena a posição inicial
    }

    private void Update()
    {
        // Calcula a nova posição vertical baseada no seno do tempo
        float newY = initialPosition.y + Mathf.Sin(Time.time * speed) * amplitude;

        // Atualiza a posição do texto
        transform.position = new Vector3(initialPosition.x, newY, initialPosition.z);
    }
}
