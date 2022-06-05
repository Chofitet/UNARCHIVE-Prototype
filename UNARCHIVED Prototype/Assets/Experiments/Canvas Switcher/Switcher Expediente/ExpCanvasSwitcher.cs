using UnityEngine;
using UnityEngine.UI;

public class ExpCanvasSwitcher : MonoBehaviour
{
    public CanvasTypeExp desiredCanvasType;
    public CanvasTypeExp desiredCanvasType2;

    public ExpCanvasManager canvasManager;
    Button menuButton;

    void OnMouseDown()
    {
       
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
       
    }
    


    private void Start()
    {
        menuButton = GetComponent<Button>();
        menuButton.onClick.AddListener(OnButtonClicked);

    }

    void OnButtonClicked()
    {

        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
    }
}
