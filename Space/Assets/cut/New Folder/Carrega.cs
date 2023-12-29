using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Carrega : MonoBehaviour
{

    public string CP;

    public GameObject DG;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(CP);
        StartCoroutine(Dg());

    }

    // Update is called once per frame
    void Update()
    {
        //SceneManager.LoadScene(CP);
        
    }

    private IEnumerator Dg()
    {
        yield return new WaitForSeconds(2);
        DG.SetActive(true);
        yield return new WaitForSeconds(3);
        DG.SetActive(false);
    }
}
