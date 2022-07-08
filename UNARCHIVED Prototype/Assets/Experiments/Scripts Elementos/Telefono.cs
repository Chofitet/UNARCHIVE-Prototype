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
    public TMP_Text txtNumero;
    public GameObject PapelFax;
    public bool BenLlamado;
    private bool PieGrandeLlamado;
    private bool KateLlamado;
    private bool PepeLlamado1;
    private bool PepeLlamado2;
    private bool PepeLlamado3;
    private string PorCuestionesLegales = "Por cuestiones legales solo podemos pinchar la  misma linea una vez por día";
    bool YaPinchado;
    public GameObject BotonPlay;
    public GameObject BotonREC;
    bool LlamadaEnTranscurso;

    public bool LlamadaDiariaBen;
    public bool LlamadaDiariaPieGrande;
    public bool LlamadaDiariaKate;
    public bool LlamadaDiariaPepe;


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
        if (Input.GetKeyDown(KeyCode.Mouse1) == true && PasoDeDia.PantallaDia == false)
        {
            BotonPlay.SetActive(true);
           // PapelFax.SetActive(false);
        }
        if (LlamadaEnTranscurso == true) { BotonREC.SetActive(false); }
        else BotonREC.SetActive(true);
        if (btnllamar.interactable == true) txtLlamada.text = libreta.palabra; MostrarNumero();
        if(LLamadaDiaria == false && x1 == true) { btnREC.interactable = true; btnllamar.interactable = true; x1 = false; }
    }

    public void REC()
    {
        if (x == false)
        {
            
            LlamadaEnProgreso = libreta.palabra;
            EsLlamable(LlamadaEnProgreso);
            if (LlamadaEnProgreso == "") PapelFax.SetActive(false);
        }
        else if (x == true)
        {
            btnllamar.interactable = true;
            x = false;
            Alarma.Apagado();
            Debug.Log("no llamado");
        }
    }

    public void SetearLlamada ()
    {
        //Llamado ben
        switch (LlamadaEnProgreso)
        {
            case ("Ben Benji"):
               
                    if (bitacora.BenEliminado == false && bitacora.BenLavado == false && bitacora.BenRetirado == false)
                    {
                        if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false && BenLlamado == false)
                        {

                            txtTranscripciónLlamado.text = "****¿Por qué te voy a mentir? Te lo juro, Pepe Quenio! Era igual a vos! Mirá las fotos que te mandé.****";
                            BenLlamado = true;

                        }
                    }
                    else if (bitacora.BenLavado == true && bitacora.BenRetirado == false)
                    {
                        txtTranscripciónLlamado.text = "****No tengo idea de que me hablas, Pepe Quenio. No ví nada en Parque Pimienta! Me haces doler la cabeza, no me llames denuevo...****";
                    }
                    else if (bitacora.PepeEliminado == true)
                    { txtTranscripciónLlamado.text = "Ben Benji no puede realizar llamadas desde... La Granja"; }

                    LlamadaDiariaBen = true;
                break;

            //Llamado Pie Grande
            case ("Pie Grande"):
                if (bitacora.PieGrandeEliminado == false )
                {
                    if (bitacora.KateEliminada == false && bitacora.KateLavada == false && PieGrandeLlamado == false)
                    {
                        txtTranscripciónLlamado.text = "unga unga aplastar porunga";
                        PieGrandeLlamado = true;
                    }
                }
                else { PapelFax.SetActive(true); txtTranscripciónLlamado.text = "Pie Grande no puede realizar llamadas desde... La Granja"; }
                LlamadaDiariaPieGrande = true;
                break;
                
            // Llamar Kate Milliard
            case ("Kate Milliard"):
                if (bitacora.KateEliminada == false && bitacora.KateLavada == false)
                {
                    if (bitacora.PieGrandeEliminado == false && KateLlamado == false)
                    {
                        txtTranscripciónLlamado.text = "No podemos imprimir esto en un juego para menores de 18. Es una fuerte llamada de cachondeo.";
                    }
                }
                else if (bitacora.KateLavada == true) { txtTranscripciónLlamado.text = "Wip llamada kate lavada de cerebro"; }

                else if (bitacora.KateEliminada == true){ txtTranscripciónLlamado.text = "Kate no puede realizar llamadas desde... La Granja"; }
                LlamadaDiariaKate = true;
             break;
            // Llamar Pepe Queño
            case ("Pepe Quenio"):
                if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false)
                {
                    //Llamada 1 de pepe
                    if (PepeLlamado1 == false)
                    {
                        txtTranscripciónLlamado.text = "********";
                    }
                }
                else if (bitacora.PepeLavado == true) { txtTranscripciónLlamado.text = "Wip Pepe lavado"; }
                else {txtTranscripciónLlamado.text = "Pepe Quenio no puede realizar llamadas desde... La Granja"; }
                LlamadaDiariaPepe = true;
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
            LlamadaDiaria();
            if (YaPinchado == false)
            {
                LlamadaEnTranscurso = true;
                btnllamar.interactable = false;
                StartCoroutine(PinchandoLlamada(3));
                PapelFax.SetActive(false);
                x = true;
                Alarma.Encendido();
            }
            YaPinchado = false;
        }
        else
        {
            PapelFax.SetActive(true);
            txtTranscripciónLlamado.text = "WIP No es posible pinchar a " + LlamadaEnProgreso;//este es cuando llamas a un objeto  o lugar o coso
        }
    }

    IEnumerator PinchandoLlamada (float retencionllamada)
    {
        yield return StartCoroutine(time.RetencionBitacorasSegunAccion(retencionllamada));
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
        BotonPlay.SetActive(false);
        LlamadaEnTranscurso = false;
        SetearLlamada();
        Alarma.Apagado();
        PapelFax.SetActive(true);
        btnplay.interactable = false;
        x1 = true;
        ActualizarPalabras();
       
    }

    void MostrarNumero ()
    {
        txtNumero.text = "";
        if (libreta.palabra == libreta.palabrasCaso[0]) { txtNumero.text = "4223-4485"; }
        if (libreta.palabra == libreta.palabrasCaso[1] && bitacora.PieGrandeUbicacion == true) { txtNumero.text = "4223-4485"; }
        if (libreta.palabra == libreta.palabrasCaso[2]) { txtNumero.text = "4223-4485"; }
        if (libreta.palabra == libreta.palabrasCaso[8] ) { txtNumero.text = "4223-4485"; }
    }

    void LlamadaDiaria ()
    {
        switch (LlamadaEnProgreso)
        {
            case ("Ben Benji"):
                if (LlamadaDiariaBen == true)
                {
                    PapelFax.SetActive(true);
                    txtTranscripciónLlamado.text = PorCuestionesLegales;
                    YaPinchado = true;
                }
                break;
            case ("Pie Grande"):
                if (LlamadaDiariaPieGrande == true)
                {
                    PapelFax.SetActive(true);
                    txtTranscripciónLlamado.text = PorCuestionesLegales;
                    YaPinchado = true;
                }
                break;
            case ("Kate Milliard"):
                if (LlamadaDiariaKate == true)
                {
                    PapelFax.SetActive(true);
                    txtTranscripciónLlamado.text = PorCuestionesLegales;
                    YaPinchado = true;
                }
                break;
            case ("Pepe Quenio"):
                if (LlamadaDiariaPepe == true)
                {
                    PapelFax.SetActive(true);
                    txtTranscripciónLlamado.text = PorCuestionesLegales;
                    YaPinchado = true;
                }
                break;
        }
            
    }

    public void ApagarPapel ()
    {
        //BotonPlay.SetActive(true);
        //PapelFax.SetActive(false);
    }

}
