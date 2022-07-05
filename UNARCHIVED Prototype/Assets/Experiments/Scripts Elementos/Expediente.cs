using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Expediente : MonoBehaviour
{
    [SerializeField] SonidoMagnament Sonido;
    public bool CasoLeido;

    private bool PantallaExp = true;

    [SerializeField] TimeManager time;
    [SerializeField] Bitacoras bitacoras;
    public GameObject libreta;
    void OnMouseDown()
    {
        time.TiempoNormal();
        CasoLeido = true;
        Sonido.SonidoAbrirExpediente();
        PantallaExp = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            if(PantallaExp == true)
            {
                Sonido.SonidoCerrarExpediente();
          
            }
            PantallaExp = false;
        }

        if (bitacoras.BitacoraCargada == false)
        {
            libreta.SetActive(true);
            
        } 
        else { libreta.SetActive(false); bitacoras.BitacoraCargada = false; }
    }

}
