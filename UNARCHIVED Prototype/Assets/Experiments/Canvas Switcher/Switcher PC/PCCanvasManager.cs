using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum CanvasTypePC
{
    PC,
    PCDef,
}

public class PCCanvasManager : MonoBehaviour
{
    List<PCCanvasController> canvasControllerList;
    public PCCanvasController lastActiveCanvas;
    PCCanvasController lastActiveCanvas2;


    private void Update()
    {
        if (PC.Rating >= 16)
        {
            SwitchCanvas(CanvasTypePC.PCDef, CanvasTypePC.PCDef);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) == true && PasoDeDia.PantallaDia == false)
        {
            SwitchCanvas(CanvasTypePC.PCDef, CanvasTypePC.PCDef);

        }
    }

    void Start()

    {
        canvasControllerList = GetComponentsInChildren<PCCanvasController>().ToList();
        canvasControllerList.ForEach(x => x.gameObject.SetActive(false));
        SwitchCanvas(CanvasTypePC.PCDef, CanvasTypePC.PCDef);
    }

    public void SwitchCanvas(CanvasTypePC _type, CanvasTypePC _type2)
    {
        if (lastActiveCanvas != null)
        {
            lastActiveCanvas.gameObject.SetActive(false);
        }

        if (lastActiveCanvas2 != null)
        {
            lastActiveCanvas2.gameObject.SetActive(false);
        }

        PCCanvasController desiredCanvas = canvasControllerList.Find(x => x.canvasTypePC == _type);
        PCCanvasController desiredCanvas2 = canvasControllerList.Find(x => x.canvasTypePC == _type2);
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
