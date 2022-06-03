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
    [SerializeField] Libreta libreta;
    [SerializeField] PC PC;
    bool x;


    // Para crear una noticia hay que crear tres variables: un booleano para que la noticia solo aparezca una vez, y dos strings, una para el titular(aparece pantalla chiquito)
    // y otro para la noticia dentro de la pantalla de la tv.

    //============================================================================ TV Ben Benji =============================================================================//
    public bool BenEntrevista1; //aviso de que se hará la entrevista
    string BenEntrevistaTitulo1 = "Ben esntrevista";
    string BenEntrevistaNoticia1 = "";

    public bool BenEntrevista2; // entrevista de ben
    string BenEntrevistaTitulo2 = "Ben esntrevista";
    string BenEntrevistaNoticia2 = "";

    bool BenEliminado;
    string BenDesapareceTitulo = "NIÑO ES ENCONTRADO HAY QUE DOLOR QUE PENA";
    string BenDesapareceNoticia = "NIÑO ES ENCONTRADO HAY QUE DOLOR QUE PENA, a pero fue encontrado, borra eso";

    bool BenBrainwash;
    string BenBrainwashTitulo = "Niño testigo cancela entrevista. ¿Cobarde, mentiroso o co-conspirador?";
    string BenBrainwashNoticia = "TV1:  Niño testigo cancela entrevista. ¿Cobarde, mentiroso o co-conspirador?";

    bool BenDifamado1;
    string BenDifamadoTitulo1 = "Niño mentiroso miente. 10 mentiras que Ben Benji ya te dijo y no sabías!"; ///ESTE ES EL CASO Hackeado = false
    string BenDifamadoNoticia1 = "Niño mentiroso miente. 10 mentiras que Ben Benji ya te dijo y no sabías!";///ESTE ES EL CASO Hackeado = false

    string BenDifamadoTitulo2 = "Niño mentiroso miente. 10 mentiras que Ben Benji ya te dijo y no sabías!"; ///ESTE ES EL CASO Hackeado = true
    string BenDifamadoNoticia2 = "Niño mentiroso miente. 10 mentiras que Ben Benji ya te dijo y no sabías!"; ///ESTE ES EL CASO Hackeado = true
    //============================================================================ TV Pie Grande ===================================================================//
    bool PieGrandeEliminado;
    string PieGrandeEliminadoTitulo = "Kate Milliar sale a decir que mataron a su choma";
    string PieGrandeEliminadoNoticia = "La actriz kATE Milliar estaba saliendo con el mismisimo Pie Grande y declara que po acaban de matar.";
    //============================================================================ TV Pimienta Paluza ===================================================================//
    bool PimientaPaluzaHackeado;
    string PimientaPaluzaoTitulo = "Kate Milliar sale a decir que mataron a su choma";
    string PimientaPaluzaNoticia = "La actriz kATE Milliar estaba saliendo con el mismisimo Pie Grande y declara que po acaban de matar.";
    //============================================================================ TV Pimientapaluzers ===================================================================//
    bool PimientapaluzersEliminado;
    string PimientapaluzersTitulo = "Kate Milliar sale a decir que mataron a su choma";
    string PimientapaluzersNoticia = "";

    bool PimientapaluzersDifamado;
    string PimientapaluzersTitulo2 = "";
    string PimientapaluzersNoticia2 = "";
    //============================================================================ TV Pepe Queño ===================================================================//
    bool PepeQueñoEliminado1;
    string PepeQueñoTitulo1 = ""; //Parte 1
    string PepeQueñoNoticia1 = "";

    bool PepeQueñoEliminado2;
    string PepeQueñoTitulo2 = ""; //Parte 2
    string PepeQueñoNoticia2 = "";
    //============================================================================ TV Parque Pimienta =============================================================================//
    bool ParquePimientaAislado1;
    string ParquePimientaTitulo1 = ""; //Pimienta paluza hackeado = false
    string ParquePimientaNoticia1 = ""; //Pimienta paluza hackeado = false

    bool ParquePimientaAislado2;
    string ParquePimientaTitulo2 = ""; //Pimienta paluza hackeado = true
    string ParquePimientaNoticia2 = ""; //Pimienta paluza hackeado = true

    bool ParquePimientaAislado3;
    string ParquePimientaTitulo3 = ""; //Pimienta paluza hackeado = true y pepe/ben eliminado/lavado = false
    string ParquePimientaNoticia3 = ""; //Pimienta paluza hackeado = true

    bool ParquePimientaAislado4;
    string ParquePimientaTitulo4 = ""; //Pimienta paluza hackeado = true Kate/PieGrande eliminado/lavado = false
    string ParquePimientaNoticia4 = ""; //Pimienta paluza hackeado = true

    private void OnEnable()
    {
        // TimeManager.CambioHoras += DirectorNoticias;
    }
    private void OnDisable()
    {
      //  TimeManager.CambioHoras -= DirectorNoticias;
    }
    private void Update()
    {
        
    }

    public void DirectorNoticias ()
    {
        CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false;

        /*
        if (TimeManager.Hora == 6) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 9) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 12) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 15) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 18) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        */
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
        //============================================================================ TV Diario =============================================================================//
        if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && tiempo.Dia == 3 && TimeManager.Hora == 12 && BenEntrevista1 == false)
        {
            int IncrementoRating = 3;
            StartCoroutine(ImprimirNoticia(BenEntrevistaTitulo1, BenEntrevistaNoticia1, IncrementoRating));
            BenEntrevista1 = true;
        }
        else if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && tiempo.Dia == 4 && TimeManager.Hora == 12 && BenEntrevista2 == false)
        {
            int IncrementoRating = 3;
            StartCoroutine(ImprimirNoticia(BenEntrevistaTitulo2, BenEntrevistaNoticia2, IncrementoRating));
            BenEntrevista2 = true;
        }
        //============================================================================ TV Ben Benji =============================================================================//
        else if (bitacoras.BenEliminado == true && BenEliminado == false)
        {
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
        else if (bitacoras.BenDifamado == true && bitacoras.BenHackeado == false && BenDifamado1 == false)// Hackeado = false
        {
            int IncrementoRating = -2;
            StartCoroutine(ImprimirNoticia(BenDifamadoTitulo1, BenDifamadoNoticia1, IncrementoRating));
            BenDifamado1 = true;
        }
        else if (bitacoras.BenDifamado == true && bitacoras.BenHackeado == true && BenDifamado1 == false)// Hacheado = true
        {
            int IncrementoRating = -2;
            StartCoroutine(ImprimirNoticia(BenDifamadoTitulo2, BenDifamadoNoticia2, IncrementoRating));
            BenDifamado1 = true;
        }
        //============================================================================ TV Pie Grande ===================================================================//
        else if (bitacoras.PieGrandeEliminado == true && PieGrandeEliminado == false)
        {
            int IncrementoRating = 5;
            StartCoroutine(ImprimirNoticia(PieGrandeEliminadoTitulo, PieGrandeEliminadoNoticia, IncrementoRating));
            PieGrandeEliminado = true;
        }
        //============================================================================ TV Pimienta Paluza ===================================================================//
        else if (bitacoras.PimientaPaluzaHackeado== true && PimientaPaluzaHackeado == false)
        {
            int IncrementoRating = 5;
            StartCoroutine(ImprimirNoticia(PimientaPaluzaoTitulo, PimientaPaluzaNoticia, IncrementoRating));
            PimientaPaluzaHackeado = true;
        }
        //============================================================================ TV Parque Pimienta =============================================================================//
        else if (bitacoras.ParquePimientaAislado == true && PimientaPaluzaHackeado == false && ParquePimientaAislado1 == false) // Hackeado = false
        {
            int IncrementoRating = 5;
            StartCoroutine(ImprimirNoticia(ParquePimientaTitulo1, ParquePimientaNoticia1, IncrementoRating));
            ParquePimientaAislado1 = true;
            libreta.BtnPimientapaluzers.SetActive(true);
        }
        else if (bitacoras.ParquePimientaAislado == true && PimientaPaluzaHackeado == true && ParquePimientaAislado2 == false) // Hackeado = true
        {
            int IncrementoRating = 5;
            StartCoroutine(ImprimirNoticia(ParquePimientaTitulo2, ParquePimientaNoticia2, IncrementoRating));
            ParquePimientaAislado2 = true;
        }
        else if (bitacoras.ParquePimientaAislado == true && bitacoras.BenEliminado == false && bitacoras.BenLavado == false && bitacoras.PepeLavado == false && bitacoras.PepeEliminado == false && PimientaPaluzaHackeado == true && ParquePimientaAislado3 == false) // Hackeado = true Ben Pepe
        {
            int IncrementoRating = 5;
            StartCoroutine(ImprimirNoticia(ParquePimientaTitulo3, ParquePimientaNoticia3, IncrementoRating));
            ParquePimientaAislado3 = true;
        }
        else if (bitacoras.ParquePimientaAislado == true && bitacoras.PieGrandeEliminado == false && bitacoras.PieGrandeLavado == false && bitacoras.KateLavada == false && bitacoras.KateEliminada == false && PimientaPaluzaHackeado == true && ParquePimientaAislado3 == false && ParquePimientaAislado4 == false) // Hackeado = true Kate Pie Grande
        {
            int IncrementoRating = 5;
            StartCoroutine(ImprimirNoticia(ParquePimientaTitulo4, ParquePimientaNoticia4, IncrementoRating));
            ParquePimientaAislado4 = true;
        }
        //============================================================================ TV Pimientapaluzers ===================================================================//
        else if (bitacoras.PimientapaluzersEliminado == true && PimientapaluzersEliminado == false)
        {
            int IncrementoRating = 5;
            StartCoroutine(ImprimirNoticia(PimientapaluzersTitulo, PimientapaluzersNoticia, IncrementoRating));
            PimientapaluzersEliminado = true;
        }
        else if (bitacoras.PimientapaluzersDifamado == true && PimientapaluzersDifamado == false)
        {
            int IncrementoRating = 5;
            StartCoroutine(ImprimirNoticia(PimientapaluzersTitulo2, PimientapaluzersNoticia2, IncrementoRating));
            PimientapaluzersDifamado= true;
        }
        //============================================================================ TV Pepe Queño ===================================================================//
        else if (bitacoras.PepeEliminado == true && bitacoras.BenEliminado == false && PepeQueñoEliminado1 == false)
        {
            int IncrementoRating = 5;
            StartCoroutine(ImprimirNoticia(PepeQueñoTitulo1, PepeQueñoNoticia1, IncrementoRating));
            PepeQueñoEliminado1 = true;
        }
        else if (bitacoras.PepeEliminado == true && bitacoras.BenEliminado == false && PepeQueñoEliminado2 == false)
        {
            int IncrementoRating = 5;
            StartCoroutine(ImprimirNoticia(PepeQueñoTitulo2, PepeQueñoNoticia2, IncrementoRating));
            PepeQueñoEliminado2 = true;
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
