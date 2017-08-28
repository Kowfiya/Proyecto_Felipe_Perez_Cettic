using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour{

    public bool perdio = false;
    public float t;
    float tt;
    public Text tx;
    public CargarDatos dat;
    public VariablesGlobale vara;
    public GameObject tabla;

    void Start()
    {
        vara = GameObject.Find("GameManager").GetComponent<VariablesGlobale>();
        dat = GameObject.Find("Network Manager").GetComponent<CargarDatos>();
        tabla.SetActive(false);
        t = vara.Valor_tiempo;
        tx.text = "T: " + t;
    }

    void Update()
    {
        t = vara.Valor_tiempo;
        if (dat.iniciar == true)
        {
            if (t > 0)
            { 
                t += (-1f * Time.deltaTime);
                tx.text = "T: " + t;

                if (t <= 0.0f)
                {
                    perdio = true;
                    t = 0;
                    tabla.SetActive(true);
                }
            }
        }
    }
}
                

