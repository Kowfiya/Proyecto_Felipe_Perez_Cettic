using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reiniciar : MonoBehaviour {

    public Tiempo t;
	void Start () {
        t = GameObject.Find("TimeManager").GetComponent<Tiempo>();
	}

    public void BotonR()
    {
        if(t.perdio == true)
        {
            SceneManager.LoadScene(0);
        }
    }
}
