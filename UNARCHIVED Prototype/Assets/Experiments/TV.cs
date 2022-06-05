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
    int CualLista;
    int NumNoticiasAteatorias = 1;

    private void Start()
    {
        CualLista = Random.Range(0, 3);
        NoticiasAliatorias();
    }


    // Para crear una noticia hay que crear tres variables: un booleano para que la noticia solo aparezca una vez, y dos strings, una para el titular(aparece pantalla chiquito)
    // y otro para la noticia dentro de la pantalla de la tv.

    //============================================================================ TV Ben Benji =============================================================================//
    public bool BenEntrevista1; //aviso de que se hará la entrevista
    string BenEntrevistaTitulo1 = "ENTREVISTA EXCLUSIVA CON NIÑO AVISTADOR DE PIE GRANDE MAÑANA A LAS 21";
    string BenEntrevistaNoticia1 = "ENTREVISTA EXCLUSIVA CON NIÑO AVISTADOR DE PIE GRANDE MAÑANA A LAS 21";

    public bool BenEntrevista2; // entrevista de ben
    string BenEntrevistaTitulo2 = "BEN BENJI DECLARA: ERA PIE GRANDE Y LO VI EN PARQUE PIMIENTA";
    string BenEntrevistaNoticia2 = "BEN BENJI DECLARA: ERA PIE GRANDE Y LO VI EN PARQUE PIMIENTA";

    bool BenEliminado;
    string BenDesapareceTitulo = "NIÑO TESTIGO DESAPARECE. ¿ES PIE GRANDE EL CULPABLE O EL GOBIERNO?";
    string BenDesapareceNoticia = "NIÑO TESTIGO DESAPARECE. ¿ES PIE GRANDE EL CULPABLE O EL GOBIERNO?";

    bool BenBrainwash;
    string BenBrainwashTitulo = "NIÑO AVISTADOR DICE QUE NO SABE NADA. ¿COBARDE MENTIROSO O CONSPIRADOR?";
    string BenBrainwashNoticia = "NIÑO AVISTADOR DICE QUE NO SABE NADA. ¿COBARDE MENTIROSO O CONSPIRADOR?";

    bool BenDifamado1;
    string BenDifamadoTitulo1 = "NIÑO MENTIROSO MIENTE DEVUELTA. 10 MENTIRAS QUE BENJI YA TE DIJO Y NO SABÍAS!"; ///ESTE ES EL CASO Hackeado = false
    string BenDifamadoNoticia1 = "NIÑO MENTIROSO MIENTE DEVUELTA. 10 MENTIRAS QUE BENJI YA TE DIJO Y NO SABÍAS!";///ESTE ES EL CASO Hackeado = false

    string BenDifamadoTitulo2 = "ENTUSIASTA AVISTADOR DE PIE GRANDES RESULTA TERRORISTA AMATEUR! PERPETUA PARA BENJI"; ///ESTE ES EL CASO Hackeado = true
    string BenDifamadoNoticia2 = "ENTUSIASTA AVISTADOR DE PIE GRANDES RESULTA TERRORISTA AMATEUR! PERPETUA PARA BENJI"; ///ESTE ES EL CASO Hackeado = true
    //============================================================================ TV Pie Grande ===================================================================//
    bool PieGrandeEliminado;
    string PieGrandeEliminadoTitulo = "Kate Milliar sale a decir que mataron a su choma";
    string PieGrandeEliminadoNoticia = "La actriz kATE Milliar estaba saliendo con el mismisimo Pie Grande y declara que po acaban de matar.";
    //============================================================================ TV Pimienta Paluza ===================================================================//
    bool PimientaPaluzaHackeado;
    string PimientaPaluzaoTitulo = "¡PIMIENTA PALUZA CANCELADO! DON PALUZA DEVUELVE LA PLATA. QUE AGRADABLE SUJETO";
    string PimientaPaluzaNoticia = "¡PIMIENTA PALUZA CANCELADO! DON PALUZA DEVUELVE LA PLATA. QUE AGRADABLE SUJETO";
    //============================================================================ TV Pimientapaluzers ===================================================================//
    bool PimientapaluzersEliminado;
    string PimientapaluzersTitulo = "¡MASACRE FRENTE A PARQUE PIMIENTA!";
    string PimientapaluzersNoticia = "¡MASACRE FRENTE A PARQUE PIMIENTA!";

    bool PimientapaluzersDifamado;
    string PimientapaluzersTitulo2 = "";
    string PimientapaluzersNoticia2 = "";
    //============================================================================ TV Pepe Queño ===================================================================//
    bool PepeQueñoEliminado1;
    string PepeQueñoTitulo1 = "JOVEN ORGANIZA BÚSQUEDA POR SU AMIGO IMAGINARIO"; //Parte 1
    string PepeQueñoNoticia1 = "JOVEN ORGANIZA BÚSQUEDA POR SU AMIGO IMAGINARIO";

    bool PepeQueñoEliminado2;
    string PepeQueñoTitulo2 = "NADIE SE PRESENTA A BUSQUEDA DE NIÑO PELUDO, TRISTE Y RARO"; //Parte 2
    string PepeQueñoNoticia2 = "NADIE SE PRESENTA A BUSQUEDA DE NIÑO PELUDO, TRISTE Y RARO";
    //============================================================================ TV Parque Pimienta =============================================================================//
    bool ParquePimientaAislado1;
    string ParquePimientaTitulo1 = "MISTERIOSA CERCA RODEA PARQUE PIMIENTA!"; //Pimienta paluza hackeado = false
    string ParquePimientaNoticia1 = "MISTERIOSA CERCA RODEA PARQUE PIMIENTA!¿QUE ESTÁ PASANDO EN PUEBLO PIMIENTA?"; //Pimienta paluza hackeado = false

    bool ParquePimientaAislado2;
    string ParquePimientaTitulo2 = "MISTERIOSA CERCA RODEA PARQUE PIMIENTA!"; //Pimienta paluza hackeado = true
    string ParquePimientaNoticia2 = "MISTERIOSA CERCA RODEA PARQUE PIMIENTA!¿QUE ESTÁ PASANDO EN PUEBLO PIMIENTA?"; //Pimienta paluza hackeado = true

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

    public void DirectorNoticias()
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



    // Comprueba el estado de variables para posicionar noticias, ubicar las noticias cronologicamente, su orden va de arriba para abajo.
    void CheckearBitacoras()
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
        else if (bitacoras.PimientaPaluzaHackeado == true && PimientaPaluzaHackeado == false)
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
            PimientapaluzersDifamado = true;
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

    IEnumerator ImprimirNoticia(string T, string N, int IncrementoRating)
    {
        yield return new WaitForSeconds(tiempo.MinutosXseg * 50 * 3);
        x = true;
        yield return new WaitForSeconds(tiempo.MinutosXseg * 10 * 3);
        noticia.text = N;
        titular.text = T;
        PC.Rating = PC.Rating + IncrementoRating;
    }


    /// ================================================================== Noticias Aleatorias ========================================================= ///
    string TitularAleatoria1 = "COMO ROBAR DESEOS DE CUMPLEAÑOS COMO ESE NENE DE LA PELI";
    string NoticiaAleatoria1 = "PONETE LOS LENTES, PA";

    string TitularAleatoria2 = "¿DIETA O RADIACION? CÓMO QUEMAR ESOS KILOS DE MÁS";
    string NoticiaAleatoria2 = "PONETE LOS LENTES, PA";

    string TitularAleatoria3 = "CÓMO Y DÓNDE ENCONTRAR QUESO INVISIBLE";
    string NoticiaAleatoria3 = "PONETE LOS LENTES, PA";

    string TitularAleatoria4 = "FESTIVAL 'PATEA UN TIBURÓN' TERMINA EN TRAGEDIA";
    string NoticiaAleatoria4 = "PONETE LOS LENTES, PA";

    string TitularAleatoria5 = "ASESINO SERIAL RAGE QUITS";
    string NoticiaAleatoria5 = "ASESINO SERIAL RAGE QUITS";

    string TitularAleatoria6 = "¿CUÁNTO GARPA SER UNA NINFA?";
    string NoticiaAleatoria6 = "PONETE LOS LENTES, PA";

    string TitularAleatoria7 = "MARIPOSA SENTENCIADA A 60 AÑOS EN PRISIÓN FEDERAL";
    string NoticiaAleatoria7 = "PONETE LOS LENTES, PA";

    string TitularAleatoria8 = "REBOOT DE PREQUELA SE CONVIERTE EN SPIN-OFF DE REMAKE DEL LIBRO";
    string NoticiaAleatoria8 = "PONETE LOS LENTES, PA";

    string TitularAleatoria9 = "GAME DESIGNER PROPONE IDEA A ÚLTIMO MOMENTO";
    string NoticiaAleatoria9 = "PONETE LOS LENTES, PA";

    string TitularAleatoria10 = "ES OFICIAL: JAMES, A NADIE LE IMPORTA AVATAR";
    string NoticiaAleatoria10 = "PONETE LOS LENTES, PA";


    void NoticiasAliatorias()
    {
        if (CualLista == 1)
        {
            switch (NumNoticiasAteatorias)
            {
                case 1:
                    titular.text = TitularAleatoria1;
                    noticia.text = NoticiaAleatoria1;
                    NumNoticiasAteatorias++;
                    break;
                case 2:
                    titular.text = TitularAleatoria2;
                    noticia.text = NoticiaAleatoria2;
                    NumNoticiasAteatorias++;
                    break;
                case 3:
                    titular.text = TitularAleatoria3;
                    noticia.text = NoticiaAleatoria3;
                    NumNoticiasAteatorias++;
                    break;

                case 4:
                    titular.text = TitularAleatoria4;
                    noticia.text = NoticiaAleatoria4;
                    NumNoticiasAteatorias++;
                    break;

                case 5:
                    titular.text = TitularAleatoria5;
                    noticia.text = NoticiaAleatoria5;
                    NumNoticiasAteatorias++;
                    break;

                case 6:
                    titular.text = TitularAleatoria6;
                    noticia.text = NoticiaAleatoria6;
                    NumNoticiasAteatorias++;
                    break;

                case 7:
                    titular.text = TitularAleatoria7;
                    noticia.text = NoticiaAleatoria7;
                    NumNoticiasAteatorias++;
                    break;

                case 8:
                    titular.text = TitularAleatoria8;
                    noticia.text = NoticiaAleatoria8;
                    NumNoticiasAteatorias++;
                    break;

                case 9:
                    titular.text = TitularAleatoria9;
                    noticia.text = NoticiaAleatoria9;
                    NumNoticiasAteatorias++;
                    break;

                case 10:
                    titular.text = TitularAleatoria10;
                    noticia.text = NoticiaAleatoria10;
                    NumNoticiasAteatorias = 1;
                    break;
            }

        }
        else if (CualLista == 2)
        {
            switch (NumNoticiasAteatorias)
            {
                case 10:
                    titular.text = TitularAleatoria1;
                    noticia.text = NoticiaAleatoria1;
                    NumNoticiasAteatorias = 1;
                    break;
                case 9:
                    titular.text = TitularAleatoria2;
                    noticia.text = NoticiaAleatoria2;
                    NumNoticiasAteatorias++;
                    break;
                case 8:
                    titular.text = TitularAleatoria3;
                    noticia.text = NoticiaAleatoria3;
                    NumNoticiasAteatorias++;
                    break;

                case 7:
                    titular.text = TitularAleatoria4;
                    noticia.text = NoticiaAleatoria4;
                    NumNoticiasAteatorias++;
                    break;

                case 6:
                    titular.text = TitularAleatoria5;
                    noticia.text = NoticiaAleatoria5;
                    NumNoticiasAteatorias++;
                    break;

                case 5:
                    titular.text = TitularAleatoria6;
                    noticia.text = NoticiaAleatoria6;
                    NumNoticiasAteatorias++;
                    break;

                case 4:
                    titular.text = TitularAleatoria7;
                    noticia.text = NoticiaAleatoria7;
                    NumNoticiasAteatorias++;
                    break;

                case 3:
                    titular.text = TitularAleatoria8;
                    noticia.text = NoticiaAleatoria8;
                    NumNoticiasAteatorias++;
                    break;

                case 2:
                    titular.text = TitularAleatoria9;
                    noticia.text = NoticiaAleatoria9;
                    NumNoticiasAteatorias++;
                    break;

                case 1:
                    titular.text = TitularAleatoria10;
                    noticia.text = NoticiaAleatoria10;
                    NumNoticiasAteatorias++;
                    break;
            }


        }
        else if (CualLista == 0)
        {
            switch (NumNoticiasAteatorias)
            {
                case 5:
                    titular.text = TitularAleatoria1;
                    noticia.text = NoticiaAleatoria1;
                    NumNoticiasAteatorias = 1;
                    break;
                case 3:
                    titular.text = TitularAleatoria2;
                    noticia.text = NoticiaAleatoria2;
                    NumNoticiasAteatorias++;
                    break;
                case 1:
                    titular.text = TitularAleatoria3;
                    noticia.text = NoticiaAleatoria3;
                    NumNoticiasAteatorias++;
                    break;

                case 7:
                    titular.text = TitularAleatoria4;
                    noticia.text = NoticiaAleatoria4;
                    NumNoticiasAteatorias++;
                    break;

                case 2:
                    titular.text = TitularAleatoria5;
                    noticia.text = NoticiaAleatoria5;
                    NumNoticiasAteatorias++;
                    break;

                case 4:
                    titular.text = TitularAleatoria6;
                    noticia.text = NoticiaAleatoria6;
                    NumNoticiasAteatorias++;
                    break;

                case 8:
                    titular.text = TitularAleatoria7;
                    noticia.text = NoticiaAleatoria7;
                    NumNoticiasAteatorias++;
                    break;

                case 10:
                    titular.text = TitularAleatoria8;
                    noticia.text = NoticiaAleatoria8;
                    NumNoticiasAteatorias = 1;
                    break;

                case 6:
                    titular.text = TitularAleatoria9;
                    noticia.text = NoticiaAleatoria9;
                    NumNoticiasAteatorias++;
                    break;

                case 9:
                    titular.text = TitularAleatoria10;
                    noticia.text = NoticiaAleatoria10;
                    NumNoticiasAteatorias++;
                    break;
            }
        }
    }
}
