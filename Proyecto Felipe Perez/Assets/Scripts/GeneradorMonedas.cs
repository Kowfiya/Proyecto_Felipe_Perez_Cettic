using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMonedas : MonoBehaviour {

    public GameObject moneda;
    public GameObject[] monedasArray;

    void Update()
    {
        monedasArray = GameObject.FindGameObjectsWithTag("Moneda");
        if(monedasArray.Length == 0)
        {
            Generador();
        }
    }

    void Generador()
    {
        for(int i = 0; i < 30; i++)
        {
            Vector3 espacio = new Vector3(Random.Range(-18f, 18f), 1f, Random.Range(-18f, 18f));
            Instantiate(moneda, espacio, transform.rotation);
        }
    }
}
