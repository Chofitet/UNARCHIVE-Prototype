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
            canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
            libreta.gameObject.SetActive(false);
        }
        Libreta.PalabraSeleccionada = false;
        Acciones.AccionSelccionada = false;
    }

    


   
}


