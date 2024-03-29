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
    [SerializeField] TV tv;
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
        txtTranscripci�nLlamado.text = "No se ha interceptado ninguna llamada relevante";
        //Llamado ben
        switch (LlamadaEnProgreso)
        {
            case ("Ben Benji"):

                if (bitacora.BenEliminado == false && bitacora.BenLavadoV2 == false && bitacora.BenRetirado == false)
                {
                    //Ben Benji Normal
                    if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false && BenLlamado == false)
                    {

                        txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE BENJI Y �AMIGO?"
                        + System.Environment.NewLine
                        + System.Environment.NewLine + "****�Por qu� te voy a mentir? Te lo juro, Pepe Quenio! Era igual a vos! Mir� las fotos que te mand�.****";
                        BenLlamado = true;
                        libreta.EscribirNuevaPalabra(libreta.BtnPepeQue�o, 8);

                    }
                    //Ben Benji post Plantar publico
                    if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false &&  tv.PlantarPublico == true && BenLlamadoPlantarPublico == false)
                    {

                        txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE BENJI Y �AMIGO?"
                        + System.Environment.NewLine
                        + System.Environment.NewLine + "****No quiero hablar m�s de esto, nadie me cree ahora, Pepe Quenio...****";
                        libreta.EscribirNuevaPalabra(libreta.BtnPepeQue�o, 8);
                        BenLlamadoPlantarPublico = true;

                    }
                }
                //Ben Benji Brainwash
                else if (bitacora.BenLavadoV2 == true && bitacora.BenRetirado == false && bitacora.BenEliminado == false)
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
                    if (bitacora.KateEliminada == false)
                    {
                        //Pie grande Normal (supuse que la llamada es con Kate, si no lo es, sacarlo del if kate eliminada)
                        if (PieGrandeLlamado == false && bitacora.KateLavada == false)
                        {
                            txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE PIE GRANDE Y �AMANTE?"// Wip
                               + System.Environment.NewLine
                               + System.Environment.NewLine + "**** unga unga aplastar porunga ****";// Wip
                            PieGrandeLlamado = true;
                        }
                        // PieGrande Kate brainwash
                        if (bitacora.KateLavadaV2 == true)
                        {
                            txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE PIE GRANDE Y �DESCONOCIDA?"
                               + System.Environment.NewLine
                               + System.Environment.NewLine + " **** UNG�EIT? UNGA, UNGA, G�EIT...****"
                               + System.Environment.NewLine + " **** No entiendo nada de lo que dice! QUIEN ES? Por favor no llame devuelta a este n�mero****";
                            PieGrandeLlamado = true;
                        }
                    }
                }
                else { PapelFax.SetActive(true); txtTranscripci�nLlamado.text = "Pie Grande no puede realizar llamadas desde... La Granja"; }
                LlamadaDiariaPieGrande = true;
                break;

            // Llamar Kate Milliard
            case ("Kate Milliard"):
                if (bitacora.KateEliminada == false && bitacora.KateLavadaV2 == false)
                {
                    //Kate normal 
                    if (bitacora.PieGrandeEliminadoV2 == false && KateLlamado == false)
                    {
                        txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE KATE Y �AMANTE?"// Wip
                           + System.Environment.NewLine
                           + System.Environment.NewLine + "No podemos imprimir esto en un juego para menores de 18 a�os. Es una llamada demasiado cachonda. Se escuchaban gru�idos desde ambos participantes.";// Wip
                        KateLlamado = true;
                    }
                    //Kate Pie grande eliminado
                    if (bitacora.PieGrandeEliminadoV2 == true)
                    {
                        txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE KATE Y �PUBLICISTA?" //WIP
                           + System.Environment.NewLine
                           + System.Environment.NewLine + "**** No me importa lo que piense la gente. Voy a contar toda mi versi�n de la historia! **** ";// Wip
                    }
                }
                //Kate Brainwash
                else if (bitacora.KateLavadaV2 == true) { txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE KATE Y �DESCONOCIDO?" //WIP
                           + System.Environment.NewLine + " **** UNG�EIT? UNGA, UNGA, G�EIT...****"
                           + System.Environment.NewLine + " **** No entiendo nada de lo que dice! QUIEN ES? Por favor no llame devuelta a este n�mero****"; }//WIP

                else if (bitacora.KateEliminada == true) { txtTranscripci�nLlamado.text = "Kate no puede realizar llamadas desde... La Granja"; }
                LlamadaDiariaKate = true;
                break;

            // Llamar Pepe Que�o
            case ("Pepe Quenio"):
                
                if (bitacora.PepeEliminado == false && bitacora.PepeLavado == false)
                {
                    //PEPE normal
                    if (PepeLlamado1 == false)
                    {
                        txtTranscripci�nLlamado.text = "EXTRACTO DE LLAMADO ENTRE BENJI Y �GUARDABOSQUES?"
                           + System.Environment.NewLine
                           + System.Environment.NewLine + "**** Pero mi amigo dice que los vi�! Ustedes no vieron nada de nada?? ****"
                           + System.Environment.NewLine + "**** Nene, dej� de romper, ya te dijimos que no llames m�s. ****";
                        PepeLlamado1 = true;
                    }
                }
                //Pepe BrainWash
                else if (bitacora.PepeLavadoV2 == true) { txtTranscripci�nLlamado.text = "NO HA USADO EL TELEFONO"; }

                else if (bitacora.PepeEliminado == true){ txtTranscripci�nLlamado.text = "Pepe Quenio no puede realizar llamadas desde... La Granja"; }
                LlamadaDiariaPepe = true;
                break;
            case null:
                txtTranscripci�nLlamado.text = "No se ha interceptado ninguna llamada relevante";
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
            txtTranscripci�nLlamado.text = "No es posible llamar a " + LlamadaEnProgreso;//WIP
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

