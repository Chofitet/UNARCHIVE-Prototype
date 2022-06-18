using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Expediente : MonoBehaviour
{
    public bool CasoLeido;
    [SerializeField] TimeManager time;
    void OnMouseDown ()
    {
        time.TiempoNormal();
        CasoLeido = true;
    }

}
