using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Expediente : MonoBehaviour
{
    public bool CasoLeido;
    public GameObject expediente;
    public GameObject Fondoexpediente;
    public GameObject btnExpediente;
    public TMP_Text TXT;
  

    private void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            MostrarExpediente();
        }
    }
    public void ExpedienteLeido()
    {
        CasoLeido = true;
    }

public void MostrarExpediente ()
    {

        if (expediente.activeSelf == false)
        {
            expediente.gameObject.SetActive(true);
            Fondoexpediente.gameObject.SetActive(true);
            btnExpediente.transform.position = new Vector3(800, 50, 0);
            TXT.text = "Volver";
            

        }
        else { expediente.gameObject.SetActive(false);
            Fondoexpediente.gameObject.SetActive(false);
            btnExpediente.transform.position = new Vector3(372, 500, 0);
            TXT.text = "Expediente";
        }

    }

    // 337.5 -212.3
}
