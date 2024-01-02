using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTT2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject DG;
    public GameObject Player;
    public GameObject inimigo;
    public GameObject inimigo1;
    public GameObject vida;
    void Start()
    {
        DG.SetActive(true);
        Player.SetActive(false);
        vida.SetActive(false);
        inimigo.SetActive(false);
        inimigo1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void button()
    {
        DG.SetActive(false);
        Player.SetActive(true);
        vida.SetActive(true);
        inimigo.SetActive(true);
        inimigo1.SetActive(true);
    }
}
