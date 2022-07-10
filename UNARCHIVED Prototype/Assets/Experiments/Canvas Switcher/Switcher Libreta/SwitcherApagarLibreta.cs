using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitcherApagarLibreta : MonoBehaviour
{
    public GameObject Libreta;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClicked);
    }
    private void OnMouseDown()
    {
        Libreta.SetActive(false);
    }

    void OnButtonClicked()
    {
        Libreta.SetActive(false);
    }
   


}
