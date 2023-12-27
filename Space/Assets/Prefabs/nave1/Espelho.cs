using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espelho : MonoBehaviour
{
    
    private Rigidbody2D Rig;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Rig.velocity.x < 0)
        {
            transform.localScale = new Vector3(180, 0, 0); // Espelha horizontalmente
        }
        else if (Rig.velocity.x > 0)
        {
            transform.localScale = new Vector3(0, 0, 0); // Mantém a escala original
        }
    }
}
