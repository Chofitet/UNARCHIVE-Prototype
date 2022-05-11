using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{
    public static Action CambioMinutos;
    public static Action CambioHoras;
    public int Dia;
    
    public static int Minuto { get; private set; }
    public static int Hora { get; private set; }

    private float MinutosPorSegundosReales = 0.1f;
    private float timer;

    void Start()
    {
        Minuto = 0;
        Hora = 6;
        timer = MinutosPorSegundosReales;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
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
    }

    private void OnEnable()
    {
        CambioHoras += PasoDelD�a;
    }
    private void OnDisable()
    {
        CambioHoras -= PasoDelD�a;
    }

    void PasoDelD�a ()
    {
        if(Hora == 18)
        {
            Dia++;
            Hora = 6;
        }
    }

}
