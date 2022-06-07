using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelefonoCamara : MonoBehaviour
{
    public bool telefonoCamara;
    private void OnMouseDown()
    {
        telefonoCamara = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1) == true)
        {
            telefonoCamara = false;
        }
    }

}
