using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCCanvasSwitcher : MonoBehaviour
{
    public CanvasTypePC desiredCanvasType;
    public CanvasTypePC desiredCanvasType2;
    public bool PantallaPC;
    public PCCanvasManager canvasManager;
    
    void OnMouseDown()
    {
          canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
          PantallaPC = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            PantallaPC = false;

        }
    }
}
