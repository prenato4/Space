using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetaMet : MonoBehaviour
{
    
    
    public int scoreValue = 1;
    //private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //sound = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D(Collider2D CO)
    {
        if (CO.gameObject.tag == "Player")
        {
            //sound.Play();
            Player player = CO.gameObject.GetComponent<Player>();
            if (player != null)
            {
                Player.Q += scoreValue; // Incrementa o valor de Q quando o item é coletado
                // Você pode adicionar aqui qualquer outra lógica que precise ser executada quando o item é coletado
            }
            Destroy(gameObject, 0.1f);

            
        }
    }

}
