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
    private bool BenLavado;
    private bool BenInvestigado;
    private bool BenHackeado;
    private bool BenDifamado;
    private bool PieGrandeEliminado;
    private bool PieGrandeLavado;
    private bool PieGrandeInvestigado;
    private bool PieGrandeHackeado;
    private bool PieGrandeDifamado;
    private bool ParquePimientaAislado;
    private bool ParquePimientaEscena;
    private bool PimientaPaluzaEscena;
    private bool ColoradaInvestigada;
    private bool Red78Investigada;
    private bool KateEliminada;
    private bool KateLavada;
    private bool KateInvestigada;
    private bool KateHackeada;
    private bool KateDifamada;
    private bool PepeEliminado;
    private bool PepeLavado;
    public bool PepeInvestigado;
    private bool PepeHackeado;
    private bool PepeDifamado;
    private bool CabellosRojijosAnalizado;


    private void Start()
    {
        y = InicioBitacora.transform.position.y;
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
                float RetencionBitacora = 2;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar a Ben";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
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
                if (HoraCompletado > 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                
                BenLavado = true;
            }
            // investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && BenInvestigado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue investigado";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Investigar a Ben";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                BenInvestigado = true;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && BenHackeado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear a Ben";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                BenHackeado = true;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && BenHackeado == true && BenDifamado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar a Ben";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                BenDifamado = true;
            }
        }


        //====================================================== Bitacoras Pie Grande =============================================//
        if (libreta.palabra == "Pie Grande")
        {
            //ELIMINAR 
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PieGrandeEliminado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar a Pie Grande";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                PieGrandeEliminado = true;
            }

            //Lavar Cerebro 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PieGrandeLavado == false && PieGrandeEliminado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro Pie Grande";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                PieGrandeLavado = true;
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
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                PieGrandeInvestigado = true;
            }
            //Hackeado
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && PieGrandeHackeado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Pie Grande";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                PieGrandeHackeado = true;
                libreta.BtnRed78.gameObject.SetActive(true);
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PieGrandeDifamado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Pie Grande";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                PieGrandeDifamado = true;
            }
        }
        //=========================================================== Bitacoras Parque Pimienta =================================================//
        if (libreta.palabra == "Parque Pimienta")
        {
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && ParquePimientaAislado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Aislar Parque Pimienta";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                ParquePimientaAislado = true;
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
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                ParquePimientaEscena = true;
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
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                PimientaPaluzaEscena = true;
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
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                ColoradaInvestigada = true;
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
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                Red78Investigada = true;
                libreta.BtnKateMilliard.gameObject.SetActive(true);
            }
        }
        //===================================================== Bitacoras Kate Milliard ======================================================//
        if (libreta.palabra == "Kate Milliard")
        {
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && KateEliminada == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar Kate Milliard";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                KateEliminada = true;
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && KateEliminada == false && KateLavada == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro a Kate Milliard";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                KateLavada = true;
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
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                KateInvestigada = true;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && KateHackeada == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Kate Milliard";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                KateHackeada = true;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && KateDifamada == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Kate Milliard";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                KateDifamada = true;
            }
        }
        //================================================== Bitacoras Pepe Queño =========================================//
        if (libreta.palabra == "Pepe Queño")
        {
            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PepeEliminado == false )
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Eliminar Pepe Queño";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                PepeEliminado = true;
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PepeEliminado == false && PepeLavado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Lavar cerebro Pepe Queño";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                PepeLavado = true;
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
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                PepeInvestigado = true;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && PepeHackeado == false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Hackear Pepe Queño";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                PepeHackeado = true;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PepeDifamado== false)
            {
                float RetencionBitacora = 12;
                float HoraCompletado = RetencionBitacora + TimeManager.Hora;
                float CalculoTiempo = RetencionBitacora * 60 * time.MinutosXseg;
                string txt = "Ben fue eliminado exitosamente";
                string FechaCompletado = "2" + time.Dia + "/03/2000";
                string txtAccion = "Difamar Pepe Queño";
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                PepeDifamado = true;
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
                if (HoraCompletado >= 18)
                {
                    HoraCompletado = 6 + (RetencionBitacora - (18 - TimeManager.Hora));
                    FechaCompletado = "2" + (time.Dia + 1) + "/03/2000";
                }
                InstanciarBitacoras(txtAccion, FechaCompletado, HoraCompletado);
                TMP_Text textoPrefab = prefabAux.GetComponent<TMP_Text>();
                StartCoroutine(GuardarBitacora(CalculoTiempo, txt, textoPrefab));
                CabellosRojijosAnalizado = true;
            }

        }
        A.Restablecer();
    }

    IEnumerator GuardarBitacora(float ReinicioTiempo, string txt, TMP_Text TextoPrefab)
    {
        yield return new WaitForSeconds(ReinicioTiempo);
        TextoPrefab.text = txt;
        A.eliminar.interactable = true;
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
            prefabAux.GetComponent<TMP_Text>().text = "En proceso: " + Accion + System.Environment.NewLine + "Se completa el: " + FechaCompletado + " a las: " + HoraCompletado + ":" + TimeManager.Minuto;
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


}
