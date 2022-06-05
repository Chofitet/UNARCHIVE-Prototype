using UnityEngine;
using UnityEngine.UI;

public class ExpCanvasSwitcher : MonoBehaviour
{
    public CanvasTypeExp desiredCanvasType;
    public CanvasTypeExp desiredCanvasType2;

    public GameObject Carpeta;
    public GameObject CarpetaAbierta;
    public ExpCanvasManager canvasManager;
    Button menuButton;


    void OnMouseDown()
    {
       
        canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
        Carpeta.gameObject.SetActive(false);

       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            Carpeta.gameObject.SetActive(true);
        }
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
