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
            PantallaDia = true;
            Debug.Log(dia);
            dia = TimeManager.Dia;
            ObjectDia.gameObject.SetActive(true);
            StartCoroutine(RetencionPasoDia());
            txtDia.text = "2" + TimeManager.Dia + "/03";
            time.TiempoPausado();
        }
        dia = TimeManager.Dia;
    }

    IEnumerator RetencionPasoDia ()
    {
        yield return new WaitForSeconds(4);
        ObjectDia.gameObject.SetActive(false);
        time.TiempoNormal();
        PantallaDia = false;

    }

}
