using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public static bool EstadoPausa = false;
    public GameObject menu;
    
    void Update()
    {
        if (Input.GetKeyDown("escape")) 
        {
            if (EstadoPausa == true)
            {
                play();
            }
            else Pause();
        }
    }

    void Pause()
    {
        EstadoPausa = true;
        menu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void play()
    {
        EstadoPausa = false;
        menu.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }

}
