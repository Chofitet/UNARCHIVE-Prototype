using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Telefono : MonoBehaviour
{
    [SerializeField] Libreta libreta;
    [SerializeField] Bitacoras bitacora;
    [SerializeField] TimeManager time;
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


    bool x;
    bool x1;

    private void Update()
    {
        if(btnllamar.interactable == true) txtLlamada.text = libreta.palabra;
        if (LLamadaDiaria == false && x1 == true) { btnREC.interactable = true; btnllamar.interactable = true; x1 = false; }
    }

    public void REC()
    {
        if (x == false)
        {
            LlamadaEnProgreso = libreta.palabra;
            EsLlamable(LlamadaEnProgreso);
        }
        else if (x == true)
        {
            btnllamar.interactable = true;
            x = false;
        }
    }

    public void SetearLlamada ()
    {
        txtTranscripciónLlamado.text = "No se interseptaron llamadas relevantes";
        //Llamado ben
        switch (LlamadaEnProgreso)
        {
            case ("Ben Benji"):
                if (bitacora.BenEliminado == false && bitacora.BenLavado == false)
                {
                    if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false && BenLlamado == false)
                    {

                        txtTranscripciónLlamado.text = "No ben que hiciste";;
                        int retencionllamada = 3;
                        StartCoroutine(PinchandoLlamada(retencionllamada, BenLlamado));

                    }
                    else {PapelFax.SetActive(true);}
                }
                else { PapelFax.SetActive(true); txtTranscripciónLlamado.text = "Ben Benji ya no pude realizar llamadas por culpa de tus acciones"; }

                break;

            //Llamado Pie Grande
            case ("Pie Grande"):
                if (bitacora.PieGrandeEliminado == false )
                {
                    if (bitacora.KateEliminada == false && bitacora.KateLavada == false && PieGrandeLlamado == false)
                    {
                        txtTranscripciónLlamado.text = "unga unga aplastar porunga";
                        int retencionllamada = 3;
                        StartCoroutine(PinchandoLlamada(retencionllamada, PieGrandeLlamado));
                    }
                    else { PapelFax.SetActive(true); }
                }
                else { PapelFax.SetActive(true); txtTranscripciónLlamado.text = "Pie Grande ya no pude realizar llamadas por culpa de tus acciones"; }
                break;
            // Llamar Kate Milliard
            case ("Kate Milliard"):
                if (bitacora.KateEliminada == false && bitacora.KateLavada == false)
                {
                    if (bitacora.PieGrandeEliminado == false && KateLlamado == false)
                    {
                        txtTranscripciónLlamado.text = "******************************************************************";
                        int retencionllamada = 3;
                        StartCoroutine(PinchandoLlamada(retencionllamada, KateLlamado));
                    }
                    else { PapelFax.SetActive(true); }
                }
                else { PapelFax.SetActive(true); txtTranscripciónLlamado.text = "Kate ya no pude realizar llamadas por culpa de tus acciones"; }
             break;
            // Llamar Pepe Queño
            case ("Pepe Queño"):
                if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false)
                {
                    //Llamada 1 de pepe
                    if (PepeLlamado1 == false)
                    {
                        txtTranscripciónLlamado.text = "******************************************************************";
                        int retencionllamada = 3;
                        StartCoroutine(PinchandoLlamada(retencionllamada, PepeLlamado1));
                    }
                }
                else { PapelFax.SetActive(true); txtTranscripciónLlamado.text = "Pepe Queño ya no pude realizar llamadas por culpa de tus acciones"; }
                break;
            case null: 
                txtTranscripciónLlamado.text = "No se interceptó ninguna llamada";
            break;

        }
        x = false;
      

    }

    void EsLlamable (string Palabra)
    {
        if (Palabra == libreta.palabrasCaso[0] || Palabra == libreta.palabrasCaso[1] || Palabra == libreta.palabrasCaso[2] || Palabra == libreta.palabrasCaso[8])
        {
            btnllamar.interactable = false;
            PapelFax.SetActive(false);
            SetearLlamada();
            x = true;
        }
        else
        {
            PapelFax.SetActive(true);
            txtTranscripciónLlamado.text = "No hay posibilidad de interceptar";
           
        }
    }

    IEnumerator PinchandoLlamada (int retencionllamada, bool L)
    {
        yield return new WaitForSeconds(retencionllamada * time.MinutosXseg * 60);
        L = true;
        if (x == true) 
        {
            btnplay.interactable = true;
            btnREC.interactable = false;
            x = false;
        }
    }

    void ActualizarPalabras()
    {
        if (bitacora.PieGrandeHackeado == true) { libreta.BtnRed78.gameObject.SetActive(true); }
        if (bitacora.Red78Investigada == true) { libreta.BtnKateMilliard.gameObject.SetActive(true); }
        if (bitacora.PieGrandeInvestigado == true) { libreta.BtnPelosRojizos.gameObject.SetActive(true); }
    }

    public void Play()
    {
        PapelFax.SetActive(true);
        LLamadaDiaria = true;
        btnplay.interactable = false;
        x1 = true;
        ActualizarPalabras();
    }

}
