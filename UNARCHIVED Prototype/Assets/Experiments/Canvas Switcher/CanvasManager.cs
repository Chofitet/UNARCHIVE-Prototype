using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum CanvasType
{
    Escritorio,
    Expediente,
    Bitacoras,
    Acciones,
    PC,
    Telefono,
    Libreta,
    TV,
}

public class CanvasManager : MonoBehaviour
{
    List<CanvasController> canvasControllerList;
    CanvasController lastActiveCanvas;
    CanvasController lastActiveCanvas2;
    public CanvasType Escritorio;

    private void Update()
    {
            if (Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            SwitchCanvas(Escritorio, Escritorio);
        }
    }

    void Start()

    {
        canvasControllerList = GetComponentsInChildren<CanvasController>().ToList();
        canvasControllerList.ForEach(x => x.gameObject.SetActive(false));
        SwitchCanvas(CanvasType.Escritorio, CanvasType.Escritorio);
    }

    public void SwitchCanvas(CanvasType _type, CanvasType _type2)
    {
        if (lastActiveCanvas != null)
        {
            lastActiveCanvas.gameObject.SetActive(false);
        }

        if (lastActiveCanvas2 != null)
        {
            lastActiveCanvas2.gameObject.SetActive(false);
        }

        CanvasController desiredCanvas = canvasControllerList.Find(x => x.canvasType == _type);
        CanvasController desiredCanvas2 = canvasControllerList.Find(x => x.canvasType == _type2);
        if (desiredCanvas != null)
        {
            desiredCanvas.gameObject.SetActive(true);
            lastActiveCanvas = desiredCanvas;
        }
        else { Debug.LogWarning("The desired canvas was not found!"); }
        if (desiredCanvas2 != null)
        {
            desiredCanvas2.gameObject.SetActive(true);
            lastActiveCanvas2 = desiredCanvas2;
        }
        else { Debug.LogWarning("The desired canvas was not found!"); }
    }
}

