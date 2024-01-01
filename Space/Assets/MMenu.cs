using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMenu : MonoBehaviour
{
    
    public float speed = 3f;
    public float rotationSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        
        // Rotaciona o objeto em torno do eixo Z
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        Destroy(gameObject, 5f);
    }
}
