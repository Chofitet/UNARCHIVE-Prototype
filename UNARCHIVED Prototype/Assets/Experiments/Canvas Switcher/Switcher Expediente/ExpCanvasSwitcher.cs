using UnityEngine;
using UnityEngine.UI;

public class ExpCanvasSwitcher : MonoBehaviour
{
    public CanvasTypeExp desiredCanvasType;
    public CanvasTypeExp desiredCanvasType2;

    public GameObject Carpeta;
    public ExpCanvasManager canvasManager;
    Button menuButton;
    [SerializeField] Bitacoras bitacoras;

    void OnMouseDown()
    {
        Carpeta.gameObject.SetActive(true);
       if(bitacoras.BitacoraCargada == true)
        {
            canvasManager.SwitchCanvas(desiredCanvasType, desiredCanvasType2);
        }
        else canvasManager.SwitchCanvas(CanvasTypeExp.Acciones, CanvasTypeExp.Acciones);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            Carpeta.gameObject.SetActive(false);
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
