using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesGlobale : MonoBehaviour {
    public int Valor_moneda;
    public float Valor_tiempo, Valor_Velocidad;
    public float tiempo;
    CargarDatos carg;
    public CargarDatos dat;
    public bool era;

	void Start () {
        dat = GameObject.Find("Network Manager").GetComponent<CargarDatos>();
        carg = GameObject.Find("Network Manager").GetComponent<CargarDatos>();
        Valor_tiempo = 30f;
        Valor_Velocidad = 10f;
        Valor_moneda = 10;
        tiempo = 30;
        era = false;
    }
	
	void Update () {
        if(carg.SiNoCarga == true)
        {
            cargaUnica();
        }
        if(dat.iniciar == true)
        {
            Valor_tiempo -= Time.deltaTime;
        }

	}
    void cargaUnica()
    {
        Valor_Velocidad = carg.Velocidad_cargada;
        Valor_tiempo = carg.Tiempo_cargado;
        Valor_moneda = carg.Moneda_cargada;
        print(Valor_tiempo);
        print(Valor_Velocidad);
        era = true;
    }
}
