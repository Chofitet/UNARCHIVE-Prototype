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
    float Timer;
    public TMP_Text txtTranscripci�nLlamado;
    bool Cronometro = false;
    string LlamadaEnProgreso;

    bool x;

    private void Update()
    {
        if (Cronometro && btnllamar.interactable == false)
        {
            Timer = Timer - Time.deltaTime;
        }

        if (Timer < 0)
        {
            Cronometro = false;
            Timer = 0;
            btnplay.interactable = true;
        }

        if (txtLlamada.text == "Interceptar linea" || txtLlamada.text == "") { btnREC.interactable = false; btnllamar.interactable = true; }
        else btnREC.interactable = true;
    }

    public void Llamar()
    {
        txtLlamada.text = libreta.palabra;
        txtTranscripci�nLlamado.text = "";
    }

    public void REC()
    {
       
        if (x == false)
        { 
            btnllamar.interactable = false;
            x = true; 
        }
        else 
        {
            btnllamar.interactable = true;
            x = false;
        }
        CargarLlamada();
    }

    void CargarLlamada ()
    {
        LlamadaEnProgreso = libreta.palabra;
        Timer = 5;
        Cronometro = true;
    }

    public void BorrarLlamada()
    {
        txtLlamada.text = "Interceptar linea";
        btnplay.interactable = false;
        
    } 
    public void ReproducirLlamada ()
    {
        //Llamado ben
        if (LlamadaEnProgreso == "Ben Benji")
        {
            txtTranscripci�nLlamado.text = "***********************************************************************";
            libreta.BtnPepeQue�o.SetActive(true);
        }
        //Llamado Pie Grande
        else if (LlamadaEnProgreso == "Pie Grande")
        {
            txtTranscripci�nLlamado.text = "******************************************************************";
            
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

        BorrarLlamada();
    }
    


}
