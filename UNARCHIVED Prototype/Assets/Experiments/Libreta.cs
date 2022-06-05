using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Libreta : MonoBehaviour
{

    [SerializeField] Expediente ex;
    [SerializeField] Bitacoras bitacoras;
    bool apagado;
    public string palabra;
    public GameObject BtnBen;
    public GameObject BtnPieGrande;
    public GameObject BtnPuebloPimienta;
    public GameObject BtnPimientaPaluza;
    public GameObject BtnColorada;
    public GameObject BtnRed78;
    public GameObject BtnKateMilliard;
    public GameObject BtnPepeQue�o;
    public GameObject BtnPelosRojizos;
    public GameObject BtnParquePimienta;
    public GameObject BtnPimientapaluzers;
    public GameObject BtnWifiRobado;
    public GameObject BtnBananorrama;

    public string SignoPreguntaPieGrande = "?";
    public string SignoPreguntaPepeQue�o = "?";
    public string[] palabrasCaso = new string[13];

    public TMP_Text txtBen;
    public TMP_Text txtPieGrande;
    public TMP_Text txtParquePimienta;
    public TMP_Text txtPimientaPaluza;
    public TMP_Text txtColorada;
    public TMP_Text txtRed78;
    public TMP_Text txtKate;
    public TMP_Text txtPepeQue�o;
    public TMP_Text txtCabellosRojizos;
    public TMP_Text txtPuebloPimienta;
    public TMP_Text txtPimientapaluzers;
    public TMP_Text txtWifiRobado;
    public TMP_Text txtBananorrama;
   

    private void Start()
    {
        BtnBen.gameObject.SetActive(false);
        BtnPieGrande.gameObject.SetActive(false);
        BtnParquePimienta.gameObject.SetActive(false);
        BtnPimientaPaluza.gameObject.SetActive(false);
        BtnColorada.gameObject.SetActive(false);
        BtnRed78.gameObject.SetActive(false);
        BtnKateMilliard.gameObject.SetActive(false);
        BtnPepeQue�o.gameObject.SetActive(false);
        BtnPelosRojizos.gameObject.SetActive(false);
        BtnPimientapaluzers.gameObject.SetActive(false);
        BtnWifiRobado.gameObject.SetActive(false);
        BtnPuebloPimienta.gameObject.SetActive(false);
        BtnBananorrama.gameObject.SetActive(false);

        palabrasCaso[0] = "Ben Benji";
        palabrasCaso[1] = "Pie Grande";
        palabrasCaso[2] = "Kate Milliard";
        palabrasCaso[3] = "Pimientapaluza";
        palabrasCaso[4] = "Bananorrama";
        palabrasCaso[5] = "Pueblo Pimienta";
        palabrasCaso[6] = "colorada";
        palabrasCaso[7] = "Red78";
        palabrasCaso[8] = "Pepe Que�o";
        palabrasCaso[9] = "cabellos rojizos";
        palabrasCaso[10] = "Parque Pimienta";
        palabrasCaso[11] = "pimientapaluzers";
        palabrasCaso[12] = "wifi robado";

        SignoPreguntaPieGrande = "?";
        SignoPreguntaPepeQue�o = "?";
    }

    private void Update ()
    {
        if (ex.CasoLeido == true && apagado == false)
        {
            BtnBen.gameObject.SetActive(true);
            BtnPieGrande.gameObject.SetActive(true);
            BtnPuebloPimienta.gameObject.SetActive(true);
            BtnColorada.gameObject.SetActive(true);
            ex.CasoLeido = false;
            apagado = true;
        }



    }
   
    public void Kate()
    {
        DesSubrayar();
        palabra = palabrasCaso[2];
        txtKate.text = "<u>Kate Milliard<u>";
    }

    public void Ben ()
    {
        DesSubrayar();
        palabra = palabrasCaso[0];
        txtBen.text = "<u>Ben Benji</u>";
    }

    public void PieGrande ()
    {
        DesSubrayar();
        palabra = palabrasCaso[1];
        txtPieGrande.text = "<u>Pie Grande</u>" + SignoPreguntaPieGrande;
    }
    public void PimientaPaluza()
    {
        DesSubrayar();
        palabra = palabrasCaso[3];
        txtPimientaPaluza.text = "<u>Pimientapaluza</u>";
    }
    public void PuebloPimienta()
    {
        DesSubrayar();
        palabra = palabrasCaso[5];
        txtPuebloPimienta.text = "<u>Pueblo Pimienta</u>";
    }
    public void Colorada()
    {
        DesSubrayar();
        palabra = palabrasCaso[6];
        txtColorada.text = "<u>colorada?</u>";
    }
    public void Red78()
    {
        DesSubrayar();
        palabra = palabrasCaso[7];
        txtRed78.text = "<u>Red78?</u>";
    }
    public void PepeQue�o()
    {
        DesSubrayar();
        palabra = palabrasCaso[8];
        txtPepeQue�o.text = "<u>Pepe Que�o</u>" + SignoPreguntaPepeQue�o;
    }
    public void CabellosRojizos()
    {
        DesSubrayar();
        palabra = palabrasCaso[9];
        txtCabellosRojizos.text = "<u>cabellos rojizos</u>";
    }
    public void Bananorrama()
    {
        DesSubrayar();
        palabra = palabrasCaso[4];
        txtBananorrama.text = "<u>Bananorrama?</u>";
    }
    public void ParquePimienta()
    {
        DesSubrayar();
        palabra = palabrasCaso[10];
        txtParquePimienta.text = "<u>Parque Pimienta<u>";
    }
    public void Pimientapaluzers()
    {
        DesSubrayar();
        palabra = palabrasCaso[11];
        txtPimientapaluzers.text = "<u>pimientapaluzers<u>";
    }
    public void WifiRobado()
    {
        DesSubrayar();
        palabra = palabrasCaso[12];
        txtWifiRobado.text = "<u>wifi robado<u>";
    }

    public void DesSubrayar()
    {
        if(txtBen.text == "<u>Ben Benji</u>") { txtBen.text = palabrasCaso[0]; }
        else if (txtPieGrande.text == "<u>Pie Grande</u>" + SignoPreguntaPieGrande) { txtPieGrande.text = palabrasCaso[1] + SignoPreguntaPieGrande; }
        else if (txtPimientaPaluza.text == "<u>Pimientapaluza</u>") { txtPimientaPaluza.text = palabrasCaso[3]; }
        else if (txtPuebloPimienta.text == "<u>Pueblo Pimienta</u>") { txtPuebloPimienta.text = palabrasCaso[5]; }
        else if (txtBananorrama.text == "<u>Bananorrama?<u>") { txtBananorrama.text = palabrasCaso[4] + "?";}
        else if (txtColorada.text == "<u>colorada?</u>") { txtColorada.text = palabrasCaso[6] + "?"; }
        else if (txtPepeQue�o.text == "<u>Pepe Que�o</u>" + SignoPreguntaPepeQue�o) { txtPepeQue�o.text = palabrasCaso[8] + SignoPreguntaPepeQue�o; }
        else if (txtCabellosRojizos.text == "<u>cabellos rojizos</u>") { txtCabellosRojizos.text = palabrasCaso[9]; }
        else if (txtRed78.text == "<u>Red78?</u>") { txtRed78.text = palabrasCaso[7] + "?"; }
        else if (txtKate.text == "<u>Kate Milliard<u>") { txtKate.text = palabrasCaso[2]; }
        else if (txtParquePimienta.text == "<u>Parque Pimienta<u>") { txtParquePimienta.text = palabrasCaso[10]; }
        else if (txtPimientapaluzers.text == "<u>pimientapaluzers<u>") { txtPimientapaluzers.text = palabrasCaso[11]; }
        else if (txtWifiRobado.text == "<u>wifi robado<u>") { txtWifiRobado.text = palabrasCaso[12]; }

    }

    public void PersonajeEliminado()
    {
        if (bitacoras.BenEliminado == true) BtnBen.gameObject.SetActive(false);
        if (bitacoras.PieGrandeEliminado) BtnPieGrande.gameObject.SetActive(false);
        if (bitacoras.KateEliminada) BtnKateMilliard.gameObject.SetActive(false);
        if (bitacoras.PepeEliminado)BtnPepeQue�o.gameObject.SetActive(false);
    }

   public void ActualizarPalabras()
    {
        if (bitacoras.PieGrandeHackeado == true) {BtnRed78.gameObject.SetActive(true); }
        if (bitacoras.Red78Investigada == true || bitacoras.Red78Hackeada == true) {BtnKateMilliard.gameObject.SetActive(true); }
        if (bitacoras.CabellosRojijosAnalizado == true) BtnKateMilliard.gameObject.SetActive(true);
        if (bitacoras.PieGrandeInvestigado == true) { BtnPelosRojizos.gameObject.SetActive(true); }
        if (bitacoras.ParquePimientaHackeado == true && bitacoras.PieGrandeUbicacion == false) {BtnWifiRobado.gameObject.SetActive(true);}
        if (bitacoras.PuebloPimientaInvestigado == true) {BtnParquePimienta.gameObject.SetActive(true); }
        if (bitacoras.ParquePimientaInvestigado == true) { BtnPuebloPimienta.gameObject.SetActive(false); }
        if (bitacoras.CrearEscena == true) {BtnPepeQue�o.gameObject.SetActive(true); }
        if (bitacoras.PepeInvestigado == true || bitacoras.PepeAnalizado == true) {SignoPreguntaPepeQue�o = ""; PepeQue�o(); }
        if (bitacoras.PieGrandeUbicacion == true) BtnPuebloPimienta.SetActive(false);
        if (bitacoras.PieGrandeLavado == true) BtnBananorrama.SetActive(true);

        if (bitacoras.CabellosRojijosAnalizado == true || bitacoras.Red78Hackeada == true || bitacoras.Red78Investigada == true)
        {
            BtnColorada.gameObject.SetActive(false);
            BtnPelosRojizos.gameObject.SetActive(false);
            BtnRed78.gameObject.SetActive(false);
            BtnBananorrama.gameObject.SetActive(false);

        }

    }

    public void SetearPalabraLibretaACero ()
    {
        palabra = "";
    }


}
