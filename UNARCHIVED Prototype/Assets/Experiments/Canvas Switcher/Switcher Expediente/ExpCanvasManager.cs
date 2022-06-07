using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum CanvasTypeExp
{
   Expediente,
   ExpedienteDef,
   Bitacoras,
   Acciones,
   Libreta,
}

public class ExpCanvasManager : MonoBehaviour
{
    List<ExpController> canvasControllerList;
    public ExpController lastActiveCanvas;
    ExpController lastActiveCanvas2;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            SwitchCanvas(CanvasTypeExp.ExpedienteDef, CanvasTypeExp.ExpedienteDef);
        }
    }

    void Start()

    {
        canvasControllerList = GetComponentsInChildren<ExpController>().ToList();
        canvasControllerList.ForEach(x => x.gameObject.SetActive(false));
        SwitchCanvas(CanvasTypeExp.ExpedienteDef, CanvasTypeExp.ExpedienteDef);
    }

    public void SwitchCanvas(CanvasTypeExp _type, CanvasTypeExp _type2)
    {
        if (lastActiveCanvas != null)
        {
            lastActiveCanvas.gameObject.SetActive(false);
        }

        if (lastActiveCanvas2 != null)
        {
            lastActiveCanvas2.gameObject.SetActive(false);
        }

        ExpController desiredCanvas = canvasControllerList.Find(x => x.canvasTypeExp == _type);
        ExpController desiredCanvas2 = canvasControllerList.Find(x => x.canvasTypeExp == _type2);
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