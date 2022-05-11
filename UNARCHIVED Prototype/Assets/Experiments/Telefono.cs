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
   
    public TMP_Text txtTranscripciónLlamado;
   
    string LlamadaEnProgreso;
    float InicioLlamada;

    bool x;

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
        if (TimeManager.Hora == InicioLlamada + 1)
        {
            btnplay.interactable = true;
        }
    }
    private void Update()
    {

        if (txtLlamada.text == "Interceptar linea" || txtLlamada.text == "") { btnREC.interactable = false; btnllamar.interactable = true; InicioLlamada = -200;  }
        else btnREC.interactable = true;

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
        //Llamado ben
        if (LlamadaEnProgreso == "Ben Benji")
        {
            txtTranscripciónLlamado.text = "***********************************************************************";
            libreta.BtnPepeQueño.SetActive(true);
        }
        //Llamado Pie Grande
        else if (LlamadaEnProgreso == "Pie Grande")
        {
            txtTranscripciónLlamado.text = "******************************************************************";
            
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

        x = false;
        BorrarLlamada();
    }
    


}
