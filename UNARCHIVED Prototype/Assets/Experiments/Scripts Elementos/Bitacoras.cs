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
    public bool ParquePimientaLevantarCerca;
    ///////////////////////////// 
    public bool PimientaPaluzaEliminado;
    public bool PimientaPaluzaLavado;
    public bool PimientaPaluzaHackeado;
    public bool PimientaPaluzaAnalizado;
    public bool PimientaPaluzaInvestigado;
    public bool PimientaPaluzaDifamado;
    public bool PimientaPaluzaAislado;
    public bool PimientaPaluzaLevantarCerca;
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
    public bool Red78Difamada;
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
    public bool KateAislada;

    ///////////////////////////// 
    public bool PepeEliminado;
    public bool PepeLavado;
    public bool PepeInvestigado;
    public bool PepeHackeado;
    public bool PepeDifamado;
    public bool PepeAnalizado;
    public bool PepeAislado;

    ///////////////////////////// 
    public bool CabellosRojijosAnalizado;
    public bool CabellosRojijosEliminado;
    public bool CabellosRojijosLavado;
    public bool CabellosRojijosInvestigado;
    public bool CabellosRojijosHackeados;
    public bool CabellosRojijosDifamado;
    public bool CabellosRojijosAislado;
    
    ////////////////////////////
 
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
    public bool WifiRobadoAislado;

    //////////////////////
    public bool BitacoraCargada;

    ////////////////////
    public bool OfrecerProteccion; //falta detashar testos
    public bool ConvertirCueva;//falta detashar testos
    public bool ExtraerFoto;//falta detashar testos
    public bool CrearEscena;//falta detashar testos
    public bool PlantarPublico;//falta detashar testos
    public bool TrueEnding;//falta detashar testos
    public bool LevantarCerca;

    private string PreUbicacion;

    public string txtNoticiaFalsa;
    public string txtTituloFalsa;
    string txtBitacoraNoticia;
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

    string[] pag7 = new string[6];

    string[] pag8 = new string[6];

    string[] pag9 = new string[6];

    string[] pag10 = new string[6];

    string[] pag11 = new string[6];

    string[] pag12 = new string[6];

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

    public TMP_Text lblLevantarCerca;

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

        if (libreta.SignoPreguntaPieGrande == "") libreta.TacharPalabra(libreta.WifiRobadoBtn, libreta.txtWifiRobado, 12);

        ActualizarPaginas();
    }

    // Analiza las variables: ¿que nombre de la libreta està seleccionada?, ¿què acciòn està elegida? y si otra o esa misma accion fue ejecutada para evitar incongruencias o bitacoras repetidas.
    // Si se cumplen las condiciones, imprimen la bitàcora correspondiente 
    public void ActualizarBitacoras()
    {
        PagActual = Pag;
        //===================================================== Bitacoras Ben==============================================//
        //Eliminar
        if (libreta.palabra == libreta.palabrasCaso[0])
        {
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && BenEliminado == false )
            {
                float RetencionBitacora = 2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>BEN BENJI ELIMINADO</b>"
                + System.Environment.NewLine + "Ben Benji ha contado su última paparrucha. No hubo testigos.";//hola chofitet
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar a Ben";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && BenLavado == false && BenEliminado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>BEN BENJI LAVADO</b>"
                + System.Environment.NewLine + "Lavado completo."
                + System.Environment.NewLine + "Ben ya no posee parte de las memorias mas preciadas y formativas de la experiencia humana: las memorias de la niñez.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a Ben Benji";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado > 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && BenInvestigado == false)
            {
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>BEN BENJI INVESTIGADO</b>"
                + System.Environment.NewLine + "No demuestra actividades sospechosas. Es un niño común y corriente, aunque bastente solitario. Si tan solo pasara menos tiempo encerrado con su computadora quizas seria mas popular.";
                Toggle accion = A.investigar;
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar a Ben Benji";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && BenHackeado == false )
            {
                float RetencionBitacora =3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>BEN BENJI HACKEADO</b>"
                + System.Environment.NewLine + "Encontramos una lista de compras e instrucciones para crear una bomba del tamaño justo para volar una escuela."
                + System.Environment.NewLine + "Sugerimos difamar para que el puño de las autoridades locales caiga sobre Benji cuanto antes.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear a Ben Benji";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && BenAnalizado == false )
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>BEN BENJI ANALIZADO</b>"
                + System.Environment.NewLine + "Nada fuera de lo ordinario."
                + System.Environment.NewLine + "Nada de nada."
                + System.Environment.NewLine + "Es casi como si hubieramos perdido un turno.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar Ben Benji";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && BenHackeado == true && BenDifamado == false )
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>BEN BENJI DIFAMADO</b>"
                + System.Environment.NewLine + "Las autoridades locales se han encargado del pequeño terrorista en potencia. Benji ha quedado fuera del juego.";
                Toggle accion = A.difamar;
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar a Ben Benji";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && BenHackeado == false && BenDifamado == false )
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>BEN BENJI DIFAMADO</b>"
                + System.Environment.NewLine + "Todo listo. La noticia difamante se transmitirá en la próxima hora.";
                Toggle accion = A.difamar;
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar a Ben Benji";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIE GRANDE DIFAMADO</b>"
                + System.Environment.NewLine + "Mala movida. Hemos aumentado el interes del ojo publico sobre Pie grande. ¿Sos sobrino del jefe o algo?¿Como conseguiste este trabajo?";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar Pie Grande";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIE GRANDE ELIMINADO</b>"
                + System.Environment.NewLine + "El último Pie Grande ha muerto, pero se ha cargado a nuestro agente de manera gloriosa. No podremos hacer eliminaciones por el resto del caso.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar a Pie Grande";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIE GRANDE LAVADO</b>"
                + System.Environment.NewLine + "MISION FALLIDA. Hemos perdido al agente a manos de la criatura. No podremos hacer lavados de cerebro por el resto del caso. Último mensaje recibido “...Bananorrama”. Es una cinta del 94.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro Pie Grande";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIE GRANDE INVESTIGADO</b>"
                + System.Environment.NewLine + "Se muestra recluso y no cooperativo. Tenía un chupón en una pequeña parte afeitada. Encontramos cabellos rojizos en las cercanías.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar Pie Grande";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIE GRANDE HACKEADO</b>"
                + System.Environment.NewLine + "Frecuenta la página furmatch.net. Matcheó con red78 hace 2 semanas.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear Pie Grande";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIE GRANDE ANALIZADO</b>"
                + System.Environment.NewLine + "No es un truco. Es Pie Grande posta. Creenos.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar Pie Grande";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIE GRANDE DIFAMADO</b>"
                + System.Environment.NewLine + "Hemos aumentado el interes del ojo público sobre Pie grande. ¿Sos sobrino del jefe o algo?¿Como conseguiste este trabajo?";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar Pie Grande";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>ELIMINAR PUEBLO PIMIENTA</b>"
                + System.Environment.NewLine + "“No tenemos una GRANJA lo suficientemente grande como para enviar a un pueblo entero.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar Pueblo Pimienta";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>LAVAR PUEBLO PIMIENTA</b>"
                + System.Environment.NewLine + "¡No hay suficiente tiempo! Ni ahora ni desde el comienzo del juego.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro de Pueblo Pimienta";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PUEBLO PIMIENTA INVESTIGADO</b>"
                + System.Environment.NewLine + "Nada sospechoso que reportar. Parece un buen lugar para retirarse. Quizás deberíamos revisar el Parque";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar Pueblo Pimienta";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>HACKEAR PUEBLO PIMIENTA</b>"
                + System.Environment.NewLine + "Lo solicitado es un poco mucho.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear Pueblo Pimienta";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>ANALIZAR PUEBLO PIMIENTA</b>"
                + System.Environment.NewLine + "SuperLaboratorio Deluxe solo disponible en DLC";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar Pueblo Pimienta";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PUEBLO PIMIENTA DIFAMADO</b>"
                + System.Environment.NewLine + "Todo listo. La noticia difamante se transmitirá en la próxima hora.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar Pueblo Pimienta";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>AISLAR PUEBLO PIMIENTA</b>"
                + System.Environment.NewLine + "No contamos con los recursos necesarios!";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Aislar Pueblo Pimienta";
                Toggle accion = A.aislar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>ELIMINAR PARQUE PIMIENTA</b>"
                + System.Environment.NewLine + "Eliminar a Mamá Naturaleza no es una posibilidad al momento.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar a Parque Pimienta";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>LAVAR PARQUE PIMIENTA</b>"
                + System.Environment.NewLine + "No sabría ni por donde empezar a explicarte porque no es posible esto.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro Parque Pimienta";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PARQUE PIMIENTA INVESTIGADO</b>"
                + System.Environment.NewLine + "Es hermoso! Aunque la wifi que tienen es privada. Medio ratas.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar Parque Pimienta";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PARQUE PIMIENTA HAQUEADO</b>"
                + System.Environment.NewLine + "Alguien se está colgando de la WIFI privada del Parque. Sugerimos investigar.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear Parque Pimienta";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar Parque Pimienta";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PARQUE PIMIENTA DIFAMADO</b>"
                + System.Environment.NewLine + "WIP Los Parques son bobos o algo así";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar Parque Pimienta";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PARQUE PIMIENTA AISLADO</b>"
                + System.Environment.NewLine + "Parque Pimienta ha sido aislado. Ya nadie puede entrar ni salir.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Aislar Parque Pimienta";
                Toggle accion = A.aislar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>ELIMINAR PIMIENTAPALUZA</b>"
                + System.Environment.NewLine + "Puedes matar a un hombre pero nunca una idea.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar Pimientapaluza";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>LAVAR PIMIENTAPALUZA</b>"
                + System.Environment.NewLine + "Nada que lavar por aquí";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro Pimientapaluza";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIMIENTAPALUZA HACKEADO</b>"
                + System.Environment.NewLine + "WIP SECRETOS!";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar Pimientapaluza";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIMIENTAPALUZA HACKEADO</b>"
                + System.Environment.NewLine + "Hemos reventado los servers de Pimientapaluza.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear Pimientapaluza";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>ANALIZAR PIMIENTAPALUZA</b>"
                + System.Environment.NewLine + "Nada que analizar por aquí.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar Pimientapaluza";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIMIENTAPALUZA DIFAMADO</b>"
                + System.Environment.NewLine + "Todo listo. La noticia difamante se transmitirá en la próxima hora.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar Pimientapaluza";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIMIENTAPALUZA AISLADO</b>"
                + System.Environment.NewLine + "El personal de Pimientapaluza y los Pimientapaluzersen han quedado atrapads dentro del Parque. No fué una buena desición.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Aislar Pimientapaluza";
                Toggle accion = A.aislar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIMIENTAPALUZERS ELIMINADOS</b>"
                + System.Environment.NewLine + "Horda de hippies eliminada. Es mi humilde opinión indicar que nos la acabamos de mandar. Fuerte.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar a Pimientapaluzers";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>LAVAR PIMIENTAPALUZERS</b>"
                + System.Environment.NewLine + "Son demasiados!";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a Pimientapaluzers";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIMIENTAPALUZERS INVESTIGADOS</b>"
                + System.Environment.NewLine + "WIP Pasión e integridad.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar Pimientapaluzers";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIMIENTAPALUZERS HACKEADOS</b>"
                + System.Environment.NewLine + "WIP Todos sacaron las entradas online pero.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear Pimientapaluzers";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>ANALIZAR PIMIENTAPALUZERS</b>"
                + System.Environment.NewLine + "Prefeririamos no acercarnos a ellos. Parecen sucios.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar Pimientapaluzers";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PIMIENTAPALUZERS DIFAMADOS</b>"
                + System.Environment.NewLine + "WIP Yo mamma. algo que los dañe";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar Pimientapaluzers";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>AISLAR PIMIENTAPALUZERS</b>"
                + System.Environment.NewLine + "No contamos con los recursos necesarios.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Aislar Pimientapaluzers";
                Toggle accion = A.aislar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>ELIMINAR COLORADA</b>"
                + System.Environment.NewLine + "Tendriamos que dar primero con su identidad y paradero.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar a Colorada";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>INVESTIGAR COLORADA</b>"
                + System.Environment.NewLine + "WIP quizas debamos focalizarnos en los involucrados confirmados.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar colorada";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>LAVAR COLORADA</b>"
                + System.Environment.NewLine + "WIP Tendriamos que dar primero con su identidad y paradero.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a colorada";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>HACKEAR COLORADA</b>"
                + System.Environment.NewLine + "WIP Tendriamos que dar primero con su identidad y paradero.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear colorada";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>COLORADA DIFAMADA</b>"
                + System.Environment.NewLine + "Ninfómana cabellos de Satán realiza actos indebidos ante la juventud. Mantengan a sus hijos en sus casas.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar colorada";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>AISLAR COLORADA</b>"
                + System.Environment.NewLine + "Quizás debamos pensar un poco más antes de unir palabras al azar.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Aislar colorada";
                Toggle accion = A.aislar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>ANALIZAR COLORADA</b>"
                + System.Environment.NewLine + "Quizás debamos analizar .";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar ADN Colorada";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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

            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && Red78Eliminada == false)
            {
                float RetencionBitacora =0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>ELIMINAR RED78</b>"
                + System.Environment.NewLine + "Tendriamos que dar primero con la persona que se esconde tras el nombre Red78.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar Red78";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                A.eliminar.interactable = false;
                Red78Eliminada = true;
            }
            //Investigar 
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && Red78Investigada == false && Red78Hackeada == false)
            {
                float RetencionBitacora = 4;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>ELIMINAR RED78</b>"
                + System.Environment.NewLine + "Red78 es la reconocida actriz y documentóloga Kate Milliard";
                if (libreta.BtnPelosRojizos.activeSelf == true) txt = "Bitacora 2";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar Red78";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
            //Brainwash
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && Red78Lavada == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>LAVAR RED78</b>"
                + System.Environment.NewLine + "WIP.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a Red78";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                Red78Lavada = true;
                A.lavarCerebro.interactable = false;
            }
            //Hackeado
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && Red78Hackeada == false && Red78Investigada == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>RED78 HACKEADA</b>"
                + System.Environment.NewLine + "Red78 es la reconocida actriz y documentóloga Kate Milliard.";
                if (libreta.BtnPelosRojizos.activeSelf == true) txt = "Bitacora 2";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear Red78";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && Red78Difamada == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>RED78 DIFAMADA</b>"
                + System.Environment.NewLine + "WIP Escondan a sus niños!.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar Red78";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                Red78Difamada = true;
                A.difamar.interactable = false;
            }
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && Red78Aislada == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>AISLAR RED78</b>"
                + System.Environment.NewLine + "Solo por que la acción esté disponible no quiere decir que haya que probarla con cada palabrita de cada caso.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Aislar Red78";
                Toggle accion = A.aislar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                Red78Aislada = true;
                A.aislar.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && Red78Analizada == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>ANALIZAR RED78</b>"
                + System.Environment.NewLine + "Los nombres de usuario, por mas sucios que sean, carecen de ADN.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar ADN de Red78";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                Red78Analizada = true;
                A.analizarMuestra.interactable = false;
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
                string txt = "<b>KATE MILLIARD ELIMINADA</b>"
                + System.Environment.NewLine + "Kate Milard se fué a filmar documentales a la Granja.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar Kate Milliard";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>KATE MILLIARD LAVADA</b>"
                + System.Environment.NewLine + "Kate ya no recuerda su torrido romance.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a Kate Milliard";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>KATE MILLIARD INVESTIGADA</b>"
                + System.Environment.NewLine + "WIP Se encuentra alojada bajo un pseudonimo en un motel cercano a Parque Pimienta.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar Kate Milliard";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>KATE MILLIARD HACKEADA</b>"
                + System.Environment.NewLine + "Busquedas frequentes: Suavizante capilar, futura novia, feng shui+cueva, geomancia.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear Kate Milliard";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>KATE MILLIARD DIFAMADA</b>"
                + System.Environment.NewLine + "WIP algo del pasado (pateo un mono en el set de bananorrama).";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar Kate Milliard";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && KateAislada == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>AISLAR KATE MILLIARD</b>"
                + System.Environment.NewLine + "La cerca que tenemos es muy grande para una sola persona WIP";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Aislar Kate Milliard";
                Toggle accion = A.aislar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                KateAislada = true;
                A.aislar.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && KateAnalizada == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>KATE MILLIARD ANALIZADA</b>"
                + System.Environment.NewLine + "Jefe, tenemos raras noticias. Se encuentra embarazada...WIP";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar Kate Milliard";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                KateAnalizada = true;
                A.analizarMuestra.interactable = false;
            }
        }
        //================================================== Bitacoras Pepe GQuenio =========================================//
        if (libreta.palabra == libreta.palabrasCaso[8])
        {
            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PepeEliminado == false )
            {
                float RetencionBitacora = 2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>PEPE QUENIO ELIMINADO</b>"
                + System.Environment.NewLine + "Pepe Quenio se fué a jugar a la Granja";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar Pepe Quenio";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PEPE QUENIO LAVADO</b>"
                + System.Environment.NewLine + "Pepe Quenio ha olvidado todo. No volverá a ser el mismo.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro Pepe Quenio";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PEPE QUENIO INVESTIGADO</b>"
                + System.Environment.NewLine + "BASE DE DATOS ACTUALIZADA. Extraño niño...Su único amigo parece ser Ben Benji. Tiene un... no se qué.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar Pepe Quenio";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PEPE QUENIO HACKEADO</b>"
                + System.Environment.NewLine + "Búsquedas frecuentes: ¿Por qué tengo pelo ahí también?, Siento el llamado del bosque, ¿Cuánto calza un niño normal?";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear Pepe Quenio";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>DIFAMAR PEPE QUENIO</b>"
                + System.Environment.NewLine + "Su simple existencia es difamación suficiente por esta miserable vida.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar Pepe Quenio";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>PEPE QUENIO ANALIZADO</b>"
                + System.Environment.NewLine + "BASE DE DATOS ACTUALIZADA. ADN coincide con Pie Grade. Posible hijo ilegítimo durante su último matrimonio.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar Pepe Quenio";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && PepeAislado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>AISLAR PEPE QUENIO</b>"
                + System.Environment.NewLine + "Este plan de acción es solo aplicable a LUGARES";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Aislar Pepe Quenio";
                Toggle accion = A.aislar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PepeAislado = true;
                A.aislar.interactable = false;
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
                string txt = "<b>WIFI ROBADO ELIMINADO</b>"
                + System.Environment.NewLine + "Notificamos a los guardabosques y han cambiado la contraseña. Wifi robada 'eliminada'.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar Wifi Robado";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>LAVAR WIFI ROBADO</b>"
                + System.Environment.NewLine + "uhm... no.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a Wifi Robado";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>WIFI ROBADO INVESTIGADO</b>"
                + System.Environment.NewLine + "Presencia de Pie Grande confirmada! Se encuentra en Parque Pimienta viviendole la Wifi a los guardabosques desde una cueva secreta!";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar Wifi robado";
                Toggle accion = A.investigar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>WIFI ROBADO HACKEADO</b>"
                + System.Environment.NewLine + "Presencia de Pie Grande confirmada! Se encuentra en Parque Pimienta viviendole la Wifi a los guardabosques desde una cueva secreta!";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear Wifi Robado";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>WIFI ROBADO DIFAMADO</b>"
                + System.Environment.NewLine + "WIP sucio ladron se encuentra robandole el wifi a la noble reserva Parque Pimienta.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar Wifi robado";
                Toggle accion = A.difamar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
                string txt = "<b>ANALIZAR WIFI ROBADO</b>"
                + System.Environment.NewLine + "Wifi robado carece de ADN.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar Wifi Robado";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && WifiRobadoAislado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>AISLAR WIFI ROBADO</b>"
                + System.Environment.NewLine + "Quizás debamos pensar un poco más antes de unir palabras al azar.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Aislar Wifi Robado";
                Toggle accion = A.aislar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                WifiRobadoAislado = true;
                A.aislar.interactable = false;
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
                string txt = "<b>CABELLOS ROJIZOS ANALIZADOS</b>"
                + System.Environment.NewLine + "La muestra corresponde a la reconocida actriz Kate Milliard!";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar cabellos rojizos";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
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

        //===================================================== Bitacoras Bananorrama==============================================//
        //Eliminar
        if (libreta.palabra == libreta.palabrasCaso[4])
        {
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && BananorramaEliminado == false)
            {
                float RetencionBitacora = 2;//revisar
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>ELIMINAR BANANORRAMA</b>"//REVISAR SI ES POSIBLE O NO
                + System.Environment.NewLine + "Hemos terciarizado el acto de eliminar cada cinta de Bananorrama en existencia. Aguardamos novedades.";//
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Eliminar Bananorrama";
                Toggle accion = A.eliminar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                A.eliminar.interactable = false;
                BananorramaEliminado = true;

            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && BananorramaLavado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>LAVAR BANANORRAMA</b>"
                + System.Environment.NewLine + "No.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a Bananorrama";
                Toggle accion = A.lavarCerebro;
                if (HoraCompletado > 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                A.lavarCerebro.interactable = false;
                BananorramaLavado = true;
            }
            // investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && BananorramaInvestigado == false)
            {
                float RetencionBitacora = 2;//revisar
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>BANANORRAMA INVESTIGADO</b>"
                + System.Environment.NewLine + "WIP El agente ha terminado de ver la película Bananorrama.";
                Toggle accion = A.investigar;
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Investigar Bananorrama";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                BananorramaInvestigado = true;
                A.investigar.interactable = false;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && BananorramaHackeado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>HACKEAR BANANORRAMA</b>"
                + System.Environment.NewLine + "No podemos hackear eso.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Hackear Bananorrama";
                Toggle accion = A.hackear;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                BananorramaHackeado = true;
                A.hackear.interactable = false;
            }
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && BananorramaAnalizado == false)
            {
                float RetencionBitacora = 0.001f;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>ANALIZAR BABANORRAMA</b>"
                + System.Environment.NewLine + "El ADN de la película no requiere un laboratorio para ser analizado. Sus origenes e inspiraciones se datan a WIP";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Analizar Bananorrama";
                Toggle accion = A.analizarMuestra;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                BananorramaAnalizado = true;
                A.analizarMuestra.interactable = false;
            }

            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && BananorramaDifamado == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>BANANORRAMA DIFAMADO</b>"
                + System.Environment.NewLine + "WIP peli mala tuto. porque un remake de bananorrama seria una mala idea. critico que no habia visto aun bananorrama se siente insultado personalmente por la cinta ";
                Toggle accion = A.difamar;
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Difamar Bananorrama";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                BananorramaDifamado = true;
                A.difamar.interactable = false;

            }

        }
            //================================================ Bitacoras Fake News ===================================================================//


            if (A.crearNoticia.CompareTag(tag = "OptActivado") && A.crearNoticia.isOn == true)
            {
                float RetencionBitacora = 2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                ElegirFakeNews(NumNoticias);
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Crear noticia falsa";
                Toggle accion = A.crearNoticia;
                time.NoticiaDiaria = true;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                    
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora( RetencionBitacora, txtBitacoraNoticia, indaux, accion, a));
               
                A.crearNoticia.interactable = false;
            }
        //================================================ Bitacoras Montar escena chapandose ===================================================================//

        if (A.crearEscena.CompareTag(tag = "OptActivado") && A.crearEscena.isOn == true && CrearEscena == false)
        {
            float RetencionBitacora = 3;
            float HoraCompletado = RetencionBitacora + TimeManager.Hora;
            string txt = "<b>MONTAR ESCENA CON AGENTE PELUDO Y AGENTE CON PELUCA COLORADA WIP</b>"
            + System.Environment.NewLine + "La estrategia parece haber calmado las aguas. Los agentes fueron aproximados por un pequeño niño raro llamado Pepe Quenio, su interés en ellos les llamó la atención. WIP";
            string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
            string txtAccion = "Montar Escena";
            Toggle accion = A.crearEscena;
            if (HoraCompletado >= 18)
            {
                HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
            }
            int indaux = ind;
            int a = 1;
            CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
            SetearBitacora();
            a = aux;
            ActualizarIndice();
            StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
            CrearEscena = true;
            A.crearEscena.interactable = false;

        }
        //================================================ Bitacoras Plantar público ===================================================================//
        if (A.plantarPublico.CompareTag(tag = "OptActivado") && A.plantarPublico.isOn == true && PlantarPublico == false)
        {
            float RetencionBitacora = 1;
            float HoraCompletado = RetencionBitacora + TimeManager.Hora;
            string txt = "<b>AGENTES PLANTADOS EN PUBLICO DE ENTREVISTA</b>"
            + System.Environment.NewLine + "Los agentes estarán listos para boicotear la entrevista apenas comience.";
            string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
            string txtAccion = "Boicotear entrevista";
            Toggle accion = A.plantarPublico;
            if (HoraCompletado >= 18)
            {
                HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";

            }
            int indaux = ind;
            int a = 1;
            CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
            SetearBitacora();
            a = aux;
            ActualizarIndice();
            StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
            PlantarPublico = true;
            A.plantarPublico.interactable = false;
        }
        //================================================ Bitacora TRUE ENDING  ===================================================================//
        if (A.trueEnding.CompareTag(tag = "OptActivado") && A.trueEnding.isOn == true && TrueEnding == false )
        {
            float RetencionBitacora = 1;
            float HoraCompletado = RetencionBitacora + TimeManager.Hora;
            string txt = "<b>FAMILIA REUNIDA</b>"
            + System.Environment.NewLine + "La nueva familia, reunida al fín gracias a nuestra cuestionable simpatía, ha decidido encontrar un nuevo hogar donde vivir alejados de la sociedad, libres de prejuicio y sentido común."
            + System.Environment.NewLine + "Caso ganado."
            + System.Environment.NewLine + "Que Dios se apiade de nuestras almas.";
            string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
            string txtAccion = "Reunir familia";
            Toggle accion = A.plantarPublico;
            if (HoraCompletado >= 18)
            {
                HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";

            }
            int indaux = ind;
            int a = 1;
            CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
            SetearBitacora();
            a = aux;
            ActualizarIndice();
            StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
            TrueEnding = true;
            A.trueEnding.interactable = false;
        }
        //=========================================================== Bitacora  Ofrecer Protección ===================================================================//
        if (A.ofrecerProteccion.CompareTag(tag = "OptActivado") && A.ofrecerProteccion.isOn == true && OfrecerProteccion == false)
        {
            float RetencionBitacora = 1;
            float HoraCompletado = RetencionBitacora + TimeManager.Hora;
            string txt = "<b>PROTECCION Y ASILO OFRECIDOS</b>"
            + System.Environment.NewLine + "Wip";
            string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
            string txtAccion = "Ofrenda de asilo y protección";
            Toggle accion = A.ofrecerProteccion;
            if (HoraCompletado >= 18)
            {
                HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
            }
            int indaux = ind;
            int a = 1;
            CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
            SetearBitacora();
            a = aux;
            ActualizarIndice();
            StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
            OfrecerProteccion = true;
            A.ofrecerProteccion.interactable = false;
        }
        //=========================================================== Bitacora Convertir Cueva ===================================================================//
        if (A.convertirCueva.CompareTag(tag = "OptActivado") && A.convertirCueva.isOn == true && ConvertirCueva == false && ParquePimientaAislado == true)
        {
            float RetencionBitacora = 1;
            float HoraCompletado = RetencionBitacora + TimeManager.Hora;
            string txt = "<b>CUEVA SECRETA CONVERTIDA EN GIFT SHOP</b>"
            + System.Environment.NewLine + "Wip va a estar todo bien";
            string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
            string txtAccion = "Convertir cueva secreta en Gift Shop";
            Toggle accion = A.convertirCueva;
            if (HoraCompletado >= 18)
            {
                HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";

            }
            int indaux = ind;
            int a = 1;
            CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
            SetearBitacora();
            a = aux;
            ActualizarIndice();
            StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
            ConvertirCueva = true;
            A.convertirCueva.interactable = false;
        }
        if (A.convertirCueva.CompareTag(tag = "OptActivado") && A.convertirCueva.isOn == true && ConvertirCueva == false && ParquePimientaAislado == false)
        {
            float RetencionBitacora = 0.001f;
            float HoraCompletado = RetencionBitacora + TimeManager.Hora;
            string txt = "<b>CONVERTIR CUEVA SECRETA EN GIFT SHOP</b>"
            + System.Environment.NewLine + "No puede haber testigos de esto, debemos asegurarnos antes que nadie pueda entrar al parque.";
            string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
            string txtAccion = "Convertir cueva secreta en Gift Shop";
            Toggle accion = A.convertirCueva;
            if (HoraCompletado >= 18)
            {
                HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";

            }
            int indaux = ind;
            int a = 1;
            CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
            SetearBitacora();
            a = aux;
            ActualizarIndice();
            StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
            ConvertirCueva = true;
            A.convertirCueva.interactable = false;
        }
        //=========================================================== Bitacora Extraer fotos ===================================================================//
        if (A.extraerFotos.CompareTag(tag = "OptActivado") && A.extraerFotos.isOn == true && ExtraerFoto == false)
        {
            float RetencionBitacora = 1;
            float HoraCompletado = RetencionBitacora + TimeManager.Hora;
            string txt = "<b>FOTOS EXTRAIDAS</b>"
            + System.Environment.NewLine + "El pequeño set fotos amateur muestra una mancha marrón y una roja fuera de foco.";
            string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
            string txtAccion = "Extracción de fotos";
            Toggle accion = A.extraerFotos;
            if (HoraCompletado >= 18)
            {
                HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";

            }
            int indaux = ind;
            int a = 1;
            CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
            SetearBitacora();
            a = aux;
            ActualizarIndice();
            StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
            ExtraerFoto = true;
            A.extraerFotos.interactable = false;
        }
        //=========================================================== Levantar cerca ===================================================================//
        //Levantar cerca Parque Pimienta
        if (libreta.palabrasCaso[10] == lblLevantarCerca.text)
        {
            if (A.levantarCerca.CompareTag(tag = "OptActivado") && A.levantarCerca.isOn == true && ParquePimientaLevantarCerca == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>CERCO QUITADO DE PARQUE PIMIENTA</b>"
                + System.Environment.NewLine + "Hay pase libre al parque nuevamente.";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Quitando cerco de Parque Pimienta";
                Toggle accion = A.levantarCerca;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                ParquePimientaLevantarCerca = true;
                A.levantarCerca.interactable = false;
            }
        }
        //Levantar cerca
        if (libreta.palabrasCaso[3] == lblLevantarCerca.text)
        {
            if (A.levantarCerca.CompareTag(tag = "OptActivado") && A.levantarCerca.isOn == true && PimientaPaluzaLevantarCerca == false)
            {
                float RetencionBitacora = 1;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                string txt = "<b>CERCO QUITADO DE PIMIENTAPALUZA</b>"
                + System.Environment.NewLine + "Wip";
                string FechaCompletado = "2" + TimeManager.Dia + "/03/2000";
                string txtAccion = "Quitando cerco de Pimientapaluza";
                Toggle accion = A.levantarCerca;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (TimeManager.Dia + 1) + "/03/2000";
                }
                int indaux = ind;
                int a = 1;
                CargarVectorProgreso(txtAccion, FechaCompletado, HoraCompletado, indaux);
                SetearBitacora();
                a = aux;
                ActualizarIndice();
                StartCoroutine(GuardarBitacora(RetencionBitacora, txt, indaux, accion, a));
                PimientaPaluzaLevantarCerca = true;
                A.levantarCerca.interactable = false;
            }
        }


        libreta.DesSubrayar();
        libreta.SetearPalabraLibretaACero();
        A.Restablecer();
        A.DeshabilidarAccionesInstantadea();
    }


    IEnumerator GuardarBitacora(float ReinicioTiempo, string txt, int indaux, Toggle accion, int a)
    {
            yield return StartCoroutine(time.RetencionBitacorasSegunAccion(ReinicioTiempo));
            CargarVectorAccion(a, indaux, txt);
            if (accion != A.crearEscena && accion != A.trueEnding && accion != A.plantarPublico && accion != A.extraerFotos && accion != A.ofrecerProteccion && accion != A.convertirCueva) accion.interactable = true;
            libreta.PersonajeEliminado();
            UbicacionConfirmada(accion);
            libreta.ActualizarPalabras(accion);
            time.TiempoNormal();
            A.DeshabilitarAcciones();
            MostrarNoticiasFalsas(accion);
            BitacoraCargada = true;
    }

    

    //Crea los espacios para rellenar las bitàcoras y los borra cuando es debido
   
    public void SiguientePagina()
    {
        if (PagActual < Pag)  {PagActual++;}
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
            B3P1.text = pag4[2];
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
        if (PagActual == 7)
        {
            B1P1.text = pag7[0];
            B2P1.text = pag7[1];
            B3P1.text = pag7[2];
            B4P1.text = pag7[3];
            B5P1.text = pag7[4];
            B6P1.text = pag7[5];
        }
       else if (PagActual == 8)
        {
            B1P1.text = pag8[0];
            B2P1.text = pag8[1];
            B3P1.text = pag8[2];
            B4P1.text = pag8[3];
            B5P1.text = pag8[4];
            B6P1.text = pag8[5];

        }
        else if (PagActual == 9)
        {
            B1P1.text = pag9[0];
            B2P1.text = pag9[1];
            B3P1.text = pag9[2];
            B4P1.text = pag9[3];
            B5P1.text = pag9[4];
            B6P1.text = pag9[5];

        }
        else if (PagActual == 10)
        {
            B1P1.text = pag10[0];
            B2P1.text = pag10[1];
            B3P1.text = pag10[2];
            B4P1.text = pag10[3];
            B5P1.text = pag10[4];
            B6P1.text = pag10[5];
        }
        else if (PagActual == 11)
        {
            B1P1.text = pag11[0];
            B2P1.text = pag11[1];
            B3P1.text = pag11[2];
            B4P1.text = pag11[3];
            B5P1.text = pag11[4];
            B6P1.text = pag11[5];
        }
        else if (PagActual == 12)
        {
            B1P1.text = pag12[0];
            B2P1.text = pag12[1];
            B3P1.text = pag12[2];
            B4P1.text = pag12[3];
            B5P1.text = pag12[4];
            B6P1.text = pag12[5];
        }


    }

    void CargarVectorProgreso(string Accion, string FechaCompletado, float HoraCompletado, int ind)
    { 
        if (Pag == 1)
        {
            pag1[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 2)
        {
            pag2[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 3)
        {
            pag3[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 4)
        {
            pag4[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 5)
        {
            pag5[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 6)
        {
            pag6[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 7)
        {
            pag7[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 8)
        {
            pag8[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 9)
        {
            pag9[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 10)
        {
            pag10[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 11)
        {
            pag11[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
        }
        else if (Pag == 12)
        {
            pag12[ind] = Accion + " en proceso: " + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
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

        if (Pag == 7) aux = 7;

        if (Pag == 8) aux = 8;

        if (Pag == 9) aux = 9;

        if (Pag == 10) aux = 10;

        if (Pag == 11) aux = 11;

        if (Pag == 12) aux = 12;

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
        if (a == 7)
        {
            if (indaux == 0) pag7[0] = txt;
            if (indaux == 1) pag7[1] = txt;
            if (indaux == 2) pag7[2] = txt;
            if (indaux == 3) pag7[3] = txt;
            if (indaux == 4) pag7[4] = txt;
            if (indaux == 5) pag7[5] = txt;

        }
        if (a == 8)
        {
            if (indaux == 0) pag8[0] = txt;
            if (indaux == 1) pag8[1] = txt;
            if (indaux == 2) pag8[2] = txt;
            if (indaux == 3) pag8[3] = txt;
            if (indaux == 4) pag8[4] = txt;
            if (indaux == 5) pag8[5] = txt;

        }
        if (a == 9)
        {
            if (indaux == 0) pag9[0] = txt;
            if (indaux == 1) pag9[1] = txt;
            if (indaux == 2) pag9[2] = txt;
            if (indaux == 3) pag9[3] = txt;
            if (indaux == 4) pag9[4] = txt;
            if (indaux == 5) pag9[5] = txt;

        }
        if (a == 10)
        {
            if (indaux == 0) pag10[0] = txt;
            if (indaux == 1) pag10[1] = txt;
            if (indaux == 2) pag10[2] = txt;
            if (indaux == 3) pag10[3] = txt;
            if (indaux == 4) pag10[4] = txt;
            if (indaux == 5) pag10[5] = txt;

        }
        if (a == 11)
        {
            if (indaux == 0) pag11[0] = txt;
            if (indaux == 1) pag11[1] = txt;
            if (indaux == 2) pag11[2] = txt;
            if (indaux == 3) pag11[3] = txt;
            if (indaux == 4) pag11[4] = txt;
            if (indaux == 5) pag11[5] = txt;

        }
        if (a == 12)
        {
            if (indaux == 0) pag12[0] = txt;
            if (indaux == 1) pag12[1] = txt;
            if (indaux == 2) pag12[2] = txt;
            if (indaux == 3) pag12[3] = txt;
            if (indaux == 4) pag12[4] = txt;
            if (indaux == 5) pag12[5] = txt;

        }
    }
    //========================================== Fake news =======================================//

   public void ElegirFakeNews(int Num)
    {
        switch (Num)
        {
            case 0:
                txtBitacoraNoticia = "<b>NOTICIA FALSA CREADA</b>"
                + System.Environment.NewLine + "Entrará en transmisión a la brevedad.";
                txtTituloFalsa = "PUEBLO PIMIENTA NOMINADO A PUEBLO MENOS ILUSO DEL PLANETA";
                txtNoticiaFalsa = "EL PREMIO SERÁ ENTREGADO EN ASDFGD";
                NumNoticias++;
                break;
            case 1:
                txtBitacoraNoticia = "<b>NOTICIA FALSA CREADA</b>"
                + System.Environment.NewLine + "Entrará en transmisión a la brevedad.";
                txtTituloFalsa = "ESTUDIO COMPRUEBA QUE EL ESCEPTICISMO PREVIENE LA CAIDA DEL CABELLO";
                txtNoticiaFalsa = "";
                NumNoticias++;
                break;
            case 2:
                txtBitacoraNoticia = "<b>NOTICIA FALSA CREADA</b>"
                + System.Environment.NewLine + "Entrará en transmisión a la brevedad.";
                txtTituloFalsa = "MARATÓN DE EL SEÑOR DE LOS ZARCILLOS ARRANCA DE HOY HASTA EL 28/03";
                txtNoticiaFalsa = "";
                NumNoticias++;
                break;
            case 3:
                txtBitacoraNoticia = "<b>NOTICIA FALSA CREADA</b>"
                + System.Environment.NewLine + "Entrará en transmisión a la brevedad.";
                txtTituloFalsa = "FALLECE CANTANTE IMPORTANTE. PENSEMOS EN EL MUCHO Y MUCHOS DIAS.";
                txtNoticiaFalsa = "";
                NumNoticias++;
                break;
            case 4:
                txtBitacoraNoticia = "<b>NOTICIA FALSA CREADA</b>"
                + System.Environment.NewLine + "Entrará en transmisión a la brevedad.";
                txtTituloFalsa = "NO CREER TODO LO QUE TE DICEN AUMENTA TU VIRILIDAD UN 800%";
                txtNoticiaFalsa = "";
                NumNoticias++;
                break;
            case 5:
                txtBitacoraNoticia = "<b>NOTICIA FALSA CREADA</b>"
                + System.Environment.NewLine + "Entrará en transmisión a la brevedad.";
                txtTituloFalsa = "CONFIRMADO: VISITAR PARQUE PIMIENTA ATRAE LA MALA SUERTE Y EL ESCORBUTO";
                txtNoticiaFalsa = "";
                NumNoticias++;
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
                libreta.TacharPalabra(libreta.PuebloPimientaBtn, libreta.txtPuebloPimienta, 5);
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
                PreUbicacion = "¿Sabes donde está " + palabra + "? Porque nosotros no.";
                UN++;
                break;
            case 1:
                PreUbicacion = "No contamos con la ubicación de " + palabra + ". Sería necesaria para llevar a cabo la directiva.";
                UN++;
                break;
            case 2:
                PreUbicacion = "Necesitamos que confirmen su ubicación primero.";
                UN++;
                break;
            case 3:
                PreUbicacion = "Necesitamos primero contar con el paradero de " + palabra + ".";
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
