using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitcherApagarLibreta : MonoBehaviour
{
    public GameObject Libreta;
   
    private void OnMouseDown()
    {
        Libreta.SetActive(false);
    }
 


}
