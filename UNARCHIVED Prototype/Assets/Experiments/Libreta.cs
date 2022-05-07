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

    private bool SubrayadoBen;
    private bool SubrayadoPieGrande;
    private bool SubrayadoParquePimienta;
    private bool SubrayadoPimientaPaluza;
    private bool SubrayadoColorada;
    private bool SubrayadoRed78;
    private bool SubrayadoKateMilliard;
    private bool SubrayadoPepeQueño;
    private bool SubrayadoPelosRojizos;


    public TMP_Text txtBen;

    
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
        palabra = "Kate Milliard";
       
    }

    public void Ben ()
    {
        palabra = "Ben Benji";
        SubrayadoBen = true;
        
    }

    public void PieGrande ()
    {
        palabra = "Pie Grande";
        SubrayadoBen = false;
    }
    public void PimientaPaluza()
    {
        palabra = "Pimienta Paluza";
    }
    public void ParquePimienta()
    {
        palabra = "Parque Pimienta";
    }
    public void Colorada()
    {
        palabra = "Colorada";
    }
    public void Red78()
    {
        palabra = "Red78";
    }
    public void PepeQueño()
    {
        palabra = "Pepe Queño";
    }
    public void CabellosRojizos()
    {
        palabra = "Cabellos rojizos";
    }

    void Subrayar (TMP_Text text, bool Subrayado)
    {
        if (Subrayado == false)
        {
            txtBen.fontStyle = FontStyles.Underline;
           
        } else { text.fontStyle ^= FontStyles.Underline; }
    }

}
