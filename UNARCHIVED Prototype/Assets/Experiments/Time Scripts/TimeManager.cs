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
    [SerializeField] SonidoMagnament Sonido;
    public static Action CambioMinutos;
    public static Action CambioHoras;
    public int Dia ;
    public bool NoticiaDiaria;
    public float VariacionDeTiempo = 50;
    bool x;

    public static int Minuto { get; private set;}
    public static int Hora { get; private set;}

    int Segundero = 1;
    private float TiempoAlternativo;

    void Start()
    {
        Dia = 3;
        Minuto = 0;
        Hora = 6;
        VariacionDeTiempo = 0;
    }

    void Update()
    {
        if (Input.GetKey("escape")) Application.Quit();

        Debug.Log(VariacionDeTiempo);
        TiempoAlternativo += Time.deltaTime * VariacionDeTiempo;
        if (TiempoAlternativo >= 60 * Segundero)
        {
            Minuto++;
            CambioMinutos?.Invoke();
            if(Minuto >= 60)
            {
                Hora++;
                Minuto = 0;
                CambioHoras?.Invoke(); 
            }
            Segundero++;
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
        if (x == false) { VariacionDeTiempo = 600f; x = true; Sonido.SonidoRelojRapido(); }
        else { TiempoNormal(); }
    }

    public void TiempoNormal ()
    {
        VariacionDeTiempo = 30;
        x = false;
        //Sonido.SonidoRelojNormal();

    }

    public void TiempoPausado()
    {
        VariacionDeTiempo = 0;
    }

    void FinJuego ()
    {
        Pantallas.SwitchCanvas(CanvasTypePantallas.FinJuego, CanvasTypePantallas.FinJuego);
    }

   public IEnumerator RetencionBitacorasSegunAccion (float retencion)
    {
       float TiempoActual = TiempoAlternativo;
       float CalculoTiempoNormal = (retencion*3600) + TiempoActual;
       float TiempoRetención = CalculoTiempoNormal;

        while (TiempoRetención >= TiempoAlternativo)
        {
            yield return null;
        }
    }



}
