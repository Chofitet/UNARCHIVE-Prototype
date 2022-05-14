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
            if (txtLlamada.text == "Interceptar linea" || txtLlamada.text == "") { btnREC.interactable = false; btnllamar.interactable = true; InicioLlamada = -200; }
            else btnREC.interactable = true;
        }
        if (LLamadaDiaria == true)
        {
            btnREC.interactable = false;
            btnplay.interactable = false;
            btnllamar.interactable = false;
        }

    }

    public void Llamar()
    {
        txtLlamada.text = libreta.palabra;
        txtTranscripci�nLlamado.text = "";
        LlamadaEnProgreso = libreta.palabra;
    }

    public void REC()
    {
       
        if (x == false)
        { 
            btnllamar.interactable = false;
            InicioLlamada = TimeManager.Hora;
            x = true; 
        }
        else 
        {
            btnllamar.interactable = true;
            InicioLlamada = -200;
            x = false;
        }
        txtTranscripci�nLlamado.text = "";
        
    }

    public void BorrarLlamada()
    {
        if (btnllamar.interactable == false)
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
        //Llamado ben
        if (LlamadaEnProgreso == "Ben Benji")
        {
            txtTranscripci�nLlamado.text = "No ben que hiciste";
            libreta.BtnPepeQue�o.SetActive(true);
        }
        //Llamado Pie Grande
        else if (LlamadaEnProgreso == "Pie Grande")
        {
            txtTranscripci�nLlamado.text = "unga unga aplastar porunga";
            
        }
        // Llamar Kate Milliard
        else if (LlamadaEnProgreso == "Kate Milliard")
        {
            txtTranscripci�nLlamado.text = "******************************************************************";

        }
        // Llamar Pepe Que�o
        else if (LlamadaEnProgreso == "Pepe Que�o")
        {
            txtTranscripci�nLlamado.text = "******************************************************************";

        }
        else txtTranscripci�nLlamado.text = "No se intercept� ninguna llamada";

        LLamadaDiaria = true;   
        x = false;
        BorrarLlamada();
    }
    


}
