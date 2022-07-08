using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum CanvasTypeTV
{
    TV,
    TVDef,
}


public class TVCanvasManager : MonoBehaviour
{
    List<TVCanvasController> canvasControllerList;
    public TVCanvasController lastActiveCanvas;
    TVCanvasController lastActiveCanvas2;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) == true && PasoDeDia.PantallaDia == false)
        {
            SwitchCanvas(CanvasTypeTV.TVDef, CanvasTypeTV.TVDef);
        }
    }

    void Start()

    {
        canvasControllerList = GetComponentsInChildren<TVCanvasController>().ToList();
        canvasControllerList.ForEach(x => x.gameObject.SetActive(false));
        SwitchCanvas(CanvasTypeTV.TVDef, CanvasTypeTV.TVDef);
    }

    public void SwitchCanvas(CanvasTypeTV _type, CanvasTypeTV _type2)
    {
        if (lastActiveCanvas != null)
        {
            lastActiveCanvas.gameObject.SetActive(false);
        }

        if (lastActiveCanvas2 != null)
        {
            lastActiveCanvas2.gameObject.SetActive(false);
        }

        TVCanvasController desiredCanvas = canvasControllerList.Find(x => x.canvasTypeTV == _type);
        TVCanvasController desiredCanvas2 = canvasControllerList.Find(x => x.canvasTypeTV == _type2);
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
