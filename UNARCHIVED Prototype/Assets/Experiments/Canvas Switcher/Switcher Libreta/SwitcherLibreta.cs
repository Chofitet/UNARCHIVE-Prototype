using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherLibreta : MonoBehaviour
{
    public GameObject Libreta;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            Libreta.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
       Libreta.SetActive(true); 
    }
    
}
