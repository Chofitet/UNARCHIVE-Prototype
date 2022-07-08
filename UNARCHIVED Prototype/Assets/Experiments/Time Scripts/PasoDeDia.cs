using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PasoDeDia : MonoBehaviour
{
    [SerializeField] TimeManager time;
    private int dia;
    public TMP_Text txtDia;
    public TMP_Text txtHasta;
    public GameObject ObjectDia;
    public static bool PantallaDia { get; private set ; }
    private void Start()
    {
        ObjectDia.gameObject.SetActive(false);
        dia = 3;
    }
    void Update()
    {
        if (dia != TimeManager.Dia)
        {
            PasoDia();
        }
        dia = TimeManager.Dia;
    }

    IEnumerator RetencionPasoDia ()
    {
        yield return new WaitForSeconds(4);
        ObjectDia.gameObject.SetActive(false);
        if (dia != 3)
        {
            time.TiempoNormal();
        }
        PantallaDia = false;

    }
    public void PasoDia()
    {
        PantallaDia = true;
        Debug.Log(dia);
        dia = TimeManager.Dia;
        ObjectDia.gameObject.SetActive(true);
        StartCoroutine(RetencionPasoDia());
        txtDia.text = "2" + TimeManager.Dia + "/03";
        time.TiempoPausado();
        if (dia != 3)
        {
            txtHasta.text = (7 - dia) + " dias hasta llegada del equipo";
            if (dia == 7) { txtHasta.text =  "Hoy llega el equipo"; }
        }
    }

}
