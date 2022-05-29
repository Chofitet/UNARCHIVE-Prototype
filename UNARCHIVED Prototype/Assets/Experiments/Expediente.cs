using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Expediente : MonoBehaviour
{
    public bool CasoLeido;
    public GameObject expediente;
    

    private void Update()
    {
        if(expediente.activeSelf == true) CasoLeido = true;

    }
   
}
