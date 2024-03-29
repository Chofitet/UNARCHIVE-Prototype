using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Acciones : MonoBehaviour
{
    [SerializeField] internal Libreta libreta;
    [SerializeField] internal Bitacoras bitacoras;
    [SerializeField] TV tv;
    [SerializeField] Telefono Pinchofono;
    static public bool AccionSelccionada { get; set; }
    public ToggleGroup acciones;
    public Toggle eliminar;
    public Toggle lavarCerebro;
    public Toggle investigar;
    public Toggle hackear;
    public Toggle difamar;
    public Toggle aislar;
    public Toggle crearNoticia;
    public Toggle crearEscena;
    public Toggle analizarMuestra;
    public Toggle plantarPublico;
    public Toggle trueEnding;
    public Toggle convertirCueva;
    public Toggle extraerFotos;
    public Toggle ofrecerProteccion;
    public Toggle levantarCerca;

    public GameObject tglEliminar;
    public GameObject tglLavar;
    public GameObject tglCrearEscena;
    public GameObject tglPlantarPublico;
    public GameObject tglTrueEnding;
    public GameObject tglAislar;
    public GameObject tglConvertirCueva;
    public GameObject tglExtraerFotos;
    public GameObject tglOfrecerprotecci�n;
    public GameObject tglLevantarCerca;

    public TMP_Text txtEliminar;
    public TMP_Text txtLavarCerebro;
    public TMP_Text txtInvestigar;
    public TMP_Text txtHackear;
    public TMP_Text txtDifamar;
    public TMP_Text txtAislar;
    public TMP_Text txtCrearNoticia;
    public TMP_Text txtCrearEscena;
    public TMP_Text txtAnalizarMuestra;

    private void Update()
    {
        if (bitacoras.PieGrandeUbicacion == true && crearEscena.isOn == false) {tglCrearEscena.SetActive(true); }
        if (bitacoras.PieGrandeUbicacion == true && tglLevantarCerca.activeSelf == false) { tglAislar.SetActive(true); }
        if (tv.BenEntrevista2 == true) tglPlantarPublico.SetActive(false);
       
        
        if (extraerFotos.isOn == false && tv.BenEntrevista2 == false && Pinchofono.BenLlamado==true && bitacoras.ExtraerFoto == false) { tglExtraerFotos.SetActive(true); }

        
    }
    ///////////////////////////////////////////////////////
    

    public  void CompletarPalabra ()
    {   // (de a ac�)
        if (eliminar.isOn == true) { txtEliminar.text = libreta.palabra; }
        else { txtEliminar.text = ""; }

        if (lavarCerebro.isOn == true) { txtLavarCerebro.text = libreta.palabra; }
        else { txtLavarCerebro.text = ""; }

        if (investigar.isOn == true) { txtInvestigar.text = libreta.palabra; }
        else { txtInvestigar.text = ""; }

        if (hackear.isOn == true) { txtHackear.text = libreta.palabra; }
        else { txtHackear.text = ""; }

        if (difamar.isOn == true) { txtDifamar.text = libreta.palabra; }
        else { txtDifamar.text = ""; }

        if (aislar.isOn == true) { txtAislar.text = libreta.palabra; }
        else { txtAislar.text = ""; }

        if (crearNoticia.isOn == true) { txtCrearNoticia.text = ""; }
        else { txtCrearNoticia.text = ""; }

        if (crearEscena.isOn == true) { txtCrearEscena.text = ""; }
        else { txtCrearEscena.text = ""; }

        if (analizarMuestra.isOn == true) { txtAnalizarMuestra.text = libreta.palabra; }
        else { txtAnalizarMuestra.text = ""; }
        
        //(hasta ac�) rellenan las palabras al lado de las acciones
    }
    //Funcion llamada cada vez que se apreta el boton aprobar, aplica las acciones
    public void Eliminar(bool action)
    {
        if (action) { eliminar.tag = "OptActivado";  }
        CompletarPalabra();
        AccionSelccionada = true;

    }
    public void LavarCerebro(bool action)
    {
        if (action){ lavarCerebro.tag = "OptActivado"; }
        CompletarPalabra();
        AccionSelccionada = true;
    }
    public void Investigar(bool action)
    {
        if (action){ investigar.tag = "OptActivado"; }
        CompletarPalabra();
        AccionSelccionada = true;
    }
    public void Hackear(bool action)
    {
        if (action){ hackear.tag = "OptActivado";}
        CompletarPalabra();
        AccionSelccionada = true;
    }
    public void Difamar(bool action)
    {
        if (action) {difamar.tag = "OptActivado";}
        CompletarPalabra();
        AccionSelccionada = true;
    }
    public void Aislar(bool action)
    {
        if (action){ aislar.tag = "OptActivado";}
        CompletarPalabra();
        AccionSelccionada = true;
    }
    public void MontarEscena(bool action)
    {
        if (action){crearEscena.tag = "OptActivado";}
        CompletarPalabra();
        libreta.palabra = "";
        Libreta.PalabraSeleccionada = true;
        AccionSelccionada = true;
        libreta.DesSubrayar();
    }
    public void CrearnoticiaFalsa(bool action)
    {
        if (action){ crearNoticia.tag = "OptActivado"; }
        AccionSelccionada = true;
        libreta.palabra = "";
        Libreta.PalabraSeleccionada = true;
        libreta.DesSubrayar();
    }
    public void AnalizarMuestra (bool action)
    {
        if (action) { analizarMuestra.tag = "OptActivado"; }
        CompletarPalabra();
        AccionSelccionada = true;

    }
    public void PlantarPublico(bool action)
    {
        if (action) { plantarPublico.tag = "OptActivado"; }
        CompletarPalabra();
        AccionSelccionada = true;
        libreta.palabra = "";
        Libreta.PalabraSeleccionada = true;
        libreta.DesSubrayar();
    }
    public void TrueEnding(bool action)
    {
        if (action) { trueEnding.tag = "OptActivado"; }
        CompletarPalabra();
        AccionSelccionada = true;
        libreta.palabra = "";
        Libreta.PalabraSeleccionada = true;
        libreta.DesSubrayar();
    }
    public void ConvertirCueva(bool action)
    {
        if (action) { convertirCueva.tag = "OptActivado"; }
        AccionSelccionada = true;
        libreta.palabra = "";
        Libreta.PalabraSeleccionada = true;
        libreta.DesSubrayar();
    }
    public void ExtraerFotos(bool action)
    {
        if (action) { extraerFotos.tag = "OptActivado"; }
        AccionSelccionada = true;
        libreta.palabra = "";
        Libreta.PalabraSeleccionada = true;
        libreta.DesSubrayar();
    }
    public void OfrecerProteccion(bool action)
    {
        if (action) { ofrecerProteccion.tag = "OptActivado"; }
        AccionSelccionada = true;
        libreta.palabra = "";
        Libreta.PalabraSeleccionada = true;
        libreta.DesSubrayar();
    }
    public void LevantarCerca(bool action)
    {
        if (action) { levantarCerca.tag = "OptActivado"; }
        AccionSelccionada = true;
        libreta.palabra = "";
        Libreta.PalabraSeleccionada = true;
        libreta.DesSubrayar();
    }


    //Se activa con el boton aprobar, descelecciona y destagu� los toggles de las acciones
    public void Restablecer()
    {
        eliminar.tag = "OptDesactivado";
        lavarCerebro.tag = "OptDesactivado";
        investigar.tag = "OptDesactivado";
        hackear.tag = "OptDesactivado";
        difamar.tag = "OptDesactivado";
        aislar.tag = "OptDesactivado";
        crearNoticia.tag = "OptDesactivado";
      
        eliminar.isOn = false;
        lavarCerebro.isOn = false;
        investigar.isOn = false;
        hackear.isOn = false;
        difamar.isOn = false;
        aislar.isOn = false;
        crearNoticia.isOn = false;
        analizarMuestra.isOn = false;

        //crearEscena.isOn = false;
        plantarPublico.isOn = false;
        trueEnding.isOn =false;
        ofrecerProteccion.isOn = false;
        //extraerFotos.isOn = false;
        convertirCueva.isOn = false;
        levantarCerca.isOn = false;

    }
    public void DeshabilitarAcciones()
    {
       
        if (bitacoras.PieGrandeEliminado == true) tglEliminar.SetActive(false);
        if (bitacoras.PieGrandeLavado == true) tglLavar.SetActive(false);
    }

    public void DeshabilidarAccionesInstantadea ()
    {
        if (crearEscena.isOn == true) tglCrearEscena.SetActive(false);
        if (plantarPublico.isOn == true) tglPlantarPublico.SetActive(false);
        if (trueEnding.isOn == true) tglTrueEnding.SetActive(false);
        if (ofrecerProteccion.isOn == true) tglOfrecerprotecci�n.SetActive(false);
        if (extraerFotos.isOn == true) tglExtraerFotos.SetActive(false);
        if (convertirCueva.isOn == true && bitacoras.ConvertirCueva == true) tglConvertirCueva.SetActive(false);
    }

}
