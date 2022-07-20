using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Libreta : MonoBehaviour
{

    [SerializeField] Expediente ex;
    [SerializeField] Bitacoras bitacoras;
    [SerializeField] Acciones A;
    [SerializeField] SonidosManagement Sonidos;
    static public bool PalabraSeleccionada { get;  set; }
    public GameObject ModeloLibreta;
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
    public GameObject BtnBananorrama;
    public TMP_Text lblCercar;

    public Button BenBtn;
    public Button PieGrandeBtn;
    public Button KateMilliardBtn;
    public Button PepeQuenioBtn;
    public Button ParquePimientaBtn;
    public Button PuebloPimientaBtn;
    public Button BananoramaBtn;
    public Button WifiRobadoBtn;
    public Button CabellosRojizosBtn;
    public Button Red78Btn;
    public Button PimientapaluzaBtn;
    public Button PimientapaluzersBtn;
    public Button ColoradaBtn;

    public string SignoPreguntaPieGrande = "?";
    public string SignoPreguntaPepeQueño = "?";
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
    public TMP_Text txtBananorrama;
    bool[] PalabrasTachadas = new bool[13];
    bool[] PalabrasNuevasSonido = new bool[13];

    bool x;
    bool LevantasCercaParquePimienta;
    bool LevantasCercaPimientapaluza;
    bool LevantarCercaPuebloPimienta;
    bool LevantasCercaParquePimienta2;
    bool LevantasCercaPimientapaluza2;
    bool LevantarCercaPuebloPimienta2;


    private void Start()
    {
        Sonidos = FindObjectOfType<SonidosManagement>();
        BtnParquePimienta.gameObject.SetActive(false);
        BtnPimientaPaluza.gameObject.SetActive(false);
        BtnRed78.gameObject.SetActive(false);
        BtnKateMilliard.gameObject.SetActive(false);
        BtnPepeQueño.gameObject.SetActive(false);
        BtnPelosRojizos.gameObject.SetActive(false);
        BtnPimientapaluzers.gameObject.SetActive(false);
        BtnWifiRobado.gameObject.SetActive(false);
        BtnBananorrama.gameObject.SetActive(false);

        palabrasCaso[0] = "Ben Benji";
        palabrasCaso[1] = "Pie Grande";
        palabrasCaso[2] = "Kate Milliard";
        palabrasCaso[3] = "Pimientapaluza";
        palabrasCaso[4] = "Bananorrama";
        palabrasCaso[5] = "Pueblo Pimienta";
        palabrasCaso[6] = "colorada";
        palabrasCaso[7] = "Red78";
        palabrasCaso[8] = "Pepe Quenio";
        palabrasCaso[9] = "cabellos rojizos";
        palabrasCaso[10] = "Parque Pimienta";
        palabrasCaso[11] = "pimientapaluzers";
        palabrasCaso[12] = "wifi robado";

        SignoPreguntaPieGrande = "?";
        SignoPreguntaPepeQueño = "?";
    }

    private void Update ()
    {

        if (ex.CasoLeido == true && x==false )
        {
            BtnBen.gameObject.SetActive(true);
            BtnPieGrande.gameObject.SetActive(true);
            BtnPuebloPimienta.gameObject.SetActive(true);
            BtnColorada.gameObject.SetActive(true);
            x = true;
        }
       
            if (PC.Rating >= 16)
            {
                ModeloLibreta.SetActive(false);
            }
      
    }
   
    public void Kate()
    {
        DesSubrayar();
        palabra = palabrasCaso[2];
        txtKate.text = "<u>Kate Milliard<u>";
        PalabraSeleccionada = true;
    }

    public void Ben ()
    {
        DesSubrayar();
        palabra = palabrasCaso[0];
        txtBen.text = "<u>Ben Benji</u>";
        PalabraSeleccionada = true;
    }

    public void PieGrande ()
    {
        DesSubrayar();
        palabra = palabrasCaso[1];
        txtPieGrande.text = "<u>Pie Grande</u>" + SignoPreguntaPieGrande;
        PalabraSeleccionada = true;
    }
    public void PimientaPaluza()
    {
        DesSubrayar();
        palabra = palabrasCaso[3];
        txtPimientaPaluza.text = "<u>Pimientapaluza</u>";
        PalabraSeleccionada = true;
    }
    public void PuebloPimienta()
    {
        DesSubrayar();
        palabra = palabrasCaso[5];
        txtPuebloPimienta.text = "<u>Pueblo Pimienta</u>";
        PalabraSeleccionada = true;
    }
    public void Colorada()
    {
        DesSubrayar();
        palabra = palabrasCaso[6];
        txtColorada.text = "<u>colorada?</u>";
        PalabraSeleccionada = true;
    }
    public void Red78()
    {
        DesSubrayar();
        palabra = palabrasCaso[7];
        txtRed78.text = "<u>Red78?</u>";
        PalabraSeleccionada = true;
    }
    public void PepeQueño()
    {
        DesSubrayar();
        palabra = palabrasCaso[8];
        txtPepeQueño.text = "<u>Pepe Quenio</u>" + SignoPreguntaPepeQueño;
        PalabraSeleccionada = true;
    }
    public void CabellosRojizos()
    {
        DesSubrayar();
        palabra = palabrasCaso[9];
        txtCabellosRojizos.text = "<u>cabellos rojizos</u>";
        PalabraSeleccionada = true;
    }
    public void Bananorrama()
    {
        DesSubrayar();
        palabra = palabrasCaso[4];
        txtBananorrama.text = "<u>Bananorrama?</u>";
        PalabraSeleccionada = true;
    }
    public void ParquePimienta()
    {
        DesSubrayar();
        palabra = palabrasCaso[10];
        txtParquePimienta.text = "<u>Parque Pimienta<u>";
        PalabraSeleccionada = true;
    }
    public void Pimientapaluzers()
    {
        DesSubrayar();
        palabra = palabrasCaso[11];
        txtPimientapaluzers.text = "<u>pimientapaluzers<u>";
        PalabraSeleccionada = true;
    }
    public void WifiRobado()
    {
        DesSubrayar();
        palabra = palabrasCaso[12];
        txtWifiRobado.text = "<u>wifi robado<u>";
        PalabraSeleccionada = true;
    }

    public void DesSubrayar()
    {
        if (txtBen.text == "<u>Ben Benji</u>") { txtBen.text = palabrasCaso[0]; }
        else if (txtPieGrande.text == "<u>Pie Grande</u>" + SignoPreguntaPieGrande) { txtPieGrande.text = palabrasCaso[1] + SignoPreguntaPieGrande; }
        else if (txtPimientaPaluza.text == "<u>Pimientapaluza</u>") { txtPimientaPaluza.text = palabrasCaso[3]; }
        else if (txtPuebloPimienta.text == "<u>Pueblo Pimienta</u>") { txtPuebloPimienta.text = palabrasCaso[5]; }
        else if (txtBananorrama.text == "<u>Bananorrama?</u>") { txtBananorrama.text = palabrasCaso[4] + "?"; }
        else if (txtColorada.text == "<u>colorada?</u>") { txtColorada.text = palabrasCaso[6] + "?"; }
        else if (txtPepeQueño.text == "<u>Pepe Quenio</u>" + SignoPreguntaPepeQueño) { txtPepeQueño.text = palabrasCaso[8] + SignoPreguntaPepeQueño; }
        else if (txtCabellosRojizos.text == "<u>cabellos rojizos</u>") { txtCabellosRojizos.text = palabrasCaso[9]; }
        else if (txtRed78.text == "<u>Red78?</u>") { txtRed78.text = palabrasCaso[7] + "?"; }
        else if (txtKate.text == "<u>Kate Milliard<u>") { txtKate.text = palabrasCaso[2]; }
        else if (txtParquePimienta.text == "<u>Parque Pimienta<u>") { txtParquePimienta.text = palabrasCaso[10]; }
        else if (txtPimientapaluzers.text == "<u>pimientapaluzers<u>") { txtPimientapaluzers.text = palabrasCaso[11]; }
        else if (txtWifiRobado.text == "<u>wifi robado<u>") { txtWifiRobado.text = palabrasCaso[12]; }
      
    }

    public void PersonajeEliminado()
    {
        if (bitacoras.BenEliminado) { TacharPalabra(BenBtn, txtBen, 0); }
        if (bitacoras.PieGrandeEliminado) { TacharPalabra(PieGrandeBtn, txtPieGrande, 1); }
        if (bitacoras.KateEliminada) { TacharPalabra(KateMilliardBtn, txtKate, 2); }
        if (bitacoras.PepeEliminado) { TacharPalabra(PepeQuenioBtn, txtPepeQueño, 8); }
    }

   public void ActualizarPalabras(Toggle accion)
    {
        if(accion == A.eliminar)
        {
            if (bitacoras.PieGrandeEliminado == true || bitacoras.PepeEliminado == true) A.tglTrueEnding.SetActive(false);
            if (A.convertirCueva.isOn == false && bitacoras.PieGrandeEliminado == true) { A.tglConvertirCueva.SetActive(true); }
        }
    
        if (accion == A.hackear)
        {
            if (bitacoras.PieGrandeHackeado == true) { EscribirNuevaPalabra(BtnRed78, 7); }
            if (bitacoras.ParquePimientaHackeado == true && bitacoras.PieGrandeUbicacion == false) { EscribirNuevaPalabra(BtnWifiRobado, 12); }
            if (bitacoras.Red78Investigada == true || bitacoras.Red78Hackeada == true) { EscribirNuevaPalabra(BtnKateMilliard, 2); }
            if (bitacoras.CabellosRojijosAnalizado == true || bitacoras.Red78Hackeada == true || bitacoras.Red78Investigada == true)
            {
                TacharPalabra(ColoradaBtn, txtColorada, 6);
                TacharPalabra(CabellosRojizosBtn, txtCabellosRojizos, 9);
                TacharPalabra(Red78Btn, txtRed78, 7);
                TacharPalabra(BananoramaBtn, txtBananorrama, 4);
            }
            if (bitacoras.PieGrandeEliminado == false && bitacoras.PepeEliminado == false && bitacoras.PepeAnalizado == true && bitacoras.PieGrandeUbicacion == true) A.tglTrueEnding.SetActive(true);
            if (SignoPreguntaPieGrande == "") TacharPalabra(WifiRobadoBtn,txtWifiRobado, 12);
        }
        if(accion == A.investigar)
        {
            if (bitacoras.Red78Investigada == true || bitacoras.Red78Hackeada == true) { EscribirNuevaPalabra(BtnKateMilliard, 2); }
            if (bitacoras.PieGrandeInvestigado == true) { EscribirNuevaPalabra(BtnPelosRojizos, 9); }
            if (bitacoras.PuebloPimientaInvestigado == true) { EscribirNuevaPalabra(BtnParquePimienta, 10); }
            if (bitacoras.ParquePimientaInvestigado == true) { TacharPalabra(PuebloPimientaBtn, txtPuebloPimienta, 5); }
            if (bitacoras.PepeInvestigado == true || bitacoras.PepeAnalizado == true) { SignoPreguntaPepeQueño = ""; PepeQueño(); }
            if (bitacoras.CabellosRojijosAnalizado == true || bitacoras.Red78Hackeada == true || bitacoras.Red78Investigada == true)
            {
                TacharPalabra(ColoradaBtn, txtColorada, 6);
                TacharPalabra(CabellosRojizosBtn, txtCabellosRojizos, 9);
                TacharPalabra(Red78Btn, txtRed78, 7);
                TacharPalabra(BananoramaBtn, txtBananorrama, 4);
            }
            if (bitacoras.PieGrandeEliminado == false && bitacoras.PepeEliminado == false && bitacoras.PepeAnalizado == true && bitacoras.PieGrandeUbicacion == true) A.tglTrueEnding.SetActive(true);
            if (SignoPreguntaPieGrande == "") TacharPalabra(WifiRobadoBtn, txtWifiRobado, 12);
        }
        if (accion == A.analizarMuestra)
        {
            if (bitacoras.CabellosRojijosAnalizado == true) { EscribirNuevaPalabra(BtnKateMilliard, 2); }
            if (bitacoras.CabellosRojijosAnalizado == true || bitacoras.Red78Hackeada == true || bitacoras.Red78Investigada == true)
            {
                TacharPalabra(ColoradaBtn, txtColorada, 6);
                TacharPalabra(CabellosRojizosBtn, txtCabellosRojizos, 9);
                TacharPalabra(Red78Btn, txtRed78, 7);
                TacharPalabra(BananoramaBtn, txtBananorrama, 4);
            }
            if (A.ofrecerProteccion.isOn == false && bitacoras.KateAnalizada == true && bitacoras.PieGrandeUbicacion == true && bitacoras.KateEliminada == false) { A.tglOfrecerprotección.SetActive(true); }

            if (bitacoras.PieGrandeEliminado == false && bitacoras.PepeEliminado == false && bitacoras.PepeAnalizado == true && bitacoras.PieGrandeUbicacion == true) A.tglTrueEnding.SetActive(true);
            
        }
        if (accion == A.lavarCerebro)
        {
            if (bitacoras.PieGrandeLavado == true) { EscribirNuevaPalabra(BtnBananorrama, 4); }
        }
        if (accion == A.crearEscena)
        {
            if (bitacoras.CrearEscena == true) { EscribirNuevaPalabra(BtnPepeQueño, 8); }
        } 
        if (accion == bitacoras.ReunirPadreEHijo)
        {
            if (A.convertirCueva.isOn == false && bitacoras.ReunirPadreEHijo == true) { A.tglConvertirCueva.SetActive(true); }
            
        }


        // Wip para cuando esten las bitacoras parte dos de los aislados, descomentar las condiciones y poner el nombre correcto de las variables.
        if (bitacoras.ObjetoCercable == true)
        {

            if (accion == A.aislar && bitacoras.ParquePimientaAislado == true && LevantasCercaParquePimienta == false)
            {
                A.tglAislar.gameObject.SetActive(false);
                A.tglLevantarCerca.gameObject.SetActive(true);
                lblCercar.text = palabrasCaso[10];
                LevantasCercaParquePimienta = true;
            }
            else if (accion == A.aislar && LevantasCercaParquePimienta2 == false /*&& bitacoras.ParquePimientaAislado2  */)
            {
                A.tglAislar.gameObject.SetActive(false);
                A.tglLevantarCerca.gameObject.SetActive(true);
                lblCercar.text = palabrasCaso[10];
                LevantasCercaParquePimienta2 = true;
            }
            else if (accion == A.aislar && bitacoras.PimientaPaluzaAislado == true && LevantasCercaPimientapaluza == false)
            {
                A.tglAislar.gameObject.SetActive(false);
                A.tglLevantarCerca.gameObject.SetActive(true);
                lblCercar.text = palabrasCaso[3];
                LevantasCercaPimientapaluza = true;
            }
            else if (accion == A.aislar && LevantasCercaPimientapaluza2 == false /*  && bitacoras.PimientapaluzaAislado2  */)
            {
                A.tglAislar.gameObject.SetActive(false);
                A.tglLevantarCerca.gameObject.SetActive(true);
                lblCercar.text = palabrasCaso[3];
                LevantasCercaPimientapaluza2 = true;
            }
            else if (accion == A.aislar && bitacoras.PuebloPimientaAislado == true && LevantarCercaPuebloPimienta == false)
            {
                A.tglAislar.gameObject.SetActive(false);
                A.tglLevantarCerca.gameObject.SetActive(true);
                lblCercar.text = palabrasCaso[5];
                LevantarCercaPuebloPimienta = true;
            }
            else if (accion == A.aislar && LevantarCercaPuebloPimienta2 == false /*  || bitacoras.PuebloPimientaAislado2   */)
            {
                A.tglAislar.gameObject.SetActive(false);
                A.tglLevantarCerca.gameObject.SetActive(true);
                lblCercar.text = palabrasCaso[5];
                LevantarCercaPuebloPimienta2 = true;
            }
            bitacoras.ObjetoCercable = false;

        }

        if (accion == A.levantarCerca)
        {
            A.tglAislar.gameObject.SetActive(true);
            A.tglLevantarCerca.gameObject.SetActive(false);
        }

    }

    public void SetearPalabraLibretaACero ()
    {
        palabra = "";
       
    }

    public void TacharPalabra (Button btn, TMP_Text txt, int i)
    {
        btn.interactable = false;
        txt.text = "<s>" + palabrasCaso[i] + "</s>";
        if (PalabrasTachadas[i] == false) { Sonidos.SonidodeTachar(); }
        PalabrasTachadas[i] = true;
    }

    public void EscribirNuevaPalabra (GameObject btn, int i)
    {
        btn.gameObject.SetActive(true);
        if (PalabrasNuevasSonido[i] == false) { Sonidos.SonidoEscribirPapel(); }
        PalabrasNuevasSonido[i] = true;
    }

}
