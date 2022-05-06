using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PC : MonoBehaviour
{
    [SerializeField] internal Libreta libreta;
    public TMP_Text txtBuscador;

    public void MostrarPalabraBuscador()
    {
       txtBuscador.text = "   " + libreta.Palabras.options[libreta.Palabras.value].text; 
        
    }

}
