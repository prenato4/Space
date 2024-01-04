using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ba : MonoBehaviour
{
    
    public GameObject DG;
    public GameObject DG1;
    public GameObject DG2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void DGg()
    {
        DG.SetActive(false);
        DG1.SetActive(true);
    }

    public void DGg1()
    {
        DG1.SetActive(false);
        DG2.SetActive(true);
    }
}
