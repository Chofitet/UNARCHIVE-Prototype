using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Expediente : MonoBehaviour
{
    public bool CasoLeido;

    void OnMouseDown ()
    {
        Debug.Log("11");
        CasoLeido = true;
    }

}
