using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Acciones : MonoBehaviour
{
    [SerializeField] internal Libreta libreta;
    [SerializeField] internal Bitacoras bitacoras;

    public ToggleGroup acciones;
    public Toggle eliminar;
    public Toggle lavarCerebro;
    public Toggle investigar;
    public Toggle hackear;
    public Toggle difamar;
    public Toggle aislar;
    public Toggle crearNoticia;
    public Toggle crearEscena;

    public TMP_Text txtEliminar;
    public TMP_Text txtLavarCerebro;
    public TMP_Text txtInvestigar;
    public TMP_Text txtHackear;
    public TMP_Text txtDifamar;
    public TMP_Text txtAislar;
    public TMP_Text txtCrearNoticia;
    public TMP_Text txtCrearEscena;

    void Update()
    {   // (de a acá)
        if (eliminar.isOn == true) { txtEliminar.text = libreta.Palabras.options[libreta.Palabras.value].text; }
        else { txtEliminar.text = ""; }

        if (lavarCerebro.isOn == true) { txtLavarCerebro.text = libreta.Palabras.options[libreta.Palabras.value].text; }
        else { txtLavarCerebro.text = ""; }

        if (investigar.isOn == true) { txtInvestigar.text = libreta.Palabras.options[libreta.Palabras.value].text; }
        else { txtInvestigar.text = ""; }

        if (hackear.isOn == true) { txtHackear.text = libreta.Palabras.options[libreta.Palabras.value].text; }
        else { txtHackear.text = ""; }

        if (difamar.isOn == true) { txtDifamar.text = libreta.Palabras.options[libreta.Palabras.value].text; }
        else { txtDifamar.text = ""; }

        if (aislar.isOn == true) { txtAislar.text = libreta.Palabras.options[libreta.Palabras.value].text; }
        else { txtAislar.text = ""; }

        if (crearNoticia.isOn == true) { txtCrearNoticia.text = libreta.Palabras.options[libreta.Palabras.value].text; }
        else { txtCrearNoticia.text = ""; }

        if (crearEscena.isOn == true) { txtCrearEscena.text = libreta.Palabras.options[libreta.Palabras.value].text; }
        else { txtCrearEscena.text = ""; }
        //(hasta acá) rellenan las palabras al lado de las acciones
    }
    //Funcion llamada cada vez que se apreta el boton aprobar, aplica las acciones
    public void Eliminar(bool action)
    {
        if (action) { eliminar.tag = "OptActivado";  }
    }
    public void LavarCerebro(bool action)
    {
        if (action){ lavarCerebro.tag = "OptActivado"; }
    }
    public void Investigar(bool action)
    {
        if (action){ investigar.tag = "OptActivado"; }
    }
    public void Hackear(bool action)
    {
        if (action){ hackear.tag = "OptActivado";}
    }
    public void Difamar(bool action)
    {
        if (action) {difamar.tag = "OptActivado";}
    }
    public void Aislar(bool action)
    {
        if (action){ aislar.tag = "OptActivado";}
    }
    public void MontarEscena(bool action)
    {
        if (action){crearEscena.tag = "OptActivado";}
    }
    public void CrearnoticiaFalsa(bool action)
    {
        if (action){ crearNoticia.tag = "OptActivado"; }
    }

    //Se activa con el boton aprobar, descelecciona y destaguè los toggles de las acciones
    public void Restablecer()
    {
        eliminar.tag = "OptDesactivado";
        lavarCerebro.tag = "OptDesactivado";
        investigar.tag = "OptDesactivado";
        hackear.tag = "OptDesactivado";
        difamar.tag = "OptDesactivado";
        aislar.tag = "OptDesactivado";
        crearEscena.tag = "OptDesactivado";
        crearNoticia.tag = "OptDesactivado";
        eliminar.isOn = false;
        lavarCerebro.isOn = false;
        investigar.isOn = false;
        hackear.isOn = false;
        difamar.isOn = false;
        aislar.isOn = false;
        crearEscena.isOn = false;
        crearNoticia.isOn = false;
    }
}
