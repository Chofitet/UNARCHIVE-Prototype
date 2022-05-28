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

    public TMP_Text txtTranscripciónLlamado;
   
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
        if (txtTranscripciónLlamado.text == "")
        {
            PapelFax.SetActive(false);
        }

    }

    public void Llamar()
    {
        LlamadaEnProgreso = libreta.palabra;
        txtLlamada.text = LlamadaEnProgreso;
        txtTranscripciónLlamado.text = "";
        
    }

    public void REC()
    {
        if (x == false)
        {
            txtTranscripciónLlamado.text = "";
            EsLlamable(LlamadaEnProgreso);
        }
        else if (x == true)
        {
            txtTranscripciónLlamado.text = "";
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
        txtTranscripciónLlamado.text = "No se interseptaron llamadas relevantes";
        //Llamado ben
        switch (LlamadaEnProgreso)
        {
            case ("Ben Benji"):
                if (bitacora.BenEliminado == false && bitacora.BenLavado == false  )
                {
                    if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false && BenLlamado == false)
                    {
                        txtTranscripciónLlamado.text = "No ben que hiciste";
                        libreta.BtnPepeQueño.SetActive(true);
                        BenLlamado = true;
                    }
                }
                else txtTranscripciónLlamado.text = "Ben Benji ya no pude realizar llamadas por culpa de tus acciones";
                break;

            //Llamado Pie Grande
            case ("Pie Grande"):
                if (bitacora.PieGrandeEliminado == false && PieGrandeLlamado == false)
                {
                    if (bitacora.KateEliminada == false && bitacora.KateLavada == false)
                    {
                        txtTranscripciónLlamado.text = "unga unga aplastar porunga";
                        PieGrandeLlamado = true;
                    }
                }
                else txtTranscripciónLlamado.text = "Pie Grande ya no pude realizar llamadas por culpa de tus acciones";
                break;
            // Llamar Kate Milliard
            case ("Kate Milliard"):
                if (bitacora.KateEliminada == false && bitacora.KateLavada == false)
                {
                    if  (bitacora.PieGrandeEliminado == false && KateLlamado == false){
                        txtTranscripciónLlamado.text = "******************************************************************";
                        KateLlamado = true;
                    }
                }
                else txtTranscripciónLlamado.text = "Kate ya no pude realizar llamadas por culpa de tus acciones";
             break;
            // Llamar Pepe Queño
            case ("Pepe Queño"):
                if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false)
                {
                    //Llamada 1 de pepe
                    if (PepeLlamado1 == false)
                    {
                        txtTranscripciónLlamado.text = "******************************************************************";
                        PepeLlamado1 = true;
                    }
                }
                else txtTranscripciónLlamado.text = "Pepe Queño ya no pude realizar llamadas por culpa de tus acciones";
                break;
            case null: 
                txtTranscripciónLlamado.text = "No se interceptó ninguna llamada";
            break;

        }
        LLamadaDiaria = true;   
        x = false;
        BorrarLlamada();

    }

    void EsLlamable (string Palabra)
    {
        if (Palabra == "Ben Benji" || Palabra == "Pepe Queño" || Palabra == "Pie Grande" || Palabra == "Kate Milliard")
        {
            btnllamar.interactable = false;
            InicioLlamada = TimeManager.Hora;
            x = true;
        }
        else
        {
            PapelFax.SetActive(true);
            txtTranscripciónLlamado.text = "No hay posibilidad de interceptar";
           
        }
    }


}
