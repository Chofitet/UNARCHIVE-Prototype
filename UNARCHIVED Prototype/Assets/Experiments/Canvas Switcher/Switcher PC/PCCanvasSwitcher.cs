using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCCanvasSwitcher : MonoBehaviour
{
    [SerializeField] TimeManager time;
    public CanvasTypePC desiredCanvasType;
    public CanvasTypePC desiredCanvasType2;

    public PCCanvasManager canvasManager;
    
 

    void OnMouseDown()
    {
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
        time.TiempoNormal(); 
    }
}
