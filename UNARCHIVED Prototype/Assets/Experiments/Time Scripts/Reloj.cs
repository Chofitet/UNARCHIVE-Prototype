using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reloj : MonoBehaviour
{
    public TMP_Text reloj;

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
}
