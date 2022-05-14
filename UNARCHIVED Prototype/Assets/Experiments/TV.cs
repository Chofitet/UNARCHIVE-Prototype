using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/// 
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

        if (TimeManager.Hora == 6 && tiempo.Dia == 3 && bitacoras.BenEliminado == true) { NoticiasImportantes(BenDesapareceTitulo, BenDesapareceNoticia); }
        if (TimeManager.Hora == 6 && tiempo.Dia == 4 && bitacoras.BenEliminado == true) { NoticiasImportantes(BenDesapareceTitulo, BenDesapareceNoticia); }

    }

    void NoticiasAliatorias ()
    {
        switch (Random.Range(1,10))
        {
            case 1:
                titular.text = "bOOBIS DE SANDIA";
                noticia.text = "dksfhiusDFiuafsiDFNISSA";
                break;
            case 2:
                titular.text = "Ahora explotan";
                break;
            case 3:
                titular.text = "Cómo y donde encontrar queso invisible";
                break;
                
            case 4:
                titular.text = "";
                break;
               
            case 5:
                titular.text = "1";
                break;
                
            case 6:
                titular.text = "2";
                break;
                
            case 7:
                titular.text = "3";
                break;
                
            case 8:
                titular.text = "4";
                break;
                
            case 9:
                titular.text = "6";
                break;
                
            case 10:
                titular.text = "8";
                break;

        }
    }

    void NoticiasImportantes (string T, string N)
    {
        noticia.text = N;
        titular.text = T;
    }
}
