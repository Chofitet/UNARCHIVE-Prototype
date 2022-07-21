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
    [SerializeField] SonidosManagement Sonidos;
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
    private string PorCuestionesLegales = "Por cuestiones legales solo podemos pinchar la  misma linea una vez por d�a";
    bool YaPinchado;
    public GameObject BotonPlay;
    public GameObject BotonREC;
    bool LlamadaEnTranscurso;
    bool BenLlamadoPlantarPublico;

    public bool LlamadaDiariaBen;
    public bool LlamadaDiariaPieGrande;
    public bool LlamadaDiariaKate;
    public bool LlamadaDiariaPepe;


    private void Start()
    {
        PapelFax.gameObject.SetActive(false);
        Sonidos = FindObjectOfType<SonidosManagement>();
    }

    public TMP_Text txtTranscripci�nLlamado;

    public bool LLamadaDiaria;
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
        if (LLamadaDiaria == false && x1 == true) { btnREC.interactable = true; btnllamar.interactable = true; x1 = false; }
    }

    public void REC()
    {
        if (x == false)
        {
            LlamadaEnProgreso = libreta.palabra;
            EsLlamable(LlamadaEnProgreso);
            if (LlamadaEnProgreso == "") PapelFax.SetActive(false);
            if (libreta.palabra != "") { Sonidos.SonidodeBoton(); }
        }
        else if (x == true)
        {
            btnllamar.interactable = true;
            LlamadaEnTranscurso = false;
            x = false;
            Alarma.Apagado();
            if (libreta.palabra != "") { Sonidos.SonidodeBoton(); }
        }

    }

    public void SetearLlamada()
    {
        //Llamado ben
        switch (LlamadaEnProgreso)
        {
            case ("Ben Benji"):

                if (bitacora.BenEliminado == false && bitacora.BenLavado == false && bitacora.BenRetirado == false)
                {
                    if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false && BenLlamado == false)
                    {

                        txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE BENJI Y �AMIGO?"
                        + System.Environment.NewLine
                        + System.Environment.NewLine + "****�Por qu� te voy a mentir? Te lo juro, Pepe Quenio! Era igual a vos! Mir� las fotos que te mand�.****";
                        BenLlamado = true;
                        libreta.EscribirNuevaPalabra(libreta.BtnPepeQue�o, 8);

                    }
                    if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false && bitacora.PlantarPublico == true && BenLlamadoPlantarPublico == false)
                    {

                        txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE BENJI Y �AMIGO?"
                        + System.Environment.NewLine
                        + System.Environment.NewLine + "****No quiero hablar m�s de esto, nadie me cree ahora, Pepe Quenio...****";
                        libreta.EscribirNuevaPalabra(libreta.BtnPepeQue�o, 8);
                        BenLlamadoPlantarPublico = true;

                    }
                }
                else if (bitacora.BenLavado == true && bitacora.BenRetirado == false)
                {
                    txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE BENJI Y �AMIGO?"
                    + System.Environment.NewLine
                    + System.Environment.NewLine + "****No tengo idea de que me hablas, Pepe Quenio. No v� nada en Parque Pimienta! Me haces doler la cabeza, no me llames denuevo...****";
                    libreta.EscribirNuevaPalabra(libreta.BtnPepeQue�o, 8);
                }
                else if (bitacora.BenEliminado == true)
                { txtTranscripci�nLlamado.text = "Ben Benji no puede realizar llamadas desde... La Granja"; }

                LlamadaDiariaBen = true;
                break;

            //Llamado Pie Grande
            case ("Pie Grande"):
                if (bitacora.PieGrandeEliminado == false)
                {
                    if (bitacora.KateEliminada == false && bitacora.KateLavada == false && PieGrandeLlamado == false)
                    {
                        txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE PIE GRANDE Y �AMANTE?"
                           + System.Environment.NewLine
                           + System.Environment.NewLine + "unga unga aplastar porunga";
                        PieGrandeLlamado = true;
                    }
                }
                else { PapelFax.SetActive(true); txtTranscripci�nLlamado.text = "Pie Grande no puede realizar llamadas desde... La Granja"; }
                LlamadaDiariaPieGrande = true;
                break;

            // Llamar Kate Milliard
            case ("Kate Milliard"):
                if (bitacora.KateEliminada == false && bitacora.KateLavada == false)
                {
                    if (bitacora.PieGrandeEliminado == false && KateLlamado == false)
                    {
                        txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE KATE Y �AMANTE?"
                           + System.Environment.NewLine
                           + System.Environment.NewLine + "No podemos imprimir esto en un juego para menores de 18. Es una fuerte llamada de cachondeo.";
                    }
                }
                else if (bitacora.KateLavada == true) { txtTranscripci�nLlamado.text = "Esta parte del juego esta en desarrollo. Saludos del Dise�ador"; }//WIP

                else if (bitacora.KateEliminada == true) { txtTranscripci�nLlamado.text = "Kate no puede realizar llamadas desde... La Granja"; }
                LlamadaDiariaKate = true;
                break;
            // Llamar Pepe Que�o
            case ("Pepe Quenio"):
                if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false)
                {
                    //Llamada 1 de pepe
                    if (PepeLlamado1 == false)
                    {
                        txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE BENJI Y �AMIGO?"
                           + System.Environment.NewLine
                           + System.Environment.NewLine + "********";
                    }
                }
                else if (bitacora.PepeLavado == true) { txtTranscripci�nLlamado.text = "NO HA USADO EL TELEFONO"; }
                else { txtTranscripci�nLlamado.text = "Pepe Quenio no puede realizar llamadas desde... La Granja"; }
                LlamadaDiariaPepe = true;
                break;
            case null:
                txtTranscripci�nLlamado.text = "No se ha interceptado ninguna llamada";
                break;

        }
        x = false;


    }

    void EsLlamable(string Palabra)
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
            // if (libreta.palabra != "") { Sonidos.SonidodeImprimir(); }
            PapelFax.SetActive(true);
            txtTranscripci�nLlamado.text = "Esta parte del juego esta en desarrollo. Saludos del Dise�ador" + LlamadaEnProgreso;//WIP
        }
    }

    IEnumerator PinchandoLlamada(float retencionllamada)
    {
        yield return StartCoroutine(time.RetencionBitacorasSegunAccion(retencionllamada));
        if (x == true)
        {
            Alarma.Titilando();
            btnplay.interactable = true;
            btnREC.interactable = false;
            x = false;
            if (time.VariacionDeTiempo > 500) Sonidos.SonidoPING();
            time.TiempoNormal();
        }
    }

    void ActualizarPalabras()
    {

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
        Sonidos.SonidodeBoton();
        // Sonidos.SonidodeImprimir();
    }

    void MostrarNumero()
    {
        txtNumero.text = "";
        if (libreta.palabra == libreta.palabrasCaso[0]) { txtNumero.text = "4223-4485"; }
        if (libreta.palabra == libreta.palabrasCaso[1] && bitacora.PieGrandeUbicacion == true) { txtNumero.text = "4223-4485"; }
        if (libreta.palabra == libreta.palabrasCaso[2]) { txtNumero.text = "4223-4485"; }
        if (libreta.palabra == libreta.palabrasCaso[8]) { txtNumero.text = "4223-4485"; }
    }

    void LlamadaDiaria()
    {
        switch (LlamadaEnProgreso)
        {
            case ("Ben Benji"):
                if (LlamadaDiariaBen == true)
                {
                    PapelFax.SetActive(true);
                    txtTranscripci�nLlamado.text = PorCuestionesLegales;
                    YaPinchado = true;
                }
                break;
            case ("Pie Grande"):
                if (LlamadaDiariaPieGrande == true)
                {
                    PapelFax.SetActive(true);
                    txtTranscripci�nLlamado.text = PorCuestionesLegales;
                    YaPinchado = true;
                }
                break;
            case ("Kate Milliard"):
                if (LlamadaDiariaKate == true)
                {
                    PapelFax.SetActive(true);
                    txtTranscripci�nLlamado.text = PorCuestionesLegales;
                    YaPinchado = true;
                }
                break;
            case ("Pepe Quenio"):
                if (LlamadaDiariaPepe == true)
                {
                    PapelFax.SetActive(true);
                    txtTranscripci�nLlamado.text = PorCuestionesLegales;
                    YaPinchado = true;
                }
                break;
        }

    }

    public void ApagarPapel()
    {
        //BotonPlay.SetActive(true);
        //PapelFax.SetActive(false);
    }

}

