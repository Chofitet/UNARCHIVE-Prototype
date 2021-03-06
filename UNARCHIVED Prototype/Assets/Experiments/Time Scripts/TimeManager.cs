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
    [SerializeField] MovimientoVolumesTiempo efecto;
    public static Action CambioMinutos;
    public static Action CambioHoras;
    public bool NoticiaDiaria;
    public float VariacionDeTiempo = 50;
    bool x;

    public static int Dia { get; private set; }

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
        Debug.Log(Dia);
    }

    void Update()
    {
        

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
            telefono.LlamadaDiariaBen = false;
            telefono.LlamadaDiariaKate = false;
            telefono.LlamadaDiariaPepe = false;
            telefono.LlamadaDiariaPieGrande = false;
            NoticiaDiaria = false;
            Dia++;
            Hora = 6;
        }
    }

    public void TiempoAcelerado ()
    {
        if (x == false) 
        {
            efecto.ColocarEfectoTiempo();
            VariacionDeTiempo = 900f; 
            x = true; 
        }
        else { TiempoNormal(); }
    }

    public void TiempoNormal ()
    {
        efecto.QuitarEfectoTiempo();
        VariacionDeTiempo = 30;
        x = false;
        
    }

    public void TiempoPausado()
    {
        VariacionDeTiempo = 0;
    }

    void FinJuego ()
    {
        Pantallas.SwitchCanvas(CanvasTypePantallas.FinJuego, CanvasTypePantallas.FinJuego);
        TiempoPausado();
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
