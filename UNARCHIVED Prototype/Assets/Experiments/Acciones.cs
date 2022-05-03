using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Acciones : MonoBehaviour
{
    [SerializeField] internal Libreta libreta;
    
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

    public TMP_Text b1;
    public TMP_Text b2;
    public TMP_Text b3;
    public TMP_Text b4;

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

    public void ActualizarBitacoras()
    {
       
          if (libreta.palabra == 1 && eliminar.CompareTag(tag = "OptActivado"))
          {
              b1.text = "Ben a sido eliminado exitosamente";
            eliminar.isOn = false;
          }
          if (libreta.palabra == 2 && eliminar.CompareTag(tag = "OptActivado"))
          {
              b2.text = "Pie Grade dio pelea, perdimos un agente";
            eliminar.isOn = false;
        } 
        if (libreta.palabra == 1 && lavarCerebro.CompareTag(tag = "OptActivado"))
        {
            b3.text = "Mision completada, parece que el niño ha olvidado todo";
            lavarCerebro.isOn = false;
        }
        if (libreta.palabra == 2 && lavarCerebro.CompareTag(tag = "OptActivado"))
        {
            b4.text = "Fracasamos, parece que el amor de Pie Grande es demasiado como para olvidar. Perdimos al agente";
            lavarCerebro.isOn = false;
        }

        Restablecer();

    }
    
    void Restablecer()
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
