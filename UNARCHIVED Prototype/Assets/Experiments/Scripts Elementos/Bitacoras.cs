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
    [SerializeField] PantallasSwitcherManager Pantallas;

    //Declaración varariables

    public bool BenRetirado;
    public bool BenEliminado;
    public bool BenLavado;
    public bool BenInvestigado;
    public bool BenHackeado;
    public bool BenDifamado;
    public bool BenAnalizado;
    ///////////////////////////// 
    public bool PieGrandeEliminado;
    public bool PieGrandeLavado;
    public bool PieGrandeInvestigado;
    public bool PieGrandeHackeado;
    public bool PieGrandeAnalizado;
    public bool PieGrandeDifamado;
    public bool PieGrandeUbicacion;
    ///////////////////////////// 
    public bool ParquePimientaEliminado;
    public bool ParquePimientaLavado;
    public bool ParquePimientaHackeado;
    public bool ParquePimientaAnalizado;
    public bool ParquePimientaInvestigado;
    public bool ParquePimientaDifamado;
    public bool ParquePimientaAislado;
    ///////////////////////////// 
    public bool PimientaPaluzaEliminado;
    public bool PimientaPaluzaLavado;
    public bool PimientaPaluzaHackeado;
    public bool PimientaPaluzaAnalizado;
    public bool PimientaPaluzaInvestigado;
    public bool PimientaPaluzaDifamado;
    public bool PimientaPaluzaAislado;
    ///////////////////////////// 
    public bool ColoradaEliminado;
    public bool ColoradaInvestigada;
    public bool ColoradaLavada;
    public bool ColoradaHackeada;
    public bool ColoradaDifamada;
    public bool ColoradaAnalizada;
    public bool ColoradaAislada;

    /////////////////////////////
    public bool Red78Eliminada;
    public bool Red78Analizada;
    public bool Red78Difamar;
    public bool Red78Lavada;
    public bool Red78Aislada;
    public bool Red78Investigada;
    public bool Red78Hackeada;
    ///////////////////////////// 
    public bool KateEliminada;
    public bool KateLavada;
    public bool KateInvestigada;
    public bool KateHackeada;
    public bool KateDifamada;
    public bool KateAnalizada;

    ///////////////////////////// 
    public bool PepeEliminado;
    public bool PepeLavado;
    public bool PepeInvestigado;
    public bool PepeHackeado;
    public bool PepeDifamado;
    public bool PepeAnalizado;
    ///////////////////////////// 
    public bool CabellosRojijosAnalizado;
    public bool CabellosRojijosEliminado;
    public bool CabellosRojijosLavado;
    public bool CabellosRojijosInvestigado;
    public bool CabellosRojijosHackeados;
    public bool CabellosRojijosDifamado;
    public bool CabellosRojijosAislado;

    public bool BananorramaEliminado;
    public bool BananorramaLavado;
    public bool BananorramaInvestigado;
    public bool BananorramaHackeado;
    public bool BananorramaDifamado;
    public bool BananorramaAnalizado;
    public bool BananorramaAislado; 

    ////////////////////////////
    public bool PuebloPimientaEliminado;
    public bool PuebloPimientaLavado;
    public bool PuebloPimientaInvestigado;
    public bool PuebloPimientaHackeado;
    public bool PuebloPimientaDifamado;
    public bool PuebloPimientaAnalizado;
    public bool PuebloPimientaAislado;
    ////////////////////////////
    public bool PimientapaluzersEliminado;
    public bool PimientapaluzersLavado;
    public bool PimientapaluzersInvestigado;
    public bool PimientapaluzersHackeado;
    public bool PimientapaluzersDifamado;
    public bool PimientapaluzersAnalizado;
    public bool PimientapaluzersAislado;
    ///////////////////////////
    public bool WifiRobadoEliminado;
    public bool WifiRobadoLavado;
    public bool WifiRobadoAnalizado;
    public bool WifiRobadoHackeado;
    public bool WifiRobadoInvestigado;
    public bool WifiRobadoDifamado;

    ////////////////////
    public bool CrearEscena;
    public bool PlantarPublico;
    public bool TrueEnding;

    private string PreUbicacion;

    public string txtNoticiaFalsa;
    private int NumNoticias = 0;
    public bool NoticiaFalasa1;
    public bool NoticiaFalasa2;
    public bool NoticiaFalasa3;
    public bool NoticiaFalasa4;
    public bool NoticiaFalasa5;
    public bool NoticiaFalsa6;

    //Vectores bitacoras
    string[] pag1 = new string[6];
    
    string[] pag2 = new string[6];
  
    string[] pag3 = new string[6];

    string[] pag4 = new string[6];

    string[] pag5 = new string[6];

    string[] pag6 = new string[6];

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

        if (libreta.SignoPreguntaPieGrande == "") libreta.BtnWifiRobado.gameObject.SetActive(false);

        ActualizarPaginas();
    }

    // Analiza las variables: ¿que nombre de la libreta està seleccionada?, ¿què acciòn està elegida? y si otra o esa misma accion fue ejecutada para evitar incongruencias o bitacoras repetidas.
    // Si se cumplen las condiciones, imprimen la bitàcora correspondiente 
    public void ActualizarBitacoras()
    {
        //===================================================== Bitacoras Ben==============================================//
        //Eliminar
        if (libreta.palabra == libreta.palabrasCaso[0])
        {
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && BenEliminado == false && BenRetirado == false)
            {
                float RetencionBitacora = 2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Ben Benji ha contado su última paparrucha. No hubo testigos.";//hola chofitet
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
                 StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                A.eliminar.interactable = false; 
                BenEliminado = true;
               
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && BenLavado == false && BenEliminado == false && BenRetirado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Lavado completo. Ben ya no recuerda la última semana.";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                A.lavarCerebro.interactable = false;
                BenLavado = true;
            }
            // investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && BenInvestigado == false && BenRetirado == false)
            {
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Niño común y corriente. Mejor promedio del condado. Si tan solo pasara menos tiempo con su computadora quizas seria mas popular.";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                BenInvestigado = true;
                A.investigar.interactable = false;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && BenHackeado == false && BenRetirado == false)
            {
                float RetencionBitacora =2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Encontramos lista de compras e instrucciones para crear una bomba del tamaño justo para volar una escuela. Sugerimos difamar para que la fuerza de las autoridades locales caiga sobre Ben cuanto antes.";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                BenHackeado = true;
                A.hackear.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && BenAnalizado == false && BenRetirado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Nada fuera de lo ordinario. Nada de nada. Es casi como si hubieras perdido un turno.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Analizar Ben";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                BenAnalizado  = true;
                A.analizarMuestra.interactable = false;
            }
            //Difamar hay que hacer uno if hack true y otro si hack false
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && BenHackeado == true && BenDifamado == false && BenRetirado == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Las autoridades locales se han encargado del pequeño terrorista en potencia";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                BenDifamado = true;
                BenRetirado = true;
                A.difamar.interactable = false;
                
            }
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && BenHackeado == false && BenDifamado == false && BenRetirado == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Ben difamado";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                BenDifamado = true;
                A.difamar.interactable = false;
            }
        }


        //====================================================== Bitacoras Pie Grande =============================================//
        //Difamar
       if (libreta.palabra == libreta.palabrasCaso[1] && A.difamar.CompareTag(tag = "OptActivado") && PieGrandeUbicacion == false)
        {
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PieGrandeDifamado == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Mala movida. Hemos aumentado el interes del ojo publico sobre Pie grande. ¿Sos sobrino del jefe o algo?¿Como conseguiste este trabajo?";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PieGrandeDifamado = true;
                A.difamar.interactable = false;
            }
        }
        else if (libreta.palabra == libreta.palabrasCaso[1] && PieGrandeUbicacion == true)
        {
            //ELIMINAR 
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PieGrandeEliminado == false)
            {
                float RetencionBitacora = 2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "El último Pie Grande ha muerto, pero se ha cargado a nuestro agente de manera gloriosa. No podremos hacer eliminaciones por el resto del caso.";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PieGrandeEliminado = true;
                A.eliminar.interactable = false;
            }

            //Lavar Cerebro 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PieGrandeLavado == false && PieGrandeEliminado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Misión fallida. Hemos perdido al agente a manos de la criatura. Ultimo mensaje recibido “...Bananorrama”. No podremos hacer lavados de cerebro por el resto del caso.";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PieGrandeLavado = true;
                A.lavarCerebro.interactable = false;
            }
            //Investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && PieGrandeInvestigado == false)
            {
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Se muestra recluso y no cooperativo. Tenía un chupón en una pequeña parte afeitada. Encontramos cabellos rojizos en las cercanías.";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PieGrandeInvestigado = true;
                A.investigar.interactable = false;
            }
            //Hackeado
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && PieGrandeHackeado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Frecuenta la página furmatch.net. Matcheó con red78 hace 2 semanas.";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PieGrandeHackeado = true;
                A.hackear.interactable = false;
            }
            //Analizar Muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && PieGrandeAnalizado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "No es un truco. Es Pie Grande posta. Creenos.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Analizar Pie Grande";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PieGrandeAnalizado = true;
                A.analizarMuestra.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PieGrandeDifamado == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Hemos aumentado el interes del ojo público sobre Pie grande. ¿Sos sobrino del jefe o algo?¿Como conseguiste este trabajo?";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PieGrandeDifamado = true;
                A.difamar.interactable = false;
            }
            
        }
        else if (libreta.palabra == libreta.palabrasCaso[1]) 
        {
            int a = 1;
            SetearBitacora();
            a = aux;
            UbicacionNoEncontrada(libreta.palabrasCaso[1]);
            CargarVectorAccion(a, ind, PreUbicacion);
            ActualizarIndice();
        }
        //=========================================================== Bitacoras Pueblo Pimienta =================================================//
        if (libreta.palabra == libreta.palabrasCaso[5])
        {
            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PuebloPimientaEliminado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "“No tenemos una GRANJA lo suficientemente grande como para enviar a un pueblo entero.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar Pueblo Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                A.eliminar.interactable = false;
                PuebloPimientaEliminado = true;
            }
            //Lavar Cerebro 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PuebloPimientaLavado == false )
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "¡No hay suficiente tiempo! Ni ahora ni desde el comienzo del juego.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro de Pueblo Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PuebloPimientaLavado = true;
                A.lavarCerebro.interactable = false;
            }
            //Investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && PuebloPimientaInvestigado== false)
            {
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Nada sospechoso que reportar. Parece un buen lugar para retirarse. Quizás deberíamos revisar el Parque";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar Pueblo Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PuebloPimientaInvestigado = true;
                A.investigar.interactable = false;
            }
            //Hackeado
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && PuebloPimientaHackeado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Lo solicitado es un poco mucho.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Pueblo Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PuebloPimientaHackeado = true;
                A.hackear.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && PuebloPimientaAnalizado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "SuperLaboratorio Deluxe solo disponible en DLC";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Analizar Pueblo Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PuebloPimientaAnalizado = true;
                A.analizarMuestra.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PuebloPimientaDifamado == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "ENCUESTA MUNDIAL INDICA QUE LOS HABITANTES DE PUEBLO PIMIENTA CREEN EN CUALQUIER COSA";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Pueblo Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PuebloPimientaDifamado = true;
                A.difamar.interactable = false;
            }
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && PuebloPimientaAislado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "No contamos con los recursos necesarios!";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PuebloPimientaAislado = true;
                A.aislar.interactable = false;
            }
            
        }
        //=========================================================== Bitacoras Parque Pimienta =================================================//
        if (libreta.palabra == libreta.palabrasCaso[10])
        {
            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && ParquePimientaEliminado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Eliminar a Mamá Naturaleza no es una posibilidad al momento";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar a Parque Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                A.eliminar.interactable = false;
                ParquePimientaEliminado = true;
            }
            //Lavar Cerebro 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && ParquePimientaLavado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "No sabría ni por donde empezar a explicarte porque no es posible esto";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro Parque Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ParquePimientaLavado = true;
                A.lavarCerebro.interactable = false;
            }
            //Investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && ParquePimientaInvestigado == false)
            {
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Es hermoso! Aunque la wifi que tienen es privada. Medio ratas.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar Parque Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ParquePimientaInvestigado = true;
                A.investigar.interactable = false;
            }
            //Hackeado
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && ParquePimientaHackeado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Alguien se está colgando de la WIFI privada del Parque. Sugerimos investigar.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Parque Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ParquePimientaHackeado = true;
                A.hackear.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && ParquePimientaAnalizado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "SuperLaboratorio Deluxe solo disponible en DLC";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Analizar Parque Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ParquePimientaAnalizado = true;
                A.analizarMuestra.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && ParquePimientaDifamado == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Los Parques son bobos o algo así";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Parque Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ParquePimientaDifamado = true;
                A.difamar.interactable = false;
            }
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && ParquePimientaAislado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Parque Pimienta ha sido aislado. Ya nadie puede entrar ni salir.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Aislar Parque Pimienta";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ParquePimientaAislado = true;
                A.aislar.interactable = false;
            }

        }
        //========================================================== Bitacoras Pimientapaluza ==================================================//
        if (libreta.palabra == libreta.palabrasCaso[3])
        {
            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PimientaPaluzaEliminado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Puedes matar a un hombre pero nunca una idea.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar Pimientapaluza";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                A.eliminar.interactable = false;
                PimientaPaluzaEliminado = true;
            }
            //Lavar Cerebro 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PimientaPaluzaLavado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Nada que lavar por aquí";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro Pimientapaluza";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientaPaluzaLavado = true;
                A.lavarCerebro.interactable = false;
            }
            //Investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && PimientaPaluzaInvestigado == false)
            {
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "SECRETOS!";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar Pimientapaluza";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientaPaluzaInvestigado = true;
                A.investigar.interactable = false;
            }
            //Hackeado
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && PimientaPaluzaHackeado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Hemos reventado los servers de Pimientapaluza.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Pimientapaluza";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientaPaluzaHackeado = true;
                A.hackear.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && PimientaPaluzaAnalizado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Nada que analizar por aquí.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Analizar Pimientapaluza";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientaPaluzaAnalizado = true;
                A.analizarMuestra.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PimientaPaluzaDifamado == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Algo con connotaciones negativas";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Pimientapaluza";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientaPaluzaDifamado = true;
                A.difamar.interactable = false;
            }
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && PimientaPaluzaAislado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "El personal de Pimientapaluza y los Pimientapaluzersen han quedado atrapads dentro del Parque. No fué una buena desición.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Aislar Pimientapaluza";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientaPaluzaAislado = true;
                A.aislar.interactable = false;
            }

        }
        //=========================================================== Bitacoras Pimientapaluzers =================================================//
        if (libreta.palabra == libreta.palabrasCaso[11])
        {
            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PimientapaluzersEliminado == false)
            {
                float RetencionBitacora = 2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Horda de hippies eliminada. Es mi humilde opinión indicar que nos la acabamos de mandar. Fuerte.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar a Pimientapaluzers";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                A.eliminar.interactable = false;
                PimientapaluzersEliminado = true;
            }
            //Lavar Cerebro 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PimientapaluzersLavado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Son demasiados!";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a Pimientapaluzers";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientapaluzersLavado = true;
                A.lavarCerebro.interactable = false;
            }
            //Investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && PimientapaluzersInvestigado == false)
            {
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = ".";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar Pimientapaluzers";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientapaluzersInvestigado = true;
                A.investigar.interactable = false;
            }
            //Hackeado
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && PimientapaluzersHackeado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = ".";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Pimientapaluzers";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientapaluzersHackeado = true;
                A.hackear.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && PimientapaluzersAnalizado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Prefeririamos no acercarnos a ellos. Parecen sucios.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Analizar Pimientapaluzers";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientapaluzersAnalizado = true;
                A.analizarMuestra.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PimientapaluzersDifamado == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Yo mamma";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Pimientapaluzers";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientapaluzersDifamado = true;
                A.difamar.interactable = false;
            }
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && PimientapaluzersAislado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "No contamos con los recursos necesarios.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Aislar Pimientapaluzers";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientapaluzersAislado = true;
                A.aislar.interactable = false;
            }

        }
        //========================================================= Bitacoras Colorada ==========================================================//
        if (libreta.palabra == libreta.palabrasCaso[6])
        {
            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && ColoradaEliminado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "WIP";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar a Colorada";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                A.eliminar.interactable = false;
                ColoradaEliminado = true;
            }
            //Investigar 
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && ColoradaInvestigada == false)
            {
                float RetencionBitacora =0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Necesitamos mas información.";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ColoradaInvestigada = true;
                A.investigar.interactable = false;
            }
            //Brainwash
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && ColoradaLavada == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "WIP.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a colorada";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ColoradaLavada = true;
                A.lavarCerebro.interactable = false;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && ColoradaHackeada == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "WIP.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear colorada";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ColoradaHackeada = true;
                A.hackear.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && ColoradaDifamada == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "WIP.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar colorada";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ColoradaDifamada = true;
                A.difamar.interactable = false;
            }
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && ColoradaAislada == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "WIP";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Aislar colorada";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ColoradaAislada = true;
                A.aislar.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && ColoradaAnalizada == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "WIP";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Analizar ADN Colorada";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ColoradaAnalizada = true;
                A.analizarMuestra.interactable = false;
            }
        }
        //======================================================= Bitacoras Red78 ==============================================================//
        if (libreta.palabra == libreta.palabrasCaso[7])
        {
            //Investigar 
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && Red78Investigada == false && Red78Hackeada == false)
            {
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Red78 es la reconocida actriz y documentóloga Kate Milliard";
                if (libreta.BtnPelosRojizos.activeSelf == true) txt = "Bitacora 2";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                Red78Investigada = true;
                A.investigar.interactable = false;
            }
            //Hackeado
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && Red78Hackeada == false && Red78Investigada == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Red78 es la reconocida actriz y documentóloga Kate Milliard.";
                if (libreta.BtnPelosRojizos.activeSelf == true) txt = "Bitacora 2";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Red78";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                Red78Hackeada = true;
                A.hackear.interactable = false;
            }

        }
        //===================================================== Bitacoras Kate Milliard ======================================================//
        if (libreta.palabra == libreta.palabrasCaso[2])
        {
            //ELIMINAR
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && KateEliminada == false)
            {
                float RetencionBitacora = 2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Kate Milard se fué a filmar documentales a la Granja.";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                KateEliminada = true;
                A.eliminar.interactable = false;
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && KateEliminada == false && KateLavada == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Kate ya no recuerda su torrido romance.";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                KateLavada = true;
                A.lavarCerebro.interactable = false;
            }
            // investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && KateInvestigada == false)
            {
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = ".";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                KateInvestigada = true;
                A.investigar.interactable = false;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && KateHackeada == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Busquedas frequentes: Suavizante capilar, futura novia, feng shui+cueva, geomancia.";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                KateHackeada = true;
                A.hackear.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && KateDifamada == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = ".";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                KateDifamada = true;
                A.difamar.interactable = false;
            }
        }
        //================================================== Bitacoras Pepe Queño =========================================//
        if (libreta.palabra == libreta.palabrasCaso[8])
        {
            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PepeEliminado == false )
            {
                float RetencionBitacora = 2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Pepe Quenio se fué a jugar a la Granja";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar Pepe Quenio";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PepeEliminado = true;
                A.eliminar.interactable = false;
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PepeEliminado == false && PepeLavado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Pepe Quenio ha olvidado todo. No volverá a ser el mismo.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro Pepe Quenio";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PepeLavado = true;
                A.lavarCerebro.interactable = false;
            }
            // investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && PepeInvestigado == false)
                {   
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Extraño niño...Su único amigo parece ser Ben Benji. Tiene un... no se qué.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar Pepe Quenio";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PepeInvestigado = true;

                A.investigar.interactable = false;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && PepeHackeado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Búsquedas frecuentes: ¿Por qué tengo pelo ahí también ?, Siento el llamado del bosque, ¿Cuánto calza un niño normal?";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Pepe Quenio";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PepeHackeado = true;
                A.hackear.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PepeDifamado== false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Su simple existencia es difamación suficiente por esta miserable vida.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Pepe Quenio";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PepeDifamado = true;
                A.difamar.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && PepeAnalizado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "ADN coincide con Pie Grade. Posible hijo ilegítimo durante su último matrimonio. Base de datos ACTUALIZADA!";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Analizar Pepe Quenio";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PepeAnalizado = true;
                A.analizarMuestra.interactable = false;
            }
        }
        //================================================= Bitacoras WifiRobado ==========================================================//

        if (libreta.palabra == libreta.palabrasCaso[12])
        {
            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && WifiRobadoEliminado == false)
            {
                float RetencionBitacora = 2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Notificamos a los guardabosques y han cambiado la contraseña. Wifi robada 'eliminada'.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar Wifi Robado";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                WifiRobadoEliminado = true;
                A.eliminar.interactable = false;
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && WifiRobadoEliminado == false && PepeLavado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "uhm... no.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a Wifi Robado";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                WifiRobadoLavado = true;
                A.lavarCerebro.interactable = false;
            }

            // investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && WifiRobadoInvestigado == false && WifiRobadoHackeado == false )
            {
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Presencia de Pie Grande confirmada! Se encuentra en Parque Pimienta viviendole la Wifi a los guardabosques desde una cueva secreta!";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar Wifi robado";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                WifiRobadoInvestigado = true;
                A.investigar.interactable = false;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && WifiRobadoHackeado == false && WifiRobadoInvestigado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Presencia de Pie Grande confirmada! Se encuentra en Parque Pimienta viviendole la Wifi a los guardabosques desde una cueva secreta!";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Wifi Robado";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                WifiRobadoHackeado = true;
                A.hackear.interactable = false;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && WifiRobadoDifamado == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = ".";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Wifi robado";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                WifiRobadoDifamado = true;
                A.difamar.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && WifiRobadoAnalizado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "Wifi robado carece de ADN.";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Analizar Wifi Robado";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                WifiRobadoAnalizado = true;
                A.analizarMuestra.interactable = false;
            }
        }
        //================================================= Bitacoras Cabellos Rojizos ==========================================================//
        if (libreta.palabra == libreta.palabrasCaso[9])
        {
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && CabellosRojijosAnalizado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "La muestra corresponde a la reconocida actriz Kate Milliard!";
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
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                CabellosRojijosAnalizado = true;
                A.analizarMuestra.interactable = false;
            }

        }
        //================================================ Bitacoras Fake News ===================================================================//
       
          
            if (A.crearNoticia.CompareTag(tag = "OptActivado") && A.crearNoticia.isOn == true)
            {
                float RetencionBitacora = 2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
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
                StartCoroutine(GuardarBitacora( RetencionBitacora, txtNoticiaFalsa, indaux, accion, a));
               
                A.crearNoticia.interactable = false;
            }
        //================================================ Bitacoras Montar escena chapandose ===================================================================//

        if (A.crearEscena.CompareTag(tag = "OptActivado") && A.crearEscena.isOn == true && CrearEscena == false)
        {
            float RetencionBitacora = 3;
            float HoraCompletado = RetencionBitacora + TimeManager.Hora;
            string txt = "La estrategia parece haber calmado las aguas. Los agentes fueron aproximados por un pequeño niño raro llamado Pepe Quenio, su interés les llamo la atención.";
            string FechaCompletado = "2" + time.Dia + "/03/2000";
            string txtAccion = "Poner en Escena";
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
            StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
            CrearEscena = true;
            Debug.Log("funciona la bitácora");

        }
        //================================================ Bitacoras Plantar público ===================================================================//
        if (A.plantarPublico.CompareTag(tag = "OptActivado") && A.plantarPublico.isOn == true && PlantarPublico == false)
        {
            float RetencionBitacora = 1;
            float HoraCompletado = RetencionBitacora + TimeManager.Hora;
            string txt = "Los agentes estarán listos para boicotear la entrevista.";
            string FechaCompletado = "2" + time.Dia + "/03/2000";
            string txtAccion = "Boicotear entrevista";
            Toggle accion = A.plantarPublico;
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
            StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
            PlantarPublico = true;
        }
        //================================================ Bitacora TRUE ENDING  ===================================================================//
        if (A.trueEnding.CompareTag(tag = "OptActivado") && A.trueEnding.isOn == true && TrueEnding == false )
        {
            float RetencionBitacora = 1;
            float HoraCompletado = RetencionBitacora + TimeManager.Hora;
            string txt = "La nueva familia, reunida al fín por nuestra cuestionable simpatía, ha decidido encontrar un nuevo hogar donde vivir alejados de la sociedad, libres de prejuicio y sentido común."
            + System.Environment.NewLine + "Caso ganado."
            + System.Environment.NewLine + "Que Dios se apiade de nuestras almas.";
            string FechaCompletado = "2" + time.Dia + "/03/2000";
            string txtAccion = "Reunir familia";
            Toggle accion = A.plantarPublico;
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
            StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
            TrueEnding = true;
        }

        
        libreta.DesSubrayar();
        libreta.SetearPalabraLibretaACero();
        A.Restablecer();
    }

    
    IEnumerator GuardarBitacora(float ReinicioTiempo, string txt, int indaux, Toggle accion, int a)
    {
            yield return StartCoroutine(time.RetencionBitacorasSegunAccion(ReinicioTiempo));
            CargarVectorAccion(a, indaux, txt);
            if (accion != A.crearEscena && accion != A.trueEnding && accion != A.plantarPublico) accion.interactable = true;
            libreta.PersonajeEliminado();
            UbicacionConfirmada(accion);
            libreta.ActualizarPalabras(accion);
            time.TiempoNormal();
            A.DeshabilitarAcciones();
            MostrarNoticiasFalsas(accion);
    }

    

    //Crea los espacios para rellenar las bitàcoras y los borra cuando es debido
   
    public void SiguientePagina()
    {
        if (PagActual < 6)  {PagActual++;}
    }
    public void AnteriorPagina ()
    {
        if (PagActual > 1) { PagActual--; } 
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
            

        }
        else if (PagActual == 2)
        {
            B1P1.text = pag2[0];
            B2P1.text = pag2[1];
            B3P1.text = pag2[2];
            B4P1.text = pag2[3];
            B5P1.text = pag2[4];
            B6P1.text = pag2[5];
            
        }
        else if (PagActual == 3)
        {
            B1P1.text = pag3[0];
            B2P1.text = pag3[1];
            B3P1.text = pag3[2];
            B4P1.text = pag3[3];
            B5P1.text = pag3[4];
            B6P1.text = pag3[5];
           
        }
        else if (PagActual == 4 ) 
        {
            B1P1.text = pag4[0];
            B2P1.text = pag4[1];
            B3P1.text = pag5[2];
            B4P1.text = pag4[3];
            B5P1.text = pag4[4];
            B6P1.text = pag4[5];
        }
        else if (PagActual == 5)
        {
            B1P1.text = pag5[0];
            B2P1.text = pag5[1];
            B3P1.text = pag5[2];
            B4P1.text = pag5[3];
            B5P1.text = pag5[4];
            B6P1.text = pag5[5];
        }
        else if (PagActual == 6)
        {
            B1P1.text = pag6[0];
            B2P1.text = pag6[1];
            B3P1.text = pag6[2];
            B4P1.text = pag6[3];
            B5P1.text = pag6[4];
            B6P1.text = pag6[5];
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
        else if (Pag == 4)
        {
            pag4[ind] = "En proceso: " + Accion + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 5)
        {
            pag5[ind] = "En proceso: " + Accion + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 6)
        {
            pag6[ind] = "En proceso: " + Accion + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }

    }
    void ActualizarIndice ()
    {
        if (ind > 4)
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

        if (Pag == 4) aux = 4;

        if (Pag == 5) aux = 5;

        if (Pag == 6) aux = 6;

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
        
        }
        if (a == 2)
        {
            if (indaux == 0) pag2[0] = txt;
            if (indaux == 1) pag2[1] = txt;
            if (indaux == 2) pag2[2] = txt;
            if (indaux == 3) pag2[3] = txt;
            if (indaux == 4) pag2[4] = txt;
            if (indaux == 5) pag2[5] = txt;
     
        }
        if (a == 3)
        {
            if (indaux == 0) pag3[0] = txt;
            if (indaux == 1) pag3[1] = txt;
            if (indaux == 2) pag3[2] = txt;
            if (indaux == 3) pag3[3] = txt;
            if (indaux == 4) pag3[4] = txt;
            if (indaux == 5) pag3[5] = txt;
    
        }
        if (a == 4)
        {
            if (indaux == 0) pag4[0] = txt;
            if (indaux == 1) pag4[1] = txt;
            if (indaux == 2) pag4[2] = txt;
            if (indaux == 3) pag4[3] = txt;
            if (indaux == 4) pag4[4] = txt;
            if (indaux == 5) pag4[5] = txt;

        }
        if (a == 5)
        {
            if (indaux == 0) pag5[0] = txt;
            if (indaux == 1) pag5[1] = txt;
            if (indaux == 2) pag5[2] = txt;
            if (indaux == 3) pag5[3] = txt;
            if (indaux == 4) pag5[4] = txt;
            if (indaux == 5) pag5[5] = txt;

        }
        if (a == 6)
        {
            if (indaux == 0) pag6[0] = txt;
            if (indaux == 1) pag6[1] = txt;
            if (indaux == 2) pag6[2] = txt;
            if (indaux == 3) pag6[3] = txt;
            if (indaux == 4) pag6[4] = txt;
            if (indaux == 5) pag6[5] = txt;

        }
    }
    //========================================== Fake news =======================================//

   public void ElegirFakeNews(int Num)
    {
        switch (Num)
        {
            case 0:
                txtNoticiaFalsa = "PLAGA DE INSECTOS SE AVECINA SOBRE PUEBLO PIMIENTA!";
                PC.Rating = PC.Rating - 2;
                NumNoticias++;
                break;
            case 1:
                txtNoticiaFalsa = "ESTUDIO COMPRUEBA QUE CONFIAR EN TU GOBIERNO PREVIENE LA CAIDA DEL CABELLO";
                NumNoticias++;
                PC.Rating = PC.Rating - 1;
                break;
            case 2:
                txtNoticiaFalsa = "MARATÓN DEL SEÑOR DE LOS ZARCILLOS HASTA EL 28/03";
                NumNoticias++;
                PC.Rating = PC.Rating - 2;
                break;
            case 3:
                txtNoticiaFalsa = "FALLECE CANTANTE IMPORTANTE. PENSEMOS EN EL MUCHOS DIAS.";
                NumNoticias++;
                PC.Rating = PC.Rating - 1;
                break;
            case 4:
                txtNoticiaFalsa = "NO CREER TODO LO QUE TE DICEN AUMENTA TU VIRILIDAD UN 800%";
                NumNoticias++;
                PC.Rating = PC.Rating - 2;
                break;
            case 5:
                txtNoticiaFalsa = "VISITAR PARQUE PIMIENTA ATRAE LA MALA SUERTE";
                NumNoticias++;
                PC.Rating = PC.Rating - 1;
                break;
        }
    }

    void MostrarNoticiasFalsas (Toggle accion)
    {
        if (accion == A.crearNoticia)
        {
            if (NumNoticias == 0) { NoticiaFalasa1 = true; }
            if (NumNoticias == 1) { NoticiaFalasa2 = true; }
            if (NumNoticias == 2) { NoticiaFalasa3 = true; }
            if (NumNoticias == 3) { NoticiaFalasa4 = true; }
            if (NumNoticias == 4) { NoticiaFalasa5 = true; }
            if (NumNoticias == 5) { NoticiaFalsa6 = true; }
        }
    }


    void UbicacionConfirmada(Toggle accion)
    {
        if (accion == A.hackear || A.investigar == accion)
        {
            if (WifiRobadoHackeado == true || WifiRobadoInvestigado == true)
            {
                PieGrandeUbicacion = true;
                libreta.txtPieGrande.text = libreta.palabrasCaso[1];
                libreta.SignoPreguntaPieGrande = "";
                libreta.BtnPuebloPimienta.SetActive(false);
            }
        }

        if (TrueEnding == true) 
        { 
            Pantallas.SwitchCanvas(CanvasTypePantallas.TrueEnding, CanvasTypePantallas.TrueEnding);
            time.TiempoPausado();
        }

    }

    int UN;
    void UbicacionNoEncontrada (string palabra)
    {
        switch (UN)
        {
            case 0:
                PreUbicacion = "Necitamos primero el paradero de " + palabra + ".";
                UN++;
                break;
            case 1:
                PreUbicacion = "Se desconoce ubicación de " + palabra + ". Sería necesaria para esto.";
                UN++;
                break;
            case 2:
                PreUbicacion = "Necesitamos confirmar su ubicación primero.";
                UN++;
                break;
            case 3:
                PreUbicacion = "¿Sabes donde está " + palabra+"? Porque nosotros no.";
                UN++;
                break;
            case 4:
                PreUbicacion = "Objetivo inalcanzable sin conocimiento de su ubicación.";
                UN++;
                break;
            case 5:
                PreUbicacion = "El agente necesita la ubicación del objetivo primero...DUH!";
                UN = 0; 
                break;
        }
        
       
    }
  
}
