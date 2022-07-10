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
  


    void OnMouseDown()
    {
        time.TiempoNormal();
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
    }


    private void Start()
    {
       Boton = GetComponent<GameObject>();

    }
}
