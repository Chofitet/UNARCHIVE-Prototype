using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Libreta : MonoBehaviour
{
    
    public TMP_Dropdown Palabras;    
    public int palabra = -1;

    
    public void PalabraSeleccionada ()
    {
        palabra = Palabras.value;
        
    }

    // funcion para agregar opciones: optEliminar.options.Add(new TMP_Dropdown.OptionData() { text = "Kate Millard" });

}
