using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCCanvasSwitcher : MonoBehaviour
{
    [SerializeField] TimeManager time;
    [SerializeField] SonidosManagement Sonidos;
    public CanvasTypePC desiredCanvasType;
    public CanvasTypePC desiredCanvasType2;
    bool PCPantalla;
    
    public PCCanvasManager canvasManager;

    private void Start()
    {
        Sonidos = FindObjectOfType<SonidosManagement>();
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) == true) { PCPantalla = false; }
    }

    void OnMouseDown()
    {
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
        time.TiempoNormal();

            PCPantalla = true;
    }

    public void SonidoTeclado()
    {
        if (PCPantalla == true)
        {
            Sonidos.SonidodeTeclado();
        }
    }
}
