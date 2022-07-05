using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Expediente : MonoBehaviour
{
    public bool CasoLeido;
    [SerializeField] TimeManager time;
    [SerializeField] Bitacoras bitacoras;
    public GameObject libreta;
    void OnMouseDown()
    {
        time.TiempoNormal();
        CasoLeido = true;

        if (bitacoras.BitacoraCargada == false)
        {
            libreta.SetActive(true);
            
        } 
        else { libreta.SetActive(false); bitacoras.BitacoraCargada = false; }
    }

}
