using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Expediente : MonoBehaviour
{
    [SerializeField] SonidoMagnament Sonido;
    public bool CasoLeido;

    void OnMouseDown ()
    {
        CasoLeido = true;
        Sonido.SonidoAbrirExpediente();
    }

}
