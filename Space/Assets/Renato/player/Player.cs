using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Speed;

    public float SR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimentação na Vertical e Horizontal;
        float MH = Input.GetAxis("Horizontal");
        float MV = Input.GetAxis("Vertical");
        Vector3 M = new Vector3(MH, MV, 0);
        transform.position += M.normalized * Speed * Time.deltaTime;
        
        //tentaiva de Fazer a rotação, mas usarei para os Inimigos
        /*float R = Input.GetAxis("Mouse X") * SR;
        transform.Rotate(0, SR, 0);*/
        

    }
}
