using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Bitacoras : MonoBehaviour
{
    //Referencias Scripts
    [SerializeField] internal Libreta libreta;
    [SerializeField] internal Acciones A;
    [SerializeField] internal TimeManager time;
    [SerializeField] Reloj reloj;
    [SerializeField] PC PC;

    //Declaración varariables
  
    public bool BenEliminado;
    public bool BenLavado;
    public bool BenInvestigado;
    public bool BenHackeado;
    public bool BenDifamado;
    public bool PieGrandeEliminado;
    public bool PieGrandeLavado;
    public bool PieGrandeInvestigado;
    public bool PieGrandeHackeado;
    public bool PieGrandeDifamado;
    public bool ParquePimientaAislado;
    public bool ParquePimientaEscena;
    public bool PimientaPaluzaEscena;
    public bool ColoradaInvestigada;
    public bool Red78Investigada;
    public bool KateEliminada;
    public bool KateLavada;
    public bool KateInvestigada;
    public bool KateHackeada;
    public bool KateDifamada;
    public bool PepeEliminado;
    public bool PepeLavado;
    public bool PepeInvestigado;
    public bool PepeHackeado;
    public bool PepeDifamado;
    public bool PepeAnalizado;
    public bool CabellosRojijosAnalizado;

    private string txtNoticiaFalsa;
    private int NumNoticias = 5;

    //Vectores bitacoras
    string[] pag1 = new string[12];
    
    string[] pag2 = new string[12];
  
    string[] pag3 = new string[12];
   
    int Pag = 1;
    int PagActual;
    int ind;
    int aux;

    //Textos bitacoras
    public TMP_Text B1P1;
    public TMP_Text B2P1;
    public TMP_Text B3P1;
    public TMP_Text B4P1;
    public TMP_Text B5P1;
    public TMP_Text B6P1;

    public TMP_Text B1P2;
    public TMP_Text B2P2;
    public TMP_Text B3P2;
    public TMP_Text B4P2;
    public TMP_Text B5P2;
    public TMP_Text B6P2;

    private void Start()
    {
       
        PagActual = Pag;
    }

    private void Update()
    {
        if (time.NoticiaDiaria == true)
        {
            A.crearNoticia.interactable = false;
        }
        else A.crearNoticia.interactable = true;

        ActualizarPaginas();
    }

    // Analiza las variables: ¿que nombre de la libreta està seleccionada?, ¿què acciòn està elegida? y si otra o esa misma accion fue ejecutada para evitar incongruencias o bitacoras repetidas.
    // Si se cumplen las condiciones, imprimen la bitàcora correspondiente 
    public void ActualizarBitacoras()
    {
        //===================================================== Bitacoras Ben==============================================//
        //Eliminar
        if (libreta.palabra == "Ben Benji")
        {
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && BenEliminado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar a Ben";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                A.eliminar.interactable = false; 
                BenEliminado = true;
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && BenLavado == false && BenEliminado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Borramos con exito la memoria de Ben";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a Ben";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado > 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                A.lavarCerebro.interactable = false;
                BenLavado = true;
            }
            // investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && BenInvestigado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue investigado";
                Toggle accion = A.investigar;
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar a Ben";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                BenInvestigado = true;
                A.investigar.interactable = false;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && BenHackeado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear a Ben";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                BenHackeado = true;
                A.hackear.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && BenHackeado == true && BenDifamado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                Toggle accion = A.difamar;
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar a Ben";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                BenDifamado = true;
                A.difamar.interactable = false;
            }
        }


        //====================================================== Bitacoras Pie Grande =============================================//
        if (libreta.palabra == "Pie Grande")
        {
            //ELIMINAR 
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PieGrandeEliminado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar a Pie Grande";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PieGrandeEliminado = true;
                A.eliminar.interactable = false;
            }

            //Lavar Cerebro 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PieGrandeLavado == false && PieGrandeEliminado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro Pie Grande";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PieGrandeLavado = true;
                A.lavarCerebro.interactable = false;
            }
            //Investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && PieGrandeInvestigado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar Pie Grande";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PieGrandeInvestigado = true;
                A.investigar.interactable = false;
            }
            //Hackeado
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && PieGrandeHackeado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Pie Grande";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a;
                ActualizarIndice();
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PieGrandeHackeado = true;
                A.hackear.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PieGrandeDifamado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Pie Grande";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PieGrandeDifamado = true;
                A.difamar.interactable = false;
            }
        }
        //=========================================================== Bitacoras Pueblo Pimienta =================================================//
        if (libreta.palabra == "Pueblo Pimienta")
        {
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && ParquePimientaAislado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Aislar Pueblo Pimienta";
                Toggle accion = A.aislar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                ParquePimientaAislado = true;
                A.aislar.interactable = false;
            }
            //Montar Escena
            if (A.crearEscena.CompareTag(tag = "OptActivado") && A.crearEscena.isOn == true && ParquePimientaEscena == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Montar escena Pueblo Pimienta";
                Toggle accion = A.crearEscena;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                ParquePimientaEscena = true;
                A.crearEscena.interactable = false;
            }
        }
        //========================================================== Bitacoras Pimienta Paluza ==================================================//
        if (libreta.palabra == "Pimienta Paluza")
        {
            //Montar escena
            if (A.crearEscena.CompareTag(tag = "OptActivado") && A.crearEscena.isOn == true && PimientaPaluzaEscena == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Montar escena Pimienta Paluza";
                Toggle accion = A.crearEscena;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PimientaPaluzaEscena = true;
                A.crearEscena.interactable = false;
            }
        }
        //========================================================= Bitacoras Colorada ==========================================================//
        if (libreta.palabra == "Colorada")
        {
            //Investigar 
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && ColoradaInvestigada == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar colorada";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                ColoradaInvestigada = true;
                A.investigar.interactable = false;
            }
        }
        //======================================================= Bitacoras Red78 ==============================================================//
        if (libreta.palabra == "Red78")
        {
            //Investigar 
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && Red78Investigada == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar Red78";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                Red78Investigada = true;
                A.investigar.interactable = false;
            }
        }
        //===================================================== Bitacoras Kate Milliard ======================================================//
        if (libreta.palabra == "Kate Milliard")
        {
            //ELIMINAR
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && KateEliminada == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar Kate Milliard";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                KateEliminada = true;
                A.eliminar.interactable = false;
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && KateEliminada == false && KateLavada == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a Kate Milliard";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                KateLavada = true;
                A.lavarCerebro.interactable = false;
            }
            // investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && KateInvestigada == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar Kate Milliard";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                KateInvestigada = true;
                A.investigar.interactable = false;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && KateHackeada == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Kate Milliard";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                KateHackeada = true;
                A.hackear.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && KateDifamada == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Kate Milliard";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                KateDifamada = true;
                A.difamar.interactable = false;
            }
        }
        //================================================== Bitacoras Pepe Queño =========================================//
        if (libreta.palabra == "Pepe Queño")
        {
            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PepeEliminado == false )
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar Pepe Queño";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PepeEliminado = true;
                A.eliminar.interactable = false;
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PepeEliminado == false && PepeLavado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro Pepe Queño";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PepeLavado = true;
                A.lavarCerebro.interactable = false;
            }
            // investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && PepeInvestigado == false)
                {   
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar Pepe Queño";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PepeInvestigado = true;
                A.investigar.interactable = false;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && PepeHackeado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Pepe Queño";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PepeHackeado = true;
                A.hackear.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PepeDifamado== false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Pepe Queño";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PepeDifamado = true;
                A.difamar.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && PepeAnalizado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Analizar Pepe Queño";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                PepeAnalizado = true;
                A.analizarMuestra.interactable = false;
            }
        }
        //================================================= Bitacoras Cabellos Rojizos ==========================================================//
        if (libreta.palabra == "Cabellos rojizos" )
        {
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && CabellosRojijosAnalizado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Analizar cabellos rojizos";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, indaux, accion, a));
                CabellosRojijosAnalizado = true;
                A.analizarMuestra.interactable = false;
            }

        }
        //================================================ Bitacoras Fake News ===================================================================//
       
          
            if (A.crearNoticia.CompareTag(tag = "OptActivado") && A.crearNoticia.isOn == true)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                ElegirFakeNews(NumNoticias);
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Crear noticia falsa";
                Toggle accion = A.crearNoticia;
                 time.NoticiaDiaria = true;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                    
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txtNoticiaFalsa, indaux, accion, a));
               
                A.crearNoticia.interactable = false;
            }

      
        A.Restablecer();
    }

    IEnumerator GuardarBitacora(float ReinicioTiempo, string txt, int indaux, Toggle accion, int a)
    {
        yield return new WaitForSeconds(ReinicioTiempo);
        CargarVectorAccion(a, indaux, txt);
        accion.interactable = true;
        ActualizarPalabras();
    }

    void ActualizarPalabras()
    {
        if (PieGrandeHackeado == true) { libreta.BtnRed78.gameObject.SetActive(true); }
        if (Red78Investigada == true) { libreta.BtnKateMilliard.gameObject.SetActive(true); }
        if (PieGrandeInvestigado == true) { libreta.BtnPelosRojizos.gameObject.SetActive(true); }

    }

    //Crea los espacios para rellenar las bitàcoras y los borra cuando es debido
   
    public void SiguientePagina()
    {
        if (PagActual < 3)  {PagActual++;}
    }
    public void AnteriorPagina ()
    {
        if (PagActual > 0) { PagActual--; } 
    }
    void ActualizarPaginas()
    {
        if (PagActual == 1)
        {
            B1P1.text = pag1[0];
            B2P1.text = pag1[1];
            B3P1.text = pag1[2];
            B4P1.text = pag1[3];
            B5P1.text = pag1[4];
            B6P1.text = pag1[5];
            B1P2.text = pag1[6];
            B2P2.text = pag1[7];
            B3P2.text = pag1[8];
            B4P2.text = pag1[9];
            B5P2.text = pag1[10];
            B6P2.text = pag1[11];

        }
        else if (PagActual == 2)
        {
            B1P1.text = pag2[0];
            B2P1.text = pag2[1];
            B3P1.text = pag2[2];
            B4P1.text = pag2[3];
            B5P1.text = pag2[4];
            B6P1.text = pag2[5];
            B1P2.text = pag2[6];
            B2P2.text = pag2[7];
            B3P2.text = pag2[8];
            B4P2.text = pag2[9];
            B5P2.text = pag2[10];
            B6P2.text = pag2[11];
        }
        else if (PagActual == 3)
        {
            B1P1.text = pag3[0];
            B2P1.text = pag3[1];
            B3P1.text = pag3[2];
            B4P1.text = pag3[3];
            B5P1.text = pag3[4];
            B6P1.text = pag3[5];
            B1P2.text = pag3[6];
            B2P2.text = pag3[7];
            B3P2.text = pag3[8];
            B4P2.text = pag3[9];
            B5P2.text = pag3[10];
            B6P2.text = pag3[11];
        }
    }

    void CargarVectorProgreso(string Accion, string FechaCompletado, float HoraCompletado, int ind)
    { 
        if (Pag == 1)
        {
            pag1[ind] = "En proceso: " + Accion + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 2)
        {
            pag2[ind] = "En proceso: " + Accion + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 3)
        {
            pag3[ind] = "En proceso: " + Accion + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
    }
    void ActualizarIndice ()
    {
        if (ind > 10)
        {
            ind = 0;
            Pag = Pag + 1;
        }
        else ind++;
    }

    void SetearBitacora ()
    {
        if (Pag == 1) aux = 1;

        if (Pag == 2) aux = 2;
        
        if (Pag == 3) aux = 3;

    }
    void CargarVectorAccion (int a, int indaux, string txt )
    {
        if (a == 1) 
        {
            if (indaux == 0) pag1[0] = txt;
            if (indaux == 1) pag1[1] = txt;
            if (indaux == 2) pag1[2] = txt;
            if (indaux == 3) pag1[3] = txt;
            if (indaux == 4) pag1[4] = txt;
            if (indaux == 5) pag1[5] = txt;
            if (indaux == 6) pag1[6] = txt;
            if (indaux == 7) pag1[7] = txt;
            if (indaux == 8) pag1[8] = txt;
            if (indaux == 9) pag1[9] = txt;
            if (indaux == 10) pag1[10] = txt;
            if (indaux == 11) pag1[11] = txt;
        }
        if (a == 2)
        {
            if (indaux == 0) pag2[0] = txt;
            if (indaux == 1) pag2[1] = txt;
            if (indaux == 2) pag2[2] = txt;
            if (indaux == 3) pag2[3] = txt;
            if (indaux == 4) pag2[4] = txt;
            if (indaux == 5) pag2[5] = txt;
            if (indaux == 6) pag2[6] = txt;
            if (indaux == 7) pag2[7] = txt;
            if (indaux == 8) pag2[8] = txt;
            if (indaux == 9) pag2[9] = txt;
            if (indaux == 10) pag2[10] = txt;
            if (indaux == 11) pag2[11] = txt;
        }
        if (a == 3)
        {
            if (indaux == 0) pag3[0] = txt;
            if (indaux == 1) pag3[1] = txt;
            if (indaux == 2) pag3[2] = txt;
            if (indaux == 3) pag3[3] = txt;
            if (indaux == 4) pag3[4] = txt;
            if (indaux == 5) pag3[5] = txt;
            if (indaux == 6) pag3[6] = txt;
            if (indaux == 7) pag3[7] = txt;
            if (indaux == 8) pag3[8] = txt;
            if (indaux == 9) pag3[9] = txt;
            if (indaux == 10) pag3[10] = txt;
            if (indaux == 11) pag3[11] = txt;
        }

    }
    //========================================== Fake news =======================================//

   public void ElegirFakeNews(int Num)
    {
       
        switch (Num)
        {
            case 0:
                txtNoticiaFalsa = "No hay màs noticias";
                PC.Rating = PC.Rating - 1;
                break;
            case 1:
                txtNoticiaFalsa = "Noticia";
                NumNoticias--;
                PC.Rating = PC.Rating - 1;
                break;
            case 2:
                txtNoticiaFalsa = "Noticia";
                NumNoticias--;
                PC.Rating = PC.Rating - 1;
                break;
            case 3:
                txtNoticiaFalsa = "Noticia";
                NumNoticias--;
                PC.Rating = PC.Rating - 1;
                break;
            case 4:
                txtNoticiaFalsa = "Noticia";
                NumNoticias--;
                PC.Rating = PC.Rating - 1;
                break;
            case 5:
                txtNoticiaFalsa = "Noticia";
                NumNoticias--;
                PC.Rating = PC.Rating - 1;
                break;
                
        }
        
        
        
    }

    
       
   
}
