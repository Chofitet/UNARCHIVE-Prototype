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
    [SerializeField] PC PC;
    bool x;


    // Para crear una noticia hay que crear tres variables: un booleano para que la noticia solo aparezca una vez, y dos strings, una para el titular(aparece pantalla chiquito)
    // y otro para la noticia dentro de la pantalla de la tv.
    bool BenEliminado;
    string BenDesapareceTitulo = "NIÑO ES ENCONTRADO HAY QUE DOLOR QUE PENA";
    string BenDesapareceNoticia = "NIÑO ES ENCONTRADO HAY QUE DOLOR QUE PENA, a pero fue encontrado, borra eso";

    bool BenBrainwash;
    string BenBrainwashTitulo = "Niño testigo cancela entrevista. ¿Cobarde, mentiroso o co-conspirador?";
    string BenBrainwashNoticia = "TV1:  Niño testigo cancela entrevista. ¿Cobarde, mentiroso o co-conspirador?";

    bool BenDifamado;
    string BenDifamadoTitulo = "Niño mentiroso miente. 10 mentiras que Ben Benji ya te dijo y no sabías!";
    string BenDifamadoNoticia = "Niño mentiroso miente. 10 mentiras que Ben Benji ya te dijo y no sabías!";

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
        if (TimeManager.Hora == 6) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 9) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 12) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 15) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 18) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }

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
                titular.text = "1";
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

    // Comprueba el estado de variables para posicionar noticias, ubicar las noticias cronologicamente, su orden va de arriba para abajo.
    void CheckearBitacoras ()
    {
        if (bitacoras.BenEliminado == true && BenEliminado == false)
        {
            Debug.Log("ben eliminado");
            int IncrementoRating = 3;
            StartCoroutine(ImprimirNoticia(BenDesapareceTitulo, BenDesapareceNoticia, IncrementoRating));
            BenEliminado = true;
        }
        else if (bitacoras.BenLavado == true && BenBrainwash == false)//
        {
            int IncrementoRating = -1;
            StartCoroutine(ImprimirNoticia(BenBrainwashTitulo, BenBrainwashNoticia, IncrementoRating));
            BenBrainwash = true;
        }
        else if (bitacoras.BenDifamado == true && BenDifamado == false)//
        {
            int IncrementoRating = -2;
            StartCoroutine(ImprimirNoticia(BenDifamadoTitulo, BenDifamadoNoticia, IncrementoRating));
            BenDifamado = true;
        }
        else if (bitacoras.PieGrandeEliminado == true && PieGrandeEliminado == false)
        {
            int IncrementoRating = 5;
            StartCoroutine(ImprimirNoticia(PieGrandeEliminadoTitulo, PieGrandeEliminadoNoticia, IncrementoRating));
            PieGrandeEliminado = true;
        }
       

    }
   
    IEnumerator ImprimirNoticia (string T, string N, int IncrementoRating)
    {
        yield return new WaitForSeconds(tiempo.MinutosXseg * 50 * 3);
        x = true;
        yield return new WaitForSeconds(tiempo.MinutosXseg * 10 * 3);
        noticia.text = N;
        titular.text = T;
        PC.Rating = PC.Rating + IncrementoRating;
    }
}
