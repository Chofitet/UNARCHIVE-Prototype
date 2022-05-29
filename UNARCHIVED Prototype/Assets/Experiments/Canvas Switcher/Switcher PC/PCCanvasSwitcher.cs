using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCCanvasSwitcher : MonoBehaviour
{
    public CanvasTypePC desiredCanvasType;
    public CanvasTypePC desiredCanvasType2;

    public PCCanvasManager canvasManager;
    public GameObject Escritorio;

    void OnMouseDown()
    {
        if (Escritorio.activeSelf == true)
        {
            canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
        }
    }
}
