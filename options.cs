using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class options : MonoBehaviour
{
    public Canvas cvCerrar, menu, titulo;
    public Button btnCerrar, btnCancelar;
    // Start is called before the first frame update
    void Start()
    {
        cvCerrar.enabled = false;
        menu.enabled = true;
        titulo.enabled = true;
    }

    public void cerrarApp(){
        Application.Quit();
    }

    public void cancelarFin(){
        cvCerrar.enabled = false;
        menu.enabled = true;
        titulo.enabled = true;
    }

    public void mostrarVentanaCierre(){
        cvCerrar.enabled = true;
        menu.enabled = false;
        titulo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
