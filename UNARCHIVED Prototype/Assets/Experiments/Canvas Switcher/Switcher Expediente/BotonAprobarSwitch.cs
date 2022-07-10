using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonAprobarSwitch : MonoBehaviour
{
    public CanvasTypeExp desiredCanvasType;
    public CanvasTypeExp desiredCanvasType2;

    public GameObject libreta;
    public ToggleGroup acciones;
    public ExpCanvasManager canvasManager;
    Button boton;
   public GameObject AprobadoSello;
    private void Update()
    {
        Debug.Log("accion" + Acciones.AccionSelccionada);
        Debug.Log("palabra" + Libreta.PalabraSeleccionada);

    }
    private void Start()
    {
        boton = GetComponent<Button>();

        boton.onClick.AddListener(OnButtonClicked);
    }

    void OnButtonClicked()
    {
        ComprobarAccionPulsada();
    }

    void ComprobarAccionPulsada()
    {
        if (Acciones.AccionSelccionada == true && Libreta.PalabraSeleccionada == true) 
        {
            StartCoroutine(SelloAprobar());
        }
        Libreta.PalabraSeleccionada = false;
        Acciones.AccionSelccionada = false;
    }

    IEnumerator  SelloAprobar ()
    {
        AprobadoSello.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
        libreta.gameObject.SetActive(false);
        AprobadoSello.gameObject.SetActive(false);
    }

    


   
}


