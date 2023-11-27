using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int Health;

    public float Speed;

    public bool BP;

    public GameObject Fire1;

    public Transform SpawnU;
    public Transform SpawnU1;
    private Rigidbody2D rig;
    private BoxCollider2D box;
    private Animator An;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
        An = GetComponent<Animator>();
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

        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(Fire1, SpawnU.position, SpawnU.rotation);
            Instantiate(Fire1, SpawnU1.position, SpawnU1.rotation);
        }

    }

    public void damage(int DM)
    {
        An.SetBool("Ishit", true);
        Health -= DM;
        Invoke("RH", 0.5f);
        
    }

    void RH()
    {
       An.SetBool("Ishit", false);
    }
}
