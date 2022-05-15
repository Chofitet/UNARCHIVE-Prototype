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
    //Referencias de propiedades
    GameObject PadreAux;
    public Canvas Canvas;
    public TMP_Text BitacoraPrefab;
    private TMP_Text prefabAux;
    public Transform InicioBitacora;
    public Transform InicioBitacora2;
    //Declaración varariables
    private float y;
    private int i = 0;
    public bool BenEliminado;
    public bool BenLavado;
    private bool BenInvestigado;
    private bool BenHackeado;
    private bool BenDifamado;
    public bool PieGrandeEliminado;
    private bool PieGrandeLavado;
    private bool PieGrandeInvestigado;
    private bool PieGrandeHackeado;
    private bool PieGrandeDifamado;
    private bool ParquePimientaAislado;
    private bool ParquePimientaEscena;
    private bool PimientaPaluzaEscena;
    private bool ColoradaInvestigada;
    private bool Red78Investigada;
    public bool KateEliminada;
    public bool KateLavada;
    private bool KateInvestigada;
    private bool KateHackeada;
    private bool KateDifamada;
    public bool PepeEliminado;
    public bool PepeLavado;
    public bool PepeInvestigado;
    private bool PepeHackeado;
    private bool PepeDifamado;
    public bool PepeAnalizado;
    private bool CabellosRojijosAnalizado;

    private string txtNoticiaFalsa;
    private int NumNoticias = 5;
    
    

    private void Start()
    {
        y = InicioBitacora.transform.position.y;
       
        
    }

    private void Update()
    {
        if (time.NoticiaDiaria == true)
        {
            A.crearNoticia.interactable = false;
        }
        else A.crearNoticia.interactable = true;
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
                PieGrandeDifamado = true;
                A.difamar.interactable = false;
            }
        }
        //=========================================================== Bitacoras Parque Pimienta =================================================//
        if (libreta.palabra == "Parque Pimienta")
        {
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && ParquePimientaAislado == false)
            {
                float RetencionBitacora = 3;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Aislar Parque Pimienta";
                Toggle accion = A.aislar;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                string txtAccion = "Montar escena Parque Pimienta";
                Toggle accion = A.crearEscena;
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab, accion));
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
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txtNoticiaFalsa, textoPrefab, accion));
               
                A.crearNoticia.interactable = false;
            }

      
        A.Restablecer();
    }

    IEnumerator GuardarBitacora(float ReinicioTiempo, string txt, TMP_Text TextoPrefab, Toggle accion)
    {
        yield return new WaitForSeconds(ReinicioTiempo);
        TextoPrefab.text = txt;
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
    void InstanciarBitacoras(string Accion, string FechaCompletado, float HoraCompletado)
    {
        if (i > 11)
        {
            i = 0;
            y = InicioBitacora.transform.position.y;
            Destroy(PadreAux);

        }
        if (i == 0)
        {
            PadreAux = new GameObject("PadreBitacoras");
            PadreAux.transform.SetParent(InicioBitacora.transform);
        }

        if (i < 6)
        {
            Transform aux = PadreAux.transform;
            prefabAux = Instantiate(BitacoraPrefab, new Vector3(InicioBitacora.transform.position.x, y, InicioBitacora.transform.position.z), InicioBitacora.transform.rotation);
            prefabAux.GetComponent<TMP_Text>().text = "En proceso: " + Accion + System.Environment.NewLine + "Se completa el " + FechaCompletado + " a las " + HoraCompletado + ":" + TimeManager.Minuto;
            prefabAux.transform.SetParent(aux.transform);
        }

        if (i == 6) y = InicioBitacora2.transform.position.y;

        if (i >= 6) 
        {
            Transform aux = PadreAux.transform;
            prefabAux = Instantiate(BitacoraPrefab, new Vector3(InicioBitacora2.transform.position.x, y, InicioBitacora2.transform.position.z), InicioBitacora2.transform.rotation);
            prefabAux.GetComponent<TMP_Text>().text = "En proceso: " + Accion + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
            prefabAux.transform.SetParent(aux.transform);

        }

        y = y - 50;
        i = i + 1;   
    }

    //========================================== Fake news =======================================//

   public void ElegirFakeNews(int Num)
    {
       
        switch (Num)
        {
            case 0:
                txtNoticiaFalsa = "No hay màs noticias";
                break;
            case 1:
                txtNoticiaFalsa = "Noticia";
                NumNoticias--;
                break;
            case 2:
                txtNoticiaFalsa = "Noticia";
                NumNoticias--;
               
                break;
            case 3:
                txtNoticiaFalsa = "Noticia";
                NumNoticias--;
                break;
            case 4:
                txtNoticiaFalsa = "Noticia";
                NumNoticias--;
                break;
            case 5:
                txtNoticiaFalsa = "Noticia";
                NumNoticias--;
                break;
        
        }
        
        
        
    }

    
       
   
}
