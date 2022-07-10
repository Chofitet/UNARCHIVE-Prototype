using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelefonoCamara : MonoBehaviour
{
    [SerializeField] TimeManager time;
    public bool telefonoCamara;
    private void OnMouseDown()
    {
        time.TiempoNormal();
        telefonoCamara = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            telefonoCamara = false;
        }
        
            if (PC.Rating >= 16)
            {
            telefonoCamara = false;
            }
        
    }



}
