using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {

    WWW www;
    string url = "http://localhost/proyectocettic/Login.php";
    string user, paso, textoPagina;
    public InputField usuario, password;
    public GameObject logeo;
    public Text txt, passmala;
    public string Nombre_usuario;
    public bool logeado;
    string[] partido;

	void Start () {
        passmala.text = "";
        logeado = false;
	}

	void Update () {
        txt.text = "Bienvenido: " + Nombre_usuario;
    }

    public void Boton()
    {
        if (usuario != null && password != null)
        {
            user = usuario.text;
            paso = password.text;
            
            StartCoroutine(Iniciar_usuario(user, paso));
        }
    }

    IEnumerator Iniciar_usuario(string a, string b)
    {
        WWWForm ingresar = new WWWForm();
        ingresar.AddField("usernamePost", a);
        ingresar.AddField("passwordPost", b);
        www = new WWW(url, ingresar);
        yield return www;
        textoPagina = www.text;
        yield return www;
        print(www.text);
        partido = textoPagina.Split(',');
        if (partido[0] == "mal")
        {
            print("eye");
            passmala.text = "Usuario o Password incorrecta";
        }
        if (partido[0] == "correcto")
        {
            logeo.SetActive(false);
            Nombre_usuario = partido[1];
            logeado = true;
        }
    }
}
