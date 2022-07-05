using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCanvasSwitcher : MonoBehaviour
{
    public CanvasTypeExp desiredCanvasType;
    public CanvasTypeExp desiredCanvasType2;

    GameObject Boton;
    public ExpCanvasManager canvasManager;
    [SerializeField] TimeManager time;
    [SerializeField] SonidoMagnament Sonido;



    void OnMouseDown()
    {
        Sonido.SonidoPasarHoja();
        time.TiempoNormal();
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            canvasManager.SwitchCanvas(CanvasTypeExp.ExpedienteDef, CanvasTypeExp.ExpedienteDef);
        }
    }

    private void Start()
    {
       Boton = GetComponent<GameObject>();

    }
}
