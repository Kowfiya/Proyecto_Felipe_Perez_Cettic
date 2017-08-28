using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearUser : MonoBehaviour {

    public InputField INnombre, INcorreo, INcontra;
    string url = "http://localhost/proyectocettic/registrarusuario.php";
    WWW www;
    string nombre, correo, contra, texto_pagina;
    public Text registrobien;

	void Start () {
        registrobien.text = "";
	}
	
	void Update () {
		
	}

    public void BotonRegistro()
    {
        nombre = INnombre.text;
        correo = INcorreo.text;
        contra = INcontra.text;

        StartCoroutine(Registrar(nombre, correo, contra));
    }

    IEnumerator Registrar(string a, string b, string c)
    {
        WWWForm registrar_user = new WWWForm();
        registrar_user.AddField("usernamePost", a);
        registrar_user.AddField("emailPost", b);
        registrar_user.AddField("passwordPost", c);
        www = new WWW(url, registrar_user);
        yield return www;
        texto_pagina = www.text;
        yield return www;
        print(texto_pagina);
        if (texto_pagina == " Bien")
        {
            registrobien.text = "correcto, porfavor inicia sesion";
            print("asad");
        }
    }
}
