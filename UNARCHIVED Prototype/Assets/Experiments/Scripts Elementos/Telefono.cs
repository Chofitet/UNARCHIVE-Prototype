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
    [SerializeField] AlarmaTelefono Alarma;
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

    private void Start()
    {
        PapelFax.gameObject.SetActive(false);
    }

    public TMP_Text txtTranscripciónLlamado;
   
    public  bool LLamadaDiaria;
    string LlamadaEnProgreso;


    bool x;
    bool x1;

    private void Update()
    {
        if(btnllamar.interactable == true) txtLlamada.text = libreta.palabra;
        if(LLamadaDiaria == false && x1 == true) { btnREC.interactable = true; btnllamar.interactable = true; x1 = false; }
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
        txtTranscripciónLlamado.text = "WIP. Solo una por dia";// si ya esta hecho el llamado, hay que cambiar
        //Llamado ben
        switch (LlamadaEnProgreso)
        {
            case ("Ben Benji"):
                if (bitacora.BenEliminado == false && bitacora.BenLavado == false && bitacora.BenRetirado == false)
                {
                    if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false && BenLlamado == false)
                    {

                        txtTranscripciónLlamado.text = "****¿Por qué te voy a mentir? Te lo juro, Pepe Quenio! Era igual a vos!****";
                        float retencionllamada = 3;
                        StartCoroutine(PinchandoLlamada(retencionllamada, BenLlamado));
                     
                    }
                    else {PapelFax.SetActive(true);}
                }
                else if(bitacora.BenLavado == true && bitacora.BenRetirado == false)
                {
                    txtTranscripciónLlamado.text = "****No tengo idea de que me hablas, Pepe Quenio. No ví nada en el Parque!****";
                    float retencionllamada = 3;
                    StartCoroutine(PinchandoLlamada(retencionllamada, BenLlamado));
                } 
                
                else
                { PapelFax.SetActive(true); txtTranscripciónLlamado.text = "Ben Benji no puede realizar llamadas desde... La Granja"; }

                break;

            //Llamado Pie Grande
            case ("Pie Grande"):
                if (bitacora.PieGrandeEliminado == false )
                {
                    if (bitacora.KateEliminada == false && bitacora.KateLavada == false && PieGrandeLlamado == false)
                    {
                        txtTranscripciónLlamado.text = "unga unga aplastar porunga";
                        float retencionllamada = 3;
                        StartCoroutine(PinchandoLlamada(retencionllamada, PieGrandeLlamado));
                    }
                    else { PapelFax.SetActive(true); }
                }
                else { PapelFax.SetActive(true); txtTranscripciónLlamado.text = "Pie Grande no puede realizar llamadas desde... La Granja"; }
                break;
            // Llamar Kate Milliard
            case ("Kate Milliard"):
                if (bitacora.KateEliminada == false && bitacora.KateLavada == false)
                {
                    if (bitacora.PieGrandeEliminado == false && KateLlamado == false)
                    {
                        txtTranscripciónLlamado.text = "No podemos imprimir esto en un juego para menores de 18. Es una fuerte llamada de cachondeo.";
                        float retencionllamada = 3;
                        StartCoroutine(PinchandoLlamada(retencionllamada, KateLlamado));
                    }
                    else { PapelFax.SetActive(true); }
                }
                else { PapelFax.SetActive(true); txtTranscripciónLlamado.text = "Kate no puede realizar llamadas desde... La Granja"; }
             break;
            // Llamar Pepe Queño
            case ("Pepe Quenio"):
                if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false)
                {
                    //Llamada 1 de pepe
                    if (PepeLlamado1 == false)
                    {
                        txtTranscripciónLlamado.text = "********";
                        float retencionllamada = 3;
                        StartCoroutine(PinchandoLlamada(retencionllamada, PepeLlamado1));
                    }
                }
                else { PapelFax.SetActive(true); txtTranscripciónLlamado.text = "Pepe Quenio no puede realizar llamadas desde... La Granja"; }
                break;
            case null: 
                txtTranscripciónLlamado.text = "No se ha interceptado ninguna llamada";
            break;

        }
        x = false;
      

    }

    void EsLlamable (string Palabra)
    {
        if (Palabra == libreta.palabrasCaso[0] || (Palabra == libreta.palabrasCaso[1] && bitacora.PieGrandeUbicacion) || Palabra == libreta.palabrasCaso[2] || Palabra == libreta.palabrasCaso[8])
        {
            btnllamar.interactable = false;
            PapelFax.SetActive(false);
            SetearLlamada();
            x = true;
            Alarma.Encendido();
        }
        else
        {
            PapelFax.SetActive(true);
            txtTranscripciónLlamado.text = "No es posible interceptar sin contar con el número del teléfono";//este es cuando llamas a un objeto  o lugar o coso
           
        }
    }

    IEnumerator PinchandoLlamada (float retencionllamada, bool L)
    {
        yield return StartCoroutine(time.RetencionBitacorasSegunAccion(retencionllamada));
        L = true;
        Alarma.Titilando();
        if (x == true) 
        {
            btnplay.interactable = true;
            btnREC.interactable = false;
            x = false;
        }
    }

    void ActualizarPalabras()
    {
        libreta.BtnPepeQueño.gameObject.SetActive(true);
    }

    public void Play()
    {
        Alarma.Apagado();
        PapelFax.SetActive(true);
        LLamadaDiaria = true;
        btnplay.interactable = false;
        x1 = true;
        ActualizarPalabras();
    }

}
