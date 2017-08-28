using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour {
    Rigidbody rigi;
    Animator anim;
    Vector3 movimiento;
    VariablesGlobale var;
    float velocidad;
    float rotacion;
    float giro = 150f;
    float hori, vert;
    public Text text;
    public int puntaje;
    public bool perdioo;
    public Tiempo a;
    public CargarDatos data;
    bool mover;

	void Start () {
        var = GameObject.Find("GameManager").GetComponent<VariablesGlobale>();
        data = GameObject.Find("Network Manager").GetComponent<CargarDatos>();
        a = GameObject.Find("TimeManager").GetComponent<Tiempo>();
        anim = GetComponent<Animator>();
        rigi = GetComponent<Rigidbody>();
        puntaje = 0;
        text.text = "Puntos: " + puntaje;
	}
    void Update()
    {
    }

	void FixedUpdate () {
        perdioo = a.perdio;
        if (data.iniciar == true)
        {
            if (perdioo == false)
            {
                velocidad = var.Valor_Velocidad;
                hori = Input.GetAxis("Horizontal");
                vert = Input.GetAxis("Vertical");

                movimiento = transform.forward * vert * velocidad * Time.deltaTime;
                rigi.MovePosition(rigi.position + movimiento);
                anim.SetFloat("Velocidad", vert);

                rotacion = hori * giro * Time.deltaTime;
                Quaternion rotacionQ = Quaternion.Euler(0, rotacion, 0);
                rigi.MoveRotation(rigi.rotation * rotacionQ);
            }
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moneda"))
        {
            puntaje += var.Valor_moneda;
            text.text = "Puntos: " + puntaje;
            DestroyObject(other);
        }
    }
}
