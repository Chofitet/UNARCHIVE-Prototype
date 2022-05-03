using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bitacoras : MonoBehaviour
{
    public NarrativeManagement NM;
    public TMP_Text b1;
   

    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ActualizarBitacoras ()
    {
        
        if (NM.Ben == 1)
        {
            b1.text = "Ben a sido eliminado exitosamente";
        }
        if (NM.PieGrande == 1)
        {
            b1.text = "Pie Grade dio pelea, perdimos un agente";
        }
    }
}


