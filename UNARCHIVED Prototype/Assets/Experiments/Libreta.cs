using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Libreta : MonoBehaviour
{

    [SerializeField] Expediente ex;
    bool apagado;
    public string palabra;
    public GameObject BtnBen;
    public GameObject BtnPieGrande;
    public GameObject BtnPuebloPimienta;
    public GameObject BtnPimientaPaluza;
    public GameObject BtnColorada;
    public GameObject BtnRed78;
    public GameObject BtnKateMilliard;
    public GameObject BtnPepeQueño;
    public GameObject BtnPelosRojizos;
    public GameObject BtnParquePimienta;
    public GameObject BtnPimientapaluzers;
    public GameObject BtnWifiRobado;

    public string SignoPregunta = "(?)";
    public string[] palabrasCaso = new string[13];

    public TMP_Text txtBen;
    public TMP_Text txtPieGrande;
    public TMP_Text txtParquePimienta;
    public TMP_Text txtPimientaPaluza;
    public TMP_Text txtColorada;
    public TMP_Text txtRed78;
    public TMP_Text txtKate;
    public TMP_Text txtPepeQueño;
    public TMP_Text txtCabellosRojizos;
    public TMP_Text txtPuebloPimienta;
    public TMP_Text txtPimientapaluzers;
    public TMP_Text txtWifiRobado;

    private void Start()
    {
        BtnBen.gameObject.SetActive(false);
        BtnPieGrande.gameObject.SetActive(false);
        BtnParquePimienta.gameObject.SetActive(false);
        BtnPimientaPaluza.gameObject.SetActive(false);
        BtnColorada.gameObject.SetActive(false);
        BtnRed78.gameObject.SetActive(false);
        BtnKateMilliard.gameObject.SetActive(false);
        BtnPepeQueño.gameObject.SetActive(false);
        BtnPelosRojizos.gameObject.SetActive(false);
        BtnPimientapaluzers.gameObject.SetActive(false);
        BtnWifiRobado.gameObject.SetActive(false);
        BtnPuebloPimienta.gameObject.SetActive(false);

        palabrasCaso[0] = "Ben Benji";
        palabrasCaso[1] = "Pie Grande";
        palabrasCaso[2] = "Kate Milliard";
        palabrasCaso[3] = "Pimienta Paluza";
        palabrasCaso[5] = "Pueblo Pimienta";
        palabrasCaso[6] = "Colorada";
        palabrasCaso[7] = "Red78";
        palabrasCaso[8] = "Pepe Queño";
        palabrasCaso[9] = "Cabellos rojizos";
        palabrasCaso[10] = "Parque Pimienta";
        palabrasCaso[11] = "Pimientapaluzers";
        palabrasCaso[12] = "Wifi Robado";
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
        txtKate.text = "<u>Kate Milliar<u>";
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
        txtPieGrande.text = "<u>Pie Grande</u>" + SignoPregunta;
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
        txtColorada.text = "<u>Colorada (?)</u>";
    }
    public void Red78()
    {
        DesSubrayar();
        palabra = palabrasCaso[7];
        txtRed78.text = "<u>Red78 (?)</u>";
    }
    public void PepeQueño()
    {
        DesSubrayar();
        palabra = palabrasCaso[8];
        txtPepeQueño.text = "<u>Pepe Queño</u>";
    }
    public void CabellosRojizos()
    {
        DesSubrayar();
        palabra = palabrasCaso[9];
        txtCabellosRojizos.text = "<u>Cabellos Rojizos</u>";
    }
    public void ParquePimienta()
    {
        DesSubrayar();
        palabra = palabrasCaso[10];
        txtParquePimienta.text = "<u>Parque Pimienta</u>";
    }
    public void Pimientapaluzers()
    {
        DesSubrayar();
        palabra = palabrasCaso[11];
        txtPimientapaluzers.text = "<u>Pimientapaluzers<u>";
    }
    public void WifiRobado()
    {
        DesSubrayar();
        palabra = palabrasCaso[12];
        txtWifiRobado.text = "<u>Wifi robado<u>";
    }

    void DesSubrayar()
    {
        if(txtBen.text == "<u>Ben Benji</u>") { txtBen.text = palabrasCaso[0]; }
        else if (txtPieGrande.text == "<u>Pie Grande</u>" + SignoPregunta) { txtPieGrande.text = palabrasCaso[1] + SignoPregunta; }
        else if (txtPimientaPaluza.text == "<u>Pimientapaluza</u>") { txtPimientaPaluza.text = palabrasCaso[3]; }
        else if (txtPuebloPimienta.text == "<u>Pueblo Pimienta</u>") { txtPuebloPimienta.text = palabrasCaso[5]; }
        else if (txtColorada.text == "<u>Colorada (?)</u>") { txtColorada.text = palabrasCaso[6] + " (?)"; }
        else if (txtPepeQueño.text == "<u>Pepe Queño</u>") { txtPepeQueño.text = palabrasCaso[8]; }
        else if (txtCabellosRojizos.text == "<u>Cabellos Rojizos</u>") { txtCabellosRojizos.text = palabrasCaso[9]; }
        else if (txtRed78.text == "<u>Red78 (?)</u>") { txtRed78.text = palabrasCaso[7] + " (?)"; }
        else if (txtKate.text == "<u>Kate Milliar<u>") { txtKate.text = palabrasCaso[2]; }
        else if (txtParquePimienta.text == "<u>Parque Pimienta<u>") { txtParquePimienta.text = palabrasCaso[10]; }
        else if (txtPimientapaluzers.text == "<u>Pimientapaluzers<u>") { txtPimientapaluzers.text = palabrasCaso[11]; }
        else if (txtWifiRobado.text == "<u>Wifi robado<u>") { txtWifiRobado.text = palabrasCaso[12]; }

    }


}
