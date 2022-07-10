using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum CanvasTypePantallas
{
    Tuto,
    Juego,
    RatingMaximo,
    FinJuego,
    TrueEnding,
}
public class PantallasSwitcherManager : MonoBehaviour
{
    List<PantallasSwitcherController> canvasControllerList;
    PantallasSwitcherController lastActiveCanvas;
    PantallasSwitcherController lastActiveCanvas2;
    [SerializeField] TimeManager time;
    static public bool TutoActivo { get; set; }

    void Start()
    {
        canvasControllerList = GetComponentsInChildren<PantallasSwitcherController>().ToList();
        canvasControllerList.ForEach(x => x.gameObject.SetActive(false));
        SwitchCanvas(CanvasTypePantallas.Tuto, CanvasTypePantallas.Tuto);
    }

    public void SwitchCanvas(CanvasTypePantallas _type, CanvasTypePantallas _type2)
    {
        if (lastActiveCanvas != null)
        {
            lastActiveCanvas.gameObject.SetActive(false);
        }

        if (lastActiveCanvas2 != null)
        {
            lastActiveCanvas2.gameObject.SetActive(false);
        }

        PantallasSwitcherController desiredCanvas = canvasControllerList.Find(x => x.canvasTypePantallas == _type);
        PantallasSwitcherController desiredCanvas2 = canvasControllerList.Find(x => x.canvasTypePantallas == _type2);
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

        time.TiempoPausado();

        DeshabilitarClickDerecho(desiredCanvas);

    }

    void DeshabilitarClickDerecho(PantallasSwitcherController canvas)
    {
        PantallasSwitcherController Tuto = canvasControllerList.Find(x => x.canvasTypePantallas == CanvasTypePantallas.Tuto);
        if (canvas == Tuto)
        {
            TutoActivo = true;
        }
        else TutoActivo = false;
    }

    }

