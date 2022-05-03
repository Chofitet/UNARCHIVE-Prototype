using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Acciones : MonoBehaviour
{
    public NarrativeManagement NM;
    
    public optEliminarScript optEliminarScript;
    public TMP_Dropdown optEliminar;
    private int opcion = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
        optEliminarScript = GetComponent<optEliminarScript>();
    }
    private void Update()
    {
   
    }

    public void Aceptar()
    {
        opcion = optEliminar.value;
        if (opcion == 0)
        {
            NM.Ben = 1;
            Debug.Log("Ben eliminado");
        }
        if (opcion == 1)
        {
            NM.PieGrande = 1;
            Debug.Log("Pie Grande eliminado");
        }
    }

}
