using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TV : MonoBehaviour
{


    public TMP_Text titular;
    public TMP_Text noticia;
    [SerializeField] TimeManager tiempo;
    [SerializeField] Bitacoras bitacoras;


    string BenDesapareceTitulo = "NiñoNO ES ENCONTRADO HAY QUE DOLOR QUE PENA";
    string BenDesapareceNoticia = "NiñoNO ES ENCONTRADO HAY QUE DOLOR QUE PENA, a pero fue encontrado, borra eso";


    private void OnEnable()
    {
        TimeManager.CambioHoras += DirectorNoticias;
    }
    private void OnDisable()
    {
        TimeManager.CambioHoras -= DirectorNoticias;
    }

    void DirectorNoticias ()
    {
        if (TimeManager.Hora == 6) {NoticiasAliatorias();}
        if (TimeManager.Hora == 9) {NoticiasAliatorias();}
        if (TimeManager.Hora == 12) {NoticiasAliatorias();}
        if (TimeManager.Hora == 15) {NoticiasAliatorias();}
        if (TimeManager.Hora == 18) {NoticiasAliatorias();}

        if (TimeManager.Hora == 12 && tiempo.Dia == 1 && bitacoras.BenEliminado == true) { NoticiasImportantes(BenDesapareceTitulo, BenDesapareceNoticia); }
        if (TimeManager.Hora == 12 && tiempo.Dia == 2 && bitacoras.BenEliminado == true) { NoticiasImportantes(BenDesapareceTitulo, BenDesapareceNoticia); }
    }

    void NoticiasAliatorias ()
    {
        switch (Random.Range(1,10))
        {
            case 1:
                titular.text = "bOOBIS DE SANDIA";
                break;
            case 2:
                titular.text = "Ahora explotan";
                break;
            case 3:
                titular.text = "Queso invisible";
                break;
                
            case 4:
                titular.text = "";
                break;
               
            case 5:
                titular.text = "Queso invisible";
                break;
                
            case 6:
                titular.text = "Queso invisible";
                break;
                
            case 7:
                titular.text = "Queso invisible";
                break;
                
            case 8:
                titular.text = "Queso invisible";
                break;
                
            case 9:
                titular.text = "Queso invisible";
                break;
                
            case 10:
                titular.text = "Queso invisible";
                break;

        }
    }

    void NoticiasImportantes (string T, string N)
    {
        noticia.text = N;
        titular.text = T;
    }
}
