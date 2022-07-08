using UnityEngine;
using UnityEngine.UI;

public class PantallasSwitcher : MonoBehaviour
{
    public CanvasTypePantallas desiredCanvasType;
    public CanvasTypePantallas desiredCanvasType2;

    [SerializeField] PasoDeDia pasoDeDia;
    public PantallasSwitcherManager canvasManager;
    Button menuButton;

    private void Start()
    {
        menuButton = GetComponent<Button>();
        menuButton.onClick.AddListener(OnButtonClicked);
    }

    void OnButtonClicked()
    {
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
        pasoDeDia.PasoDia();
    }
}
