using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVCanvasSwither : MonoBehaviour
{
    public CanvasTypeTV desiredCanvasType;
    public CanvasTypeTV desiredCanvasType2;

    public TVCanvasManager canvasManager;

    void OnMouseDown()
    {
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
     
    }
}
