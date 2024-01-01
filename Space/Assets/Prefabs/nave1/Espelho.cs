using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espelho : MonoBehaviour
{

    private Rigidbody2D Rig;

// Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
    }

// Update is called once per frame
    void Update()
    {
        if (Rig.velocity.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Rig.velocity.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
    }
}

