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

    bool BenEliminado;
    string BenDesapareceTitulo = "NIÑO ES ENCONTRADO HAY QUE DOLOR QUE PENA";
    string BenDesapareceNoticia = "NIÑO ES ENCONTRADO HAY QUE DOLOR QUE PENA, a pero fue encontrado, borra eso";

    bool PieGrandeEliminado;
    string PieGrandeEliminadoTitulo = "Kate Milliar sale a decir que mataron a su choma";
    string PieGrandeEliminadoNoticia = "La actriz kATE Milliar estaba saliendo con el mismisimo Pie Grande y declara que po acaban de matar.";

    private void OnEnable()
    {
        TimeManager.CambioHoras += DirectorNoticias;
    }
    private void OnDisable()
    {
        TimeManager.CambioHoras -= DirectorNoticias;
    }
    private void Update()
    {
        
    }

    void DirectorNoticias ()
    {
        if (TimeManager.Hora == 6) {NoticiasAliatorias(); CheckearBitacoras(); }
        if (TimeManager.Hora == 9) {NoticiasAliatorias(); CheckearBitacoras(); }
        if (TimeManager.Hora == 12) {NoticiasAliatorias(); CheckearBitacoras(); }
        if (TimeManager.Hora == 15) {NoticiasAliatorias(); CheckearBitacoras(); }
        if (TimeManager.Hora == 18) {NoticiasAliatorias(); CheckearBitacoras(); }

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
                noticia.text = "dksfhiusDFiuafsiDFNISSA";
                break;
            case 3:
                titular.text = "Cómo y donde encontrar queso invisible";
                noticia.text = "dksfhiusDFiuafsiDFNISSA";
                break;
                
            case 4:
                titular.text = "";
                noticia.text = "dksfhiusDFiuafsiDFNISSA";
                break;
               
            case 5:
                titular.text = "1";
                noticia.text = "dksfhiusDFiuafsiDFNISSA";
                break;
                
            case 6:
                titular.text = "2";
                noticia.text = "dksfhiusDFiuafsiDFNISSA";
                break;
                
            case 7:
                titular.text = "3";
                noticia.text = "dksfhiusDFiuafsiDFNISSA";
                break;
                
            case 8:
                titular.text = "4";
                noticia.text = "dksfhiusDFiuafsiDFNISSA";
                break;
                
            case 9:
                titular.text = "6";
                noticia.text = "dksfhiusDFiuafsiDFNISSA";
                break;
                
            case 10:
                titular.text = "8";
                noticia.text = "dksfhiusDFiuafsiDFNISSA";
                break;

        }
    }

    void CheckearBitacoras ()
    {
        if(bitacoras.BenEliminado == true && BenEliminado == false)
        {
            StartCoroutine(ImprimirNoticia(BenDesapareceTitulo, BenDesapareceNoticia));
            BenEliminado = true;
        }
        else if (bitacoras.PieGrandeEliminado == true && PieGrandeEliminado == false)
        {
            StartCoroutine(ImprimirNoticia(PieGrandeEliminadoTitulo, PieGrandeEliminadoNoticia));
        }

    }
   
    IEnumerator ImprimirNoticia (string T, string N)
    {
        
        yield return new WaitForSeconds(tiempo.MinutosXseg * 60.01f * 3);
        noticia.text = N;
        titular.text = T;
    }
}
