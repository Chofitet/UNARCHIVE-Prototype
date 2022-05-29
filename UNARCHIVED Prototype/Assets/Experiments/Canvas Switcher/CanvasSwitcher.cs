using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CanvasSwitcher : MonoBehaviour
{
    public CanvasType desiredCanvasType;
    public CanvasType desiredCanvasType2;


    public CanvasManager canvasManager;
    Button menuButton;
    

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

