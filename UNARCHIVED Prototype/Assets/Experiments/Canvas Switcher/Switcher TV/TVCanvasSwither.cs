using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVCanvasSwither : MonoBehaviour
{
    [SerializeField] TimeManager time;
    [SerializeField] TV tv;
    public CanvasTypeTV desiredCanvasType;
    public CanvasTypeTV desiredCanvasType2;
    
    public TVCanvasManager canvasManager;

    void OnMouseDown()
    {
        Camaras.currentviewNum = 2;
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
        time.TiempoNormal();
        tv.PulsadoDeTV();
    }
}
