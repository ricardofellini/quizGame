using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOffSet : MonoBehaviour
{


    private Material materialAtual;
    public float velocidade;
    public float offSet;

    void Start()
    {


        materialAtual = GetComponent<Renderer>().material;

        
    }

    
    void FixedUpdate()
    {

        offSet += 0.001f;
        materialAtual.SetTextureOffset ("_MainTex", new Vector2(offSet * velocidade, 0));


    }
}
