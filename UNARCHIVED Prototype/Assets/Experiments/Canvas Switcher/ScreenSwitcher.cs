using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ScreenSwitcher : MonoBehaviour
{
    public CanvasType desiredCanvasType;
    public CanvasType desiredCanvasType2;

    public CanvasManager canvasManager;
    public GameObject Escritorio;
   
    private void Update()
    {
       
    }

    void OnMouseDown()
    {
        if (Escritorio.activeSelf == true)
        {
            canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
        }
    }

}

