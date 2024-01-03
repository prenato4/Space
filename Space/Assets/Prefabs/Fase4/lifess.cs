using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifess : MonoBehaviour
{

    private Animator An;
    public int vida;
    // Start is called before the first frame update
    void Start()
    {
        An = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0 )
        {
            An.SetBool("h",true);
            Destroy(gameObject, 0.1f);
        }
    }
    
    public void Damage(int dano)
    {
        vida -= dano;
    }
}
