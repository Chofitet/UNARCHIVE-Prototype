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
    public GameObject BtnParquePimienta;
    public GameObject BtnPimientaPaluza;
    public GameObject BtnColorada;
    public GameObject BtnRed78;
    public GameObject BtnKateMilliard;
    public GameObject BtnPepeQueño;
    public GameObject BtnPelosRojizos;

    public TMP_Text txtBen;
    public TMP_Text txtPieGrande;
    public TMP_Text txtParquePimienta;
    public TMP_Text txtPimientaPaluza;
    public TMP_Text txtColorada;
    public TMP_Text txtRed78;
    public TMP_Text txtKate;
    public TMP_Text txtPepeQueño;
    public TMP_Text txtCabellosRojizos;

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

    }

    private void Update ()
    {
        if (ex.CasoLeido == true && apagado == false)
        {
            BtnBen.gameObject.SetActive(true);
            BtnPieGrande.gameObject.SetActive(true);
            BtnParquePimienta.gameObject.SetActive(true);
            BtnColorada.gameObject.SetActive(true);
            BtnPimientaPaluza.gameObject.SetActive(true);
            ex.CasoLeido = false;
            apagado = true;
        }
    }
   
    public void Kate()
    {
        DesSubrayar();
        palabra = "Kate Milliard";
        txtKate.text = "<u>Kate Milliar<u>";
    }

    public void Ben ()
    {
        DesSubrayar();
        palabra = "Ben Benji";
        txtBen.text = "<u>Ben Benji</u>";
    }

    public void PieGrande ()
    {
        DesSubrayar();
        palabra = "Pie Grande";
        txtPieGrande.text = "<u>Pie Grande</u>";
    }
    public void PimientaPaluza()
    {
        DesSubrayar();
        palabra = "Pimienta Paluza";
        txtPimientaPaluza.text = "<u>Pimienta paluza</u>";
    }
    public void ParquePimienta()
    {
        DesSubrayar();
        palabra = "Parque Pimienta";
        txtParquePimienta.text = "<u>Parque Pimienta</u>";
    }
    public void Colorada()
    {
        DesSubrayar();
        palabra = "Colorada";
        txtColorada.text = "<u>Colorada (?)</u>";
    }
    public void Red78()
    {
        DesSubrayar();
        palabra = "Red78";
        txtRed78.text = "<u>Red78 (?)</u>";
    }
    public void PepeQueño()
    {
        DesSubrayar();
        palabra = "Pepe Queño";
        txtPepeQueño.text = "<u>Pepe Queño</u>";
    }
    public void CabellosRojizos()
    {
        DesSubrayar();
        palabra = "Cabellos rojizos";
        txtCabellosRojizos.text = "<u>Cabellos Rojizos</u>";
    }

    void DesSubrayar()
    {
        if(txtBen.text == "<u>Ben Benji</u>") { txtBen.text = "Ben Benji"; }
        else if (txtPieGrande.text == "<u>Pie Grande</u>") { txtPieGrande.text = "Pie Grande"; }
        else if (txtPimientaPaluza.text == "<u>Pimienta paluza</u>") { txtPimientaPaluza.text = "Pimienta paluza"; }
        else if (txtParquePimienta.text == "<u>Parque Pimienta</u>") { txtParquePimienta.text = "Parque Pimienta"; }
        else if (txtColorada.text == "<u>Colorada (?)</u>") { txtColorada.text = "Colorada (?)"; }
        else if (txtPepeQueño.text == "<u>Pepe Queño</u>") { txtPepeQueño.text = "Pepe Queño"; }
        else if (txtCabellosRojizos.text == "<u>Cabellos Rojizos</u>") { txtCabellosRojizos.text = "Cabellos Rojizos"; }
        else if (txtRed78.text == "<u>Red78 (?)</u>") { txtRed78.text = "Red78 (?)"; }
        else if (txtKate.text == "<u>Kate Milliar<u>") { txtKate.text = "Kate Milliar"; }

    }


}
