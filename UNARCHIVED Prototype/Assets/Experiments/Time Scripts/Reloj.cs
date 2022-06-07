using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reloj : MonoBehaviour
{
    [SerializeField] TimeManager time;
   
    public TMP_Text Fecha;
    public TMP_Text reloj;

    private void Update()
    {
        switch (time.Dia)
        {
            case 3:
                
                Fecha.text = "2" + time.Dia + "/03/2000";
                
                break;
            case 4:
               
                Fecha.text = "2" + time.Dia + "/03/2000";
                break;
            case 5:
             
                Fecha.text = "2" + time.Dia + "/03/2000";
                break;
            case 6:
              
                Fecha.text = "2" + time.Dia + "/03/2000";
                break;
            case 7:
                
                Fecha.text = "2" + time.Dia + "/03/2000";
                break;
            case 8:
                
                Fecha.text = "2" + time.Dia + "/03/2000";
                break;
        }
    }

    private void OnEnable()
    {
        TimeManager.CambioMinutos += ActualizarTiempo;
        TimeManager.CambioHoras += ActualizarTiempo;
    }
    private void OnDisable()
    {
        TimeManager.CambioMinutos -= ActualizarTiempo;
        TimeManager.CambioHoras -= ActualizarTiempo;
    }

    private void ActualizarTiempo ()
    {
        reloj.text = $"{TimeManager.Hora:00}:{TimeManager.Minuto:00}";
    }

    private void OnMouseDown()
    {
        time.TiempoAcelerado();
    }
}
