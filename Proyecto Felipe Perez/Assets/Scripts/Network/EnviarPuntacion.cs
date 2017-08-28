using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class EnviarPuntacion : MonoBehaviour {

    public string INuser, INpuntos;
    string url = "http://localhost/proyectocettic/ingresarpuntos.php";
    string urljson = "http://localhost/proyectocettic/basepuntaje.json";
    WWW www, www2;
    public Tiempo t;
    public Login log;
    public Controlador c;
    public GameObject boto;

	void Start () {
        t = GameObject.Find("TimeManager").GetComponent<Tiempo>();
        log = GameObject.Find("Network Manager").GetComponent<Login>();
        c = GameObject.Find("Player").GetComponent<Controlador>();

        StartCoroutine(cargaD());
    }

    IEnumerator cargaD()
    {
        www2 = new WWW(urljson);
        yield return www2;
        JsonData data = JsonMapper.ToObject(www2.text);
        //Debug.Log(data["nombre"]);
        print(www2.text);
    }
	void Update () {
    }

    public void botonEnv()
    {
        INuser = log.Nombre_usuario;
        INpuntos = c.puntaje.ToString();
        StartCoroutine(enviarPuntiacion(INuser, INpuntos));
        boto.SetActive(false);
    }

    IEnumerator enviarPuntiacion(string a, string b)
    {
        WWWForm enviar_P = new WWWForm();
        enviar_P.AddField("usuarioPost", a);
        enviar_P.AddField("puntosPost", b);
        www = new WWW(url, enviar_P);
        yield return www;
    }
}
