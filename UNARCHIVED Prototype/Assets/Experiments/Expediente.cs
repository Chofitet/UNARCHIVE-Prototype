using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Expediente : MonoBehaviour
{
    public bool CasoLeido;
    public GameObject expediente;
 public void ExpedienteLeido()
    {
        CasoLeido = true;
    }

public void MostrarExpediente ()
    {

        if (expediente.activeSelf == false)
        {
            expediente.gameObject.SetActive(true);
        }
        else { expediente.gameObject.SetActive(false); }

    }

}
