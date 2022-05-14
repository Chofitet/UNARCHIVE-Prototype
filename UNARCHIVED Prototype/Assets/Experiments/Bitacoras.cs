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
                float RetencionBitacora = 12;
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
                
                BenEliminado = true;
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && BenLavado == false && BenEliminado == false)
            {
                float RetencionBitacora = 8;
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
               // InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
                BenInvestigado = true;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && BenHackeado == false)
            {
               // InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
                BenHackeado = true;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && BenHackeado == true && BenDifamado == false)
            {
               // InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
                BenDifamado = true;
            }
        }


        //====================================================== Bitacoras Pie Grande =============================================//
        if (libreta.palabra == "Pie Grande")
        {
            //ELIMINAR 
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PieGrandeEliminado == false)
            {
               // InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Pie grande dio una buena pelea, perdimos un agente.";
                PieGrandeEliminado = true;
            }

            //Lavar Cerebro 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PieGrandeLavado == false && PieGrandeEliminado == false)
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "El amor de Pie Grande fue demasiado fuerte como para olvidar. Perdimos un agente";
                PieGrandeLavado = true;
            }
            //Investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && PieGrandeInvestigado == false)
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Pie grande dio una buena pelea, perdimos un agente.";
                PieGrandeInvestigado = true;
            }
            //Hackeado
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && PieGrandeHackeado == false)
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Pie grande dio una buena pelea, perdimos un agente.";
                PieGrandeHackeado = true;
                libreta.BtnRed78.gameObject.SetActive(true);
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PieGrandeDifamado == false)
            {
             //   InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Pie grande dio una buena pelea, perdimos un agente.";
                PieGrandeDifamado = true;
            }
        }
        //=========================================================== Bitacoras Parque Pimienta =================================================//
        if (libreta.palabra == "Parque Pimienta")
        {
            //Aislar
            if (A.aislar.CompareTag(tag = "OptActivado") && A.aislar.isOn == true && ParquePimientaAislado == false)
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Pie grande dio una buena pelea, perdimos un agente.";
                ParquePimientaAislado = true;
            }
            //Montar Escena
            if (A.crearEscena.CompareTag(tag = "OptActivado") && A.crearEscena.isOn == true && ParquePimientaEscena == false)
            {
             //   InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Pie grande dio una buena pelea, perdimos un agente.";
                ParquePimientaEscena = true;
            }
        }
        //========================================================== Bitacoras Pimienta Paluza ==================================================//
        if (libreta.palabra == "Pimienta Paluza")
        {
            //Montar escena
            if (A.crearEscena.CompareTag(tag = "OptActivado") && A.crearEscena.isOn == true && PimientaPaluzaEscena == false)
            {
             //   InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Pie grande dio una buena pelea, perdimos un agente.";
                PimientaPaluzaEscena = true;
            }
        }
        //========================================================= Bitacoras Colorada ==========================================================//
        if (libreta.palabra == "Colorada")
        {
            //Investigar 
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && ColoradaInvestigada == false)
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Pie grande dio una buena pelea, perdimos un agente.";
                ColoradaInvestigada = true;
            }
        }
        //======================================================= Bitacoras Red78 ==============================================================//
        if (libreta.palabra == "Red78")
        {
            //Investigar 
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && Red78Investigada == false)
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Pie grande dio una buena pelea, perdimos un agente.";
                Red78Investigada = true;
                libreta.BtnKateMilliard.gameObject.SetActive(true);
            }
        }
        //===================================================== Bitacoras Kate Milliard ======================================================//
        if (libreta.palabra == "Kate Milliard")
        {
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && KateEliminada == false)
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Ben a sido eliminado exitosamente";
                KateEliminada = true;
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && KateEliminada == false && KateLavada == false)
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
                KateLavada = true;
            }
            // investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && KateInvestigada == false)
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
                KateInvestigada = true;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && KateHackeada == false)
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
                KateHackeada = true;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && KateDifamada == false)
            {
             //   InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
                KateDifamada = true;
            }
        }
        //================================================== Bitacoras Pepe Queño =========================================//
        if (libreta.palabra == "Pepe Queño")
        {
            //Eliminar
            if (A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PepeEliminado == false )
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Ben a sido eliminado exitosamente";
                PepeEliminado = true;
            }
            //LAVAR CEREBRO 
            if (A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PepeEliminado == false && PepeLavado == false)
            {
               // InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
                PepeLavado = true;
            }
            // investigar
            if (A.investigar.CompareTag(tag = "OptActivado") && A.investigar.isOn == true && PepeInvestigado == false)
            {
             //   InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
                PepeInvestigado = true;
            }
            //Hackear
            if (A.hackear.CompareTag(tag = "OptActivado") && A.hackear.isOn == true && PepeHackeado == false)
            {
             //   InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
                PepeHackeado = true;
            }
            //Difamar
            if (A.difamar.CompareTag(tag = "OptActivado") && A.difamar.isOn == true && PepeDifamado== false)
            {
              //  InstanciarBitacoras();
                prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
                PepeDifamado = true;
            }
        }
        //================================================= Bitacoras Cabellos Rojizos ==========================================================//
        if (libreta.palabra == "Cabellos rojizos" )
        {
            //Analizar muestra
            if (A.analizarMuestra.CompareTag(tag = "OptActivado") && A.analizarMuestra.isOn == true && CabellosRojijosAnalizado == false)
            {
                float RetencionTiempo = TimeManager.Hora + 12f;
                float CalculoTiempo =  RetencionTiempo*60 / 1;
               
               
                CabellosRojijosAnalizado = true;
            }

        }
        A.Restablecer();
    }

    IEnumerator GuardarBitacora(float ReinicioTiempo, string txt, TMP_Text TextoPrefab)
    {
        yield return new WaitForSeconds(ReinicioTiempo);
        TextoPrefab.text = txt;
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
