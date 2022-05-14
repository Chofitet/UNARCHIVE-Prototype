using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Telefono telefono;
    public static Action CambioMinutos;
    public static Action CambioHoras;
    public int Dia ;
    
    public static int Minuto { get; private set; }
    public static int Hora { get; private set; }

    private float MinutosPorSegundosReales = 0.1f;
    public float MinutosXseg; 
    private float timer;

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
            telefono.PapelFax.gameObject.SetActive(false);
            Dia++;
            Hora = 6;
        }
    }

}
