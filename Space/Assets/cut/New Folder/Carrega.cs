using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Carrega : MonoBehaviour
{

    public string CP;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(CP);
    }

    // Update is called once per frame
    void Update()
    {
        //SceneManager.LoadScene(CP);
    }
}
