using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Telefono : MonoBehaviour
{
   
    [SerializeField] Libreta libreta;
    [SerializeField] Bitacoras bitacora;
    public Button btnllamar;
    public Button btnplay;
    public Button btnREC;
    public TMP_Text txtLlamada;
    public GameObject PapelFax;
    private bool BenLlamado;
    private bool PieGrandeLlamado;
    private bool KateLlamado;
    private bool PepeLlamado1;
    private bool PepeLlamado2;
    private bool PepeLlamado3;

    public TMP_Text txtTranscripci�nLlamado;
   
    public  bool LLamadaDiaria;
    string LlamadaEnProgreso;
    float InicioLlamada;

    bool x;

    private void Start()
    {
        PapelFax.SetActive(false);
    }

    private void OnEnable()
    {
        TimeManager.CambioHoras += CooldownTelefono;
    }

    private void OnDisable()
    {
        TimeManager.CambioHoras += CooldownTelefono;
    }

    private void CooldownTelefono() 
    {
        
        if (TimeManager.Hora == InicioLlamada + 3)
        {
            btnplay.interactable = true;
        }
    }
    private void Update()
    {
        if (LLamadaDiaria == false)
        {
            if (txtLlamada.text == "Interceptar linea" || txtLlamada.text == "") { btnREC.interactable = false; btnllamar.interactable = true; InicioLlamada = -200;}
            else btnREC.interactable = true; 
            
        }
        if (LLamadaDiaria == true)
        {
            btnREC.interactable = false;
            btnplay.interactable = false;
            btnllamar.interactable = false;
        }
        if (txtTranscripci�nLlamado.text == "")
        {
            PapelFax.SetActive(false);
        }

    }

    public void Llamar()
    {
        LlamadaEnProgreso = libreta.palabra;
        txtLlamada.text = LlamadaEnProgreso;
        txtTranscripci�nLlamado.text = "";
        
    }

    public void REC()
    {
        if (x == false)
        {
            txtTranscripci�nLlamado.text = "";
            EsLlamable(LlamadaEnProgreso);
        }
        else if (x == true)
        {
            txtTranscripci�nLlamado.text = "";
            btnllamar.interactable = true;
            InicioLlamada = -200;
            x = false;
        }
    }

    public void BorrarLlamada()
    {
        if (btnllamar.interactable == true)
        {
            txtLlamada.text = "Interceptar linea";
            btnREC.interactable = false;
            btnllamar.interactable = true;
            btnplay.interactable = false;
        }
        
    } 
    public void ReproducirLlamada ()
    {
        PapelFax.SetActive(true);
        txtTranscripci�nLlamado.text = "No se interseptaron llamadas relevantes";
        //Llamado ben
        switch (LlamadaEnProgreso)
        {
            case ("Ben Benji"):
                if (bitacora.BenEliminado == false && bitacora.BenLavado == false  )
                {
                    if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false && BenLlamado == false)
                    {
                        txtTranscripci�nLlamado.text = "No ben que hiciste";
                        libreta.BtnPepeQue�o.SetActive(true);
                        BenLlamado = true;
                    }
                }
                else txtTranscripci�nLlamado.text = "Ben Benji ya no pude realizar llamadas por culpa de tus acciones";
                break;

            //Llamado Pie Grande
            case ("Pie Grande"):
                if (bitacora.PieGrandeEliminado == false && PieGrandeLlamado == false)
                {
                    if (bitacora.KateEliminada == false && bitacora.KateLavada == false)
                    {
                        txtTranscripci�nLlamado.text = "unga unga aplastar porunga";
                        PieGrandeLlamado = true;
                    }
                }
                else txtTranscripci�nLlamado.text = "Pie Grande ya no pude realizar llamadas por culpa de tus acciones";
                break;
            // Llamar Kate Milliard
            case ("Kate Milliard"):
                if (bitacora.KateEliminada == false && bitacora.KateLavada == false)
                {
                    if  (bitacora.PieGrandeEliminado == false && KateLlamado == false){
                        txtTranscripci�nLlamado.text = "******************************************************************";
                        KateLlamado = true;
                    }
                }
                else txtTranscripci�nLlamado.text = "Kate ya no pude realizar llamadas por culpa de tus acciones";
             break;
            // Llamar Pepe Que�o
            case ("Pepe Que�o"):
                if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false)
                {
                    //Llamada 1 de pepe
                    if (PepeLlamado1 == false)
                    {
                        txtTranscripci�nLlamado.text = "******************************************************************";
                        PepeLlamado1 = true;
                    }
                }
                else txtTranscripci�nLlamado.text = "Pepe Que�o ya no pude realizar llamadas por culpa de tus acciones";
                break;
            case null: 
                txtTranscripci�nLlamado.text = "No se intercept� ninguna llamada";
            break;

        }
        LLamadaDiaria = true;   
        x = false;
        BorrarLlamada();

    }

    void EsLlamable (string Palabra)
    {
        if (Palabra == "Ben Benji" || Palabra == "Pepe Que�o" || Palabra == "Pie Grande" || Palabra == "Kate Milliard")
        {
            btnllamar.interactable = false;
            InicioLlamada = TimeManager.Hora;
            x = true;
        }
        else
        {
            PapelFax.SetActive(true);
            txtTranscripci�nLlamado.text = "No hay posibilidad de interceptar";
           
        }
    }


}
