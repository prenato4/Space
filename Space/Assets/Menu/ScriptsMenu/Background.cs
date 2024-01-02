using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float ve;


    private void Update()
    {
        MC();
    }


    private void MC()
    {
        Vector2 DC = new Vector2(0f,Time.time * ve);
        GetComponent<Renderer>().material.mainTextureOffset = DC;
    }
}
