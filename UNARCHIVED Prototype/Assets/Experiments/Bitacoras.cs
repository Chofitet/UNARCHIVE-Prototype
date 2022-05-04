using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bitacoras : MonoBehaviour
{
    [SerializeField] internal Libreta libreta;
    [SerializeField] internal Acciones A;
    GameObject PadreAux;
    public Canvas Canvas;
   
    public TMP_Text BitacoraPrefab;
    private TMP_Text prefabAux;
    
    private float y;
    public Transform InicioBitacora;
    private int i = 0;

    private void Start()
    {
        y = InicioBitacora.transform.position.y;
      
    }
    //
    public void ActualizarBitacoras()

    {
        InstanciarBitacoras();
        
       if (libreta.palabra == 1 && A.eliminar.CompareTag(tag = "OptActivado"))
        {
           prefabAux.GetComponent<TMP_Text>().text = "Ben a sido eliminado exitosamente";
            A.eliminar.isOn = false;
        }
         if (libreta.palabra == 2 && A.eliminar.CompareTag(tag = "OptActivado"))
         {
            prefabAux.GetComponent<TMP_Text>().text = "Pie grande dio una buena pelea, perdimos un agente.";
             A.eliminar.isOn = false;
         }
         if (libreta.palabra == 1 && A.lavarCerebro.CompareTag(tag = "OptActivado"))
         {
             prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
             A.lavarCerebro.isOn = false;
         }
         if (libreta.palabra == 2 && A.lavarCerebro.CompareTag(tag = "OptActivado"))
         {
             prefabAux.GetComponent<TMP_Text>().text = "El amor de Pie Grande fue demasiado fuerte como para olvidar. Perdimos un agente";
             A.lavarCerebro.isOn = false;
         }


        A.Restablecer();

    }

    void InstanciarBitacoras()
    {
        if (i > 4)
        {
            i = 0;
            y = InicioBitacora.transform.position.y;
            Destroy(PadreAux);

        }
        if (i == 0)
        {
            PadreAux = new GameObject("PadreBitacoras");
            PadreAux.transform.SetParent(Canvas.transform);
        }
        
        Transform aux = PadreAux.transform;
        prefabAux = Instantiate(BitacoraPrefab, new Vector3(InicioBitacora.transform.position.x, y, InicioBitacora.transform.position.z) , InicioBitacora.transform.rotation);
        prefabAux.transform.SetParent(aux.transform);
        
        y = y - 40;
        i = i + 1;
        
    }


}
