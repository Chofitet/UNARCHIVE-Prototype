using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCCanvasSwitcher : MonoBehaviour
{
    public CanvasTypePC desiredCanvasType;
    public CanvasTypePC desiredCanvasType2;

    public PCCanvasManager canvasManager;
 

    void OnMouseDown()
    {
          canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
    
    }
}
