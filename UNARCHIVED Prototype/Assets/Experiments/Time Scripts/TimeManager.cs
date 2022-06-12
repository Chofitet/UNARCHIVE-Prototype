using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Telefono telefono;
    [SerializeField] PantallasSwitcherManager Pantallas;
    [SerializeField] Acciones A;
    public static Action CambioMinutos;
    public static Action CambioHoras;
    public int Dia ;
    public bool NoticiaDiaria;
    public float VariacionDeTiempo;
    bool x;

    public static int Minuto { get; private set; }
    public static int Hora { get; private set; }

    private float MinutosPorSegundosReales = 2.2f ;
    public float MinutosXseg; 
    private float timer;
    private float TiempoAlternativo  ;
    private float TiempoAlAcelerar;
    private float TiempoAlNormalizar;


    void Start()
    {
        Dia = 3;
        Minuto = 0;
        Hora = 6;
        timer = MinutosPorSegundosReales;
        MinutosXseg = MinutosPorSegundosReales;
    }

    void Update()
    {
        if (Input.GetKey("escape")) Application.Quit();
       
        TiempoAlternativo += Time.deltaTime * VariacionDeTiempo ;
        timer -= Time.deltaTime * VariacionDeTiempo;
        if (timer <= 0)
        {
            Minuto++;
            CambioMinutos?.Invoke();
            if(Minuto >= 60)
            {
                Hora++;
                Minuto = 0;
                CambioHoras?.Invoke(); 
            }
            timer = MinutosPorSegundosReales;
        }

        if (Dia == 7 && Hora == 17 && Minuto > 58) FinJuego();
    }

    private void OnEnable()
    {
        CambioHoras += PasoDelDía;
    }
    private void OnDisable()
    {
        CambioHoras -= PasoDelDía;
    }

    void PasoDelDía ()
    {
        if(Hora == 18)
        {
            telefono.LLamadaDiaria = false;
            NoticiaDiaria = false;
            Dia++;
            Hora = 6;
        }
    }

    public void TiempoAcelerado ()
    {
        if (x == false) { VariacionDeTiempo = 60f; x = true; }
        else {VariacionDeTiempo = 1; x = false;}
        TiempoAlAcelerar = TiempoAlternativo;
        
    }

    public void TiempoNormal ()
    {
        VariacionDeTiempo = 1;
        x = false;
        TiempoAlNormalizar = TiempoAlternativo;
    }

    void FinJuego ()
    {
        Pantallas.SwitchCanvas(CanvasTypePantallas.FinJuego, CanvasTypePantallas.FinJuego);
    }

   public IEnumerator RetencionBitacorasSegunAccion (float retencion)
    {
       float TiempoActual = TiempoAlternativo;
       float CalculoTiempoNormal = retencion + TiempoActual;
       float TiempoRetención = CalculoTiempoNormal;

        while (TiempoRetención >= TiempoAlternativo)
        {
            Debug.Log(TiempoRetención);
            Debug.Log(TiempoAlternativo);
            yield return null;
        }
    }



}
