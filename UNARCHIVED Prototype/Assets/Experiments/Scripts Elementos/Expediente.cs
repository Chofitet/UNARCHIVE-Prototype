using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Expediente : MonoBehaviour
{
    [SerializeField] SonidoMagnament Sonido;
    public bool CasoLeido;
    private bool PantallaExp = true;

    void OnMouseDown ()
    {
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
    }

}
