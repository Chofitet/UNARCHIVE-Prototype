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
    [SerializeField] SonidosManagement Sonido;


    void OnMouseDown()
    {
        time.TiempoNormal();
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
        Sonido.SonidoPasarHoja();
    }


    private void Start()
    {
       Boton = GetComponent<GameObject>();
        Sonido = FindObjectOfType<SonidosManagement>();
    }
}
