using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AlarmaTelefono : MonoBehaviour
{
    Renderer Luz;
    private void Start()
    {
        Luz = GetComponent<Renderer>();
        Apagado();
    }

    public void Apagado ()
    {
        Luz.material.SetFloat("_Encendido", 0);
    }
    public void Titilando ()
    {
        Luz.material.SetFloat("_Speed", 10);
        Luz.material.SetFloat("_Encendido", 1);
    }

    public void Encendido ()
    {
        Luz.material.SetFloat("_Encendido", 1);
        Luz.material.SetFloat("_Speed", 0);
        //Luz.material.SetColor("_BaseColor", Color.HSVToRGB(0.45f,0.75f,1));
    }

    
}
