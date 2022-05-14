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
    public Toggle analizarMuestra;

    public TMP_Text txtEliminar;
    public TMP_Text txtLavarCerebro;
    public TMP_Text txtInvestigar;
    public TMP_Text txtHackear;
    public TMP_Text txtDifamar;
    public TMP_Text txtAislar;
    public TMP_Text txtCrearNoticia;
    public TMP_Text txtCrearEscena;
    public TMP_Text txtAnalizarMuestra;

    public  void CompletarPalabra ()
    {   // (de a acá)
        if (eliminar.isOn == true) { txtEliminar.text = libreta.palabra; }
        else { txtEliminar.text = ""; }

        if (lavarCerebro.isOn == true) { txtLavarCerebro.text = libreta.palabra; }
        else { txtLavarCerebro.text = ""; }

        if (investigar.isOn == true) { txtInvestigar.text = libreta.palabra; }
        else { txtInvestigar.text = ""; }

        if (hackear.isOn == true) { txtHackear.text = libreta.palabra; }
        else { txtHackear.text = ""; }

        if (difamar.isOn == true) { txtDifamar.text = libreta.palabra; }
        else { txtDifamar.text = ""; }

        if (aislar.isOn == true) { txtAislar.text = libreta.palabra; }
        else { txtAislar.text = ""; }

        if (crearNoticia.isOn == true) { txtCrearNoticia.text = ""; }
        else { txtCrearNoticia.text = ""; }

        if (crearEscena.isOn == true) { txtCrearEscena.text = libreta.palabra; }
        else { txtCrearEscena.text = ""; }

        if (analizarMuestra.isOn == true) { txtAnalizarMuestra.text = libreta.palabra; }
        else { txtAnalizarMuestra.text = ""; }
        //(hasta acá) rellenan las palabras al lado de las acciones
    }
    //Funcion llamada cada vez que se apreta el boton aprobar, aplica las acciones
    public void Eliminar(bool action)
    {
        if (action) { eliminar.tag = "OptActivado";  }
        CompletarPalabra();
    }
    public void LavarCerebro(bool action)
    {
        if (action){ lavarCerebro.tag = "OptActivado"; }
        CompletarPalabra();
    }
    public void Investigar(bool action)
    {
        if (action){ investigar.tag = "OptActivado"; }
        CompletarPalabra();
    }
    public void Hackear(bool action)
    {
        if (action){ hackear.tag = "OptActivado";}
        CompletarPalabra();
    }
    public void Difamar(bool action)
    {
        if (action) {difamar.tag = "OptActivado";}
        CompletarPalabra();
    }
    public void Aislar(bool action)
    {
        if (action){ aislar.tag = "OptActivado";}
        CompletarPalabra();
    }
    public void MontarEscena(bool action)
    {
        if (action){crearEscena.tag = "OptActivado";}
        CompletarPalabra();
    }
    public void CrearnoticiaFalsa(bool action)
    {
        if (action){ crearNoticia.tag = "OptActivado"; }
        CompletarPalabra();
    }
    public void AnalizarMuestra (bool action)
    {
        if (action) { analizarMuestra.tag = "OptActivado"; }
        CompletarPalabra();
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
