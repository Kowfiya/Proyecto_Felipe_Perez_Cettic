using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class CargarDatos : MonoBehaviour {
    WWW www;
    string url = "http://localhost/proyectocettic/modifi.json";
    public GameObject canvas;
    Login log;
    public bool iniciar, SiNoCarga;
    public float Velocidad_cargada, Tiempo_cargado;
    public int Moneda_cargada;

    void Start () {
        canvas.SetActive(false);
        iniciar = false;
        log = GameObject.Find("Network Manager").GetComponent<Login>();
    }
	void Update () {
		if(log.logeado == true && iniciar == false)
        {
            canvas.SetActive(true);
        }
	}

    public void SiBoton()
    {
        iniciar = true;
        canvas.SetActive(false);
        StartCoroutine(cargar());
        SiNoCarga = true;
    }
    IEnumerator cargar()
    {
            www = new WWW(url);
            yield return www;
            JSONNode nodo = JSON.Parse(www.text);
            string perro = nodo["Velocidad"].Value;
            Velocidad_cargada = float.Parse(nodo["Velocidad"].Value);
            Tiempo_cargado = float.Parse(nodo["Viempo"].Value);
            Moneda_cargada = int.Parse(nodo["Vuntos"].Value);
        SiNoCarga = true;
        yield return new WaitForSeconds(0.5f);
        SiNoCarga = false;
    }

    public void NoBoton()
    {
        iniciar = true;
        canvas.SetActive(false);
        SiNoCarga = false;
    }
}
