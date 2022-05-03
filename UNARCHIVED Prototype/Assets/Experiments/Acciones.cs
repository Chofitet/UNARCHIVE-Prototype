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
    //Bitacoras


    //Funcion llamada cada vez que se apreta el boton aprobar, aplica las acciones
    public void Eliminar(bool action)
    {
        if (action)
        {
            eliminar.tag = "OptActivado";
            Debug.Log(eliminar);
        }
   
    }
    public void LavarCerebro(bool action)
    {
        if (action)
        {
            lavarCerebro.tag = "OptActivado";
            Debug.Log("Lavar cerebro");
        }

    }
    public void Investigar(bool action)
    {
        if (action)
        {
            investigar.tag = "OptActivado";
            Debug.Log("Lavar cerebro");
        }

    }
    public void Hackear(bool action)
    {
        if (action)
        {
          hackear.tag = "OptActivado";
            Debug.Log("Lavar cerebro");
        }

    }
    public void Difamar(bool action)
    {
        if (action)
        {
            difamar.tag = "OptActivado";
            Debug.Log("Lavar cerebro");
        }

    }
    public void Aislar(bool action)
    {
        if (action)
        {
            aislar.tag = "OptActivado";
            Debug.Log("Lavar cerebro");
        }

    }
    public void MontarEscena(bool action)
    {
        if (action)
        {
            crearEscena.tag = "OptActivado";
            Debug.Log("Lavar cerebro");
        }

    }
    public void CrearnoticiaFalsa(bool action)
    {
        if (action)
        {
            crearNoticia.tag = "OptActivado";
            Debug.Log("Lavar cerebro");
        }

    }

    
    
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
        

    }
}
