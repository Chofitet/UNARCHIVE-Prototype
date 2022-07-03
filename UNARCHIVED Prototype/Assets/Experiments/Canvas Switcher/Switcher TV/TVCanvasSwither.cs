using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVCanvasSwither : MonoBehaviour
{
    [SerializeField] TimeManager time;
    public CanvasTypeTV desiredCanvasType;
    public CanvasTypeTV desiredCanvasType2;
    public bool TvClickeada;

    public TVCanvasManager canvasManager;

    void OnMouseDown()
    {
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
        time.TiempoNormal();
        TvClickeada = true;
    }
}
