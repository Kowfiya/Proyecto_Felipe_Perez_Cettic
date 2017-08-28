using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camarafollow : MonoBehaviour {

    CargarDatos dat;
    public Transform player;
    float suave = 0.2f;
    Vector3 inicial;

	void Start () {
        dat = GameObject.Find("Network Manager").GetComponent<CargarDatos>();
        inicial = transform.position - player.transform.position;
    }
	void Update () {
		if(dat.iniciar == true)
        {
            Vector3 ir = player.position + inicial;
            //Vector3 suaveIr = Vector3.Lerp(transform.position, ir, suave);
            transform.position = ir;
            transform.LookAt(player);
        }
	}
}
