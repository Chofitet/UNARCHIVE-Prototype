using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bitacoras : MonoBehaviour
{
    //Referencias Scripts
    [SerializeField] internal Libreta libreta;
    [SerializeField] internal Acciones A;
    //Referencias de propiedades
    GameObject PadreAux;
    public Canvas Canvas;
    public TMP_Text BitacoraPrefab;
    private TMP_Text prefabAux;
    public Transform InicioBitacora;
    //Declaración varariables
    private float y;
    private int i = 0;
    private bool BenEliminado;
    private bool BenLavado;
    private bool PieGrandeEliminado;
    private bool PieGrandeLavado;



    private void Start()
    {
        y = InicioBitacora.transform.position.y;
      
    }
    
    // Analiza las variables: ¿que nombre de la libreta està seleccionada?, ¿què acciòn està elegida? y si otra o esa misma accion fue ejecutada para evitar incongruencias o bitacoras repetidas.
    // Si se cumplen las condiciones, imprimen la bitàcora correspondiente
    public void ActualizarBitacoras()
    {
       //eLIMINAR BEN
       if (libreta.palabra == 1 && A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && BenEliminado == false)
        {
            InstanciarBitacoras();
            prefabAux.GetComponent<TMP_Text>().text = "Ben a sido eliminado exitosamente";
           
            BenEliminado = true;

        }
       //ELIMINAR PIE GRANDE
         if (libreta.palabra == 2 && A.eliminar.CompareTag(tag = "OptActivado") && A.eliminar.isOn == true && PieGrandeEliminado == false)
         {
            InstanciarBitacoras();
            prefabAux.GetComponent<TMP_Text>().text = "Pie grande dio una buena pelea, perdimos un agente.";
            libreta.agregarKate();
            
            PieGrandeEliminado = true;
         }
         //LAVAR CEREBRO 
         if (libreta.palabra == 1 && A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && BenLavado == false && BenEliminado == false)
         {
            InstanciarBitacoras();
            prefabAux.GetComponent<TMP_Text>().text = "Borramos con éxito la memoria de Ben";
             
            BenLavado = true;
         }
         if (libreta.palabra == 2 && A.lavarCerebro.CompareTag(tag = "OptActivado") && A.lavarCerebro.isOn == true && PieGrandeLavado == false)
         {
            InstanciarBitacoras();
            prefabAux.GetComponent<TMP_Text>().text = "El amor de Pie Grande fue demasiado fuerte como para olvidar. Perdimos un agente";
            PieGrandeLavado = true;
             
         }
        /*if (libreta.palabra == 1 && A.lavarCerebro.CompareTag(tag = "OptActivado") )
        {
            InstanciarBitacoras();
            prefabAux.GetComponent<TMP_Text>().text = "Lavado de cerebro a Kate Milliard exitoso, las sospechas se mantienen";
            

        }*/


        A.Restablecer();

    }

    //Crea los espacios para rellenar las bitàcoras y los borra cuando es debido
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
