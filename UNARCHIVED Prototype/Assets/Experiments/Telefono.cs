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
        txtTranscripciónLlamado.text = "";
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
        txtTranscripciónLlamado.text = "";
        
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
            txtTranscripciónLlamado.text = "No ben que hiciste";
            libreta.BtnPepeQueño.SetActive(true);
        }
        //Llamado Pie Grande
        else if (LlamadaEnProgreso == "Pie Grande")
        {
            txtTranscripciónLlamado.text = "unga unga aplastar porunga";
            
        }
        // Llamar Kate Milliard
        else if (LlamadaEnProgreso == "Kate Milliard")
        {
            txtTranscripciónLlamado.text = "******************************************************************";

        }
        // Llamar Pepe Queño
        else if (LlamadaEnProgreso == "Pepe Queño")
        {
            txtTranscripciónLlamado.text = "******************************************************************";

        }
        else txtTranscripciónLlamado.text = "No se interceptó ninguna llamada";

        LLamadaDiaria = true;   
        x = false;
        BorrarLlamada();
    }
    


}
