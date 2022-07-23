using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmaPC : MonoBehaviour
{
    Renderer Luz;
    private void Start()
    {
        Luz = GetComponent<Renderer>();
    }

    public void LuzRatingSube()
    {
        Luz.material.SetColor("_BaseColor", Color.HSVToRGB(1, 1, 1));
        Luz.material.SetFloat("_Encendido", 1);
        Luz.material.SetFloat("_Speed", 0);
        StartCoroutine(DuracionTitileo());
    }
    public void LuzRatingBaja()
    {
        Luz.material.SetColor("_BaseColor", Color.HSVToRGB(0.45f, 0.75f, 1));
        Luz.material.SetFloat("_Encendido", 1);
        Luz.material.SetFloat("_Speed", 0);
        StartCoroutine(DuracionTitileo());

    }

    IEnumerator DuracionTitileo()
    {
        yield return new WaitForSeconds(0.5f);
        Luz.material.SetFloat("_Encendido", 0);
        yield return new WaitForSeconds(0.2f);
        Luz.material.SetFloat("_Encendido", 1);
        yield return new WaitForSeconds(1.5f);
        Luz.material.SetFloat("_Encendido", 0);

    }
}
