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

    int EliminarRetencion = 1;
    int LavarRetencion = 1;
    int InvestigarRetencion = 3;
    int HackearRetencion = 3;
    int DifamarRetencion = 1;
    int CrearEscenaRetencion = 1;
    int AislarRetencion = 1;
   


    private bool NF1;
    private bool NF2;
    private bool NF3;
    private bool NF4;
    private bool NF5;
    private bool NF6;

    // Para crear una noticia hay que crear tres variables: un booleano para que la noticia solo aparezca una vez, y dos strings, una para el titular(aparece pantalla chiquito)
    // y otro para la noticia dentro de la pantalla de la tv.



    //============================================================================ TV Ben Benji =============================================================================//
    bool RomoresPuebloPimienta;
    string RumoresPuebloPimientaTitulo = "BIZARRO RUMOR TOMA MODERADO VUELO EN PUEBLO PIMIENTA";
    string RumoresPuebloPimientaNoticia = "¿CREER O REVENTAR? LAS RESPUESTAS SE ACERCAN";

    public bool BenEntrevista1; //aviso de que se hará la entrevista
    string BenEntrevistaTitulo1 = "ENTREVISTA EXCLUSIVA CON NIÑO AVISTADOR DE MISTERIOSA CRIATURA MAÑANA A LAS 12 AM";
    string BenEntrevistaNoticia1 = "BEN BENJI CONTARÁ TODO EN ESTE MISMO CANAL MAÑANA A LAS 12 AM.";

    bool BenEntrevista1b;
    string BenEntrevistaTitulo1b = "REITERAMOS: ENTREVISTA EXCLUSIVA CON NIÑO AVISTADOR DE MISTERIOSA CRIATURA HOY A LAS 12 AM";
    string BenEntrevistaNoticia1b = "BENJI EL PISPIADOR CONTARÁ TODO EN IMPERDIBLE EXCLUSIVA HOY A LAS 12 AM.";

    public bool BenEntrevista2; // entrevista de ben
    string BenEntrevistaTitulo2 = "\"ERA PIE GRANDE Y LO VÍ EN PARQUE PIMIENTA\". PELUDAS DECLARACIONES!!!";
    string BenEntrevistaNoticia2 = "BENJI EL PISPIADOR CONFIRMA QUE LA CRIATURA EN PARQUE PIMIENTA SE TRATA DE EL MÍTICO PIE GRANDE.¿QUIÉN ERA LA COLORADA?";

    bool BenEntrevista3;
    string BenEntrevistaTitulo3 = "TURBA ENFURECIDA SE DIRIJE A PARQUE PIMIENTA EN BÚSQUEDA DE BENJI EL PISPIADOR";
    string BenEntrevistaNoticia3 = "TURBA ENFURECIDA SE DIRIJE A PARQUE PIMIENTA EN BÚSQUEDA DE BENJI EL PISPIADOR";

    bool BenEntrevista3b;
    string BenEntrevistaTitulo3b = "TURBA ENTUSIASTA SE DIRIJE A PARQUE PIMIENTA EN BUSQUEDA DE CRIATURA";
    string BenEntrevistaNoticia3b = "TURBA ENTUSIASTA SE DIRIJE A PARQUE PIMIENTA EN BUSQUEDA DE CRIATURA";

    bool BenEntrevista4;
    string BenEntrevistaTitulo4 = "TURBA AMATEUR ES ATACADA POR CRIATURA MONSTRUOSA EN PARQUE PIMIENTA!";
    string BenEntrevistaNoticia4 = "TURBA AMATEUR ES ATACADA POR CRIATURA MONSTRUOSA EN PARQUE PIMIENTA! MASACRE A PLENA LUZ DEL DIA!";

    bool BenEliminado;
    string BenDesapareceTitulo = "NIÑO TESTIGO DESAPARECE. ¿ES PIE GRANDE EL CULPABLE O EL GOBIERNO?";
    string BenDesapareceNoticia = "BENJI EL PISPIADOR HA DESAPARECIDO SIN DEJAR RASTRO.¿RAPTADO POR PIE GRANDE O BAJO ORDENES DEL GOBIERNO?";

    bool BenBombaCasa;
    string BenBombaCasaTitulo = "CASA DE BEN BENJI VUELA EN ALEVOSA EXPLOSIÓN. ¿QUE ESTÁ PASANDO EN PUEBLO PIMIENTA?";
    string BenBombaCasaNoticia = "EXPLOSIÓN EN CASA DE NIÑO DESAPARECIDO. ¿QUE ESTA PASANDO EN PUEBLO PIMIENTA?";

    bool BenBombaEscuela;
    string BenBombaEscuelaTitulo = "ESCUELA EXPLOTA! ¿QUE ESTA PASANDO EN PUEBLO PIMIENTA?";
    string BenBombaEscuelaNoticia = "GRACIAS A LA GRACIA DEL SEÑOR NO HAY VICTIMAS AL ENCONTRARSE EL COLEGIO ENTERO EN EXCURSION BARRIAL. FIUUU!!";
     

    bool BenBrainwash;
    string BenBrainwashTitulo = "NIÑO AVISTADOR NIEGA TODO ¿COBARDE MENTIROSO O CONSPIRADOR?";
    string BenBrainwashNoticia = "¿DONDE COMIENZA LA MENTIRA?¿EN EL HOGAR O EN LAS AULAS?";

    bool BenDifamado1;
    string BenDifamadoTitulo1 = "NIÑO MENTIROSO MIENTE DEVUELTA. 10 MENTIRAS QUE BENJI YA TE DIJO Y NO SABÍAS!"; ///ESTE ES EL CASO Hackeado = false
    string BenDifamadoNoticia1 = "¿DONDE COMIENZA LA MENTIRA?¿EN EL HOGAR O EN LAS AULAS?";///ESTE ES EL CASO Hackeado = false

    bool BenDifamado2;
    string BenDifamadoTitulo2 = "ENTUSIASTA AVISTADOR DE PIE GRANDES RESULTA TERRORISTA AMATEUR! PERPETUA PARA BENJI"; ///ESTE ES EL CASO Hackeado = true
    string BenDifamadoNoticia2 = "EXPLOSIVA REVELACIÓN DESENMASCA A BEN BENJI COMO TERRORISTA AMATEUR! EL PUEBLO PIDE PERPETUA"; ///ESTE ES EL CASO Hackeado = true

    //============================================================================ TV Pie Grande ===================================================================//
    bool PieGrandeEliminado;
    string PieGrandeEliminadoTitulo = "REVELACIONES PELUDAS! LA NOVIA SECRETA DE PIE GRANDE DECLARA TODO HOY A LAS 17";
    string PieGrandeEliminadoNoticia = "REVELACIONES PELUDAS! LA NOVIA SECRETA DE PIE GRANDE DECLARA TODO HOY A LAS 17";

    bool KateEliminado2;
    string PieGrandeEliminadoTitulo2 = "PIE GRANDE ERA MI FIANCÉ. REAPARECE KATE MILLIARD Y CUENTA TODO!"; 
    string PieGrandeEliminadoNoticia2 = "PIE GRANDE ERA MI FIANCÉ. REAPARECE KATE MILLIARD Y CUENTA TODO! PERO TODO TODO!";

    bool PieGrandeDifamado;
    string PieGrandeDifamadoTitulo = "TE EXPLICAMOS CON CIENCIA 10 MOTIVOS QUE DEMUESTRAN QUE PIE GRANDE ES UN SALAME";
    string PieGrandeDifamadoNoticia = "TE EXPLICAMOS CON CIENCIA 10 MOTIVOS QUE DEMUESTRAN QUE PIE GRANDE ES UN SALAME";
    //============================================================================ TV Kate Milliard ===================================================================//
    bool KateEliminada;
    string KateEliminadaTitulo = "EMERGENCIA! MOSTRUOSA CRIATURA ATACA PUEBLO PIMIENTA!";
    string KateEliminadaNoticia = "EMERGENCIA! MOSTRUOSA CRIATURA ATACA PUEBLO PIMIENTA! LAS AUTORIDADES LOCALES PIDEN AYUDA!";

    string KateEliminadaTitulo2 = "PUEBLO PIMIENTA DESTRUIDO!";
    string KateEliminadaNoticia2 = "PUEBLO PIMIENTA DESTRUIDO!";

    bool CrearEscena;
    string CrearEscenaTitulo = "HOMBRE PELUDO Y COLORADA DESMIENTE LOS DICHOS DE BENJI¿ERA EL RUMOR FALSO?";
    string CrearEscenaNoticia = "HOMBRE PELUDO Y COLORADA DESMIENTE LOS DICHOS DE BENJI¿ERA EL RUMOR FALSO?";

    bool Casamiento;
    string CasamientoTitulo = "KATE MILLIARD ANUNCIA CASAMIENTO CON PIE GRANDE! LAS LEYENDAS ERAN CIERTAS!";
    string CasamientoNoticia = "KATE MILLIARD ANUNCIA CASAMIENTO CON PIE GRANDE! LAS LEYENDAS ERAN CIERTAS!";

    //============================================================================ TV Pimientapaluza ===================================================================//
    string PimientaPaluzaAnuncioTitulo = "SE APROXIMA EL PIMIENTAPALUZA! TODOS PREPARADOS PARA EL 28?"; //EL 24
    string PimientaPaluzaAnuncioNoticia = "EL FESTIVAL MAS GRANDE DEL PLANETA DA COMIENZO ESTE 28 EN PARQUE PIMIENTA. ENTRADAS AGOTADAS!";

    string PimientaPaluzaSeAdelantaTitulo = "PIMIENTAPALUZA SE ADELANTA AL 27/03";//EL 25
    string PimientaPaluzaSeAdelantaNoticia = "EL FESTIVAL AGREGA UN DIA DANDO INCIO ANTES DE LO ESPERADO. ENTRADAS AGOTADAS!";

    string PimientaPaluzaMañanaTitulo = "PIMIENTAPALUZA COMIENZA MAÑANA";//EL 26
    string PimientaPaluzaMañanaNoticia = "EL FESTIVAL SE ADELANTA UN DIA ";

    string PimientaPaluzaArrancaTitulo = "DA INICIO EL PIMIENTAPALUZA";//EL 27
    string PimientaPaluzaArrancaNoticia = "WIP";

    string PimientaPaluzaAisladoTitulo = "WIP";
    string PimientaPaluzaAisladoNoticia = "WIP";

    bool PimientaPaluzaHackeado;
    string PimientaPaluzaCanceladoTitulo = "¡PIMIENTA PALUZA CANCELADO! DON PALUZA DEVUELVE LA PLATA. QUE AGRADABLE SUJETO";
    string PimientaPaluzaCanceladoNoticia = "¡PIMIENTA PALUZA CANCELADO! DON PALUZA DEVUELVE LA PLATA. QUE AGRADABLE SUJETO";
    //============================================================================ TV Pimientapaluzers ===================================================================//
    bool PimientapaluzersEliminado;
    string PimientapaluzersTitulo = "¡MASACRE FRENTE A PARQUE PIMIENTA!";
    string PimientapaluzersNoticia = "¡MASACRE FRENTE A PARQUE PIMIENTA!";

    bool PimientapaluzersDifamado;
    string PimientapaluzersTitulo2 = "ALGO DIFAMANTE";
    string PimientapaluzersNoticia2 = "ALGO DIFAMANTE";
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
                                        //============================================================================ TV Pie Grande ===================================================================//
    bool PlantarPublico;
    string PlantarPublicoTitulo = "ABUCHEOS DURANTE ENTREVISTA!LA CREDiBILIDAD DE BENJI SE DESMORONA!!";
    string PlantarPublicoNoticia = "BENJI EL MENTIROSO PIERDE EL APOYO DE LA COMUNIDAD AL MOJAR SUS PANTALONES EN TV NACIONALA";

    private void OnEnable()
    {
        TimeManager.CambioHoras += DirectorNoticias;
    }
    private void OnDisable()
    {
        TimeManager.CambioHoras -= DirectorNoticias;
    }
  
    public void DirectorNoticias()
    {
       // CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false;

        if (TimeManager.Hora == 6) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 7) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 8) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 9) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 10) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 11) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 12) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 13) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 14) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 15) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 16) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }
        if (TimeManager.Hora == 17) { CheckearBitacoras(); if (x == false) NoticiasAliatorias(); x = false; }

    }



    // Comprueba el estado de variables para posicionar noticias, ubicar las noticias cronologicamente, su orden va de arriba para abajo.
    void CheckearBitacoras()
    {
        //============================================================================ TV Diario =============================================================================//
        if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && tiempo.Dia == 3 && TimeManager.Hora == 10 && BenEntrevista1 == false && bitacoras.BenRetirado == false)
        {
            int IncrementoRating = 2;
            noticia.text =  BenEntrevistaNoticia1;//ENTREVISTA EXCLUSIVA CON NIÑO AVISTADOR DE MISTERIOSA CRIATURA MAÑANA A LAS 12 AM
            titular.text = BenEntrevistaTitulo1;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista1 = true;
        }
        else if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && tiempo.Dia == 4 && TimeManager.Hora == 7 && BenEntrevista1 == true && BenEntrevista1b == false)
        {
            int IncrementoRating = 2;
            noticia.text = BenEntrevistaNoticia1b;//REITERAMOS: ENTREVISTA EXCLUSIVA CON NIÑO AVISTADOR DE MISTERIOSA CRIATURA HOY A LAS 12 AM
            titular.text = BenEntrevistaTitulo1b;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista1b = true;
        }
        else if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && tiempo.Dia == 4 && TimeManager.Hora == 12 && BenEntrevista2 == false && bitacoras.PlantarPublico == false)
        {
            int IncrementoRating = 6;
            noticia.text = BenEntrevistaNoticia2; //"ERA PIE GRANDE Y LO VÍ EN PARQUE PIMIENTA\". PELUDAS DECLARACIONES!!!
            titular.text = BenEntrevistaTitulo2;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista2 = true;
        }
        else if (tiempo.Dia == 4 && TimeManager.Hora == 15 && BenEntrevista2 == true && BenEliminado == true)
        {
            int IncrementoRating = 5;
            noticia.text = BenEntrevistaNoticia3;//TURBA ENFURECIDA SE DIRIJE A PARQUE PIMIENTA EN BÚSQUEDA DE BENJI EL PISPIADOR
            titular.text = BenEntrevistaTitulo3;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista3 = true;
        }
        else if (tiempo.Dia == 4 && TimeManager.Hora == 15 && BenEntrevista2 == true && BenEliminado == false)
        {
            int IncrementoRating = 5;
            noticia.text = BenEntrevistaNoticia3b;//TURBA ENTUSIASTA SE DIRIJE A PARQUE PIMIENTA EN BUSQUEDA DE CRIATURA
            titular.text = BenEntrevistaTitulo3b;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista3b = true;
        }
        else if (tiempo.Dia == 5 && TimeManager.Hora == 16 && BenEntrevista3 == true && PieGrandeEliminado == false)
        {
            int IncrementoRating = 15;
            noticia.text = BenEntrevistaNoticia4;//TURBA AMATEUR ES ATACADA POR CRIATURA MONSTRUOSA EN PARQUE PIMIENTA!
            titular.text = BenEntrevistaTitulo4;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista4 = true;
        }
        else if (tiempo.Dia == 5 && TimeManager.Hora == 16 && BenEntrevista3b == true && PieGrandeEliminado == false)
        {
            int IncrementoRating = 15;
            noticia.text = BenEntrevistaNoticia4;//TURBA AMATEUR ES ATACADA POR CRIATURA MONSTRUOSA EN PARQUE PIMIENTA!
            titular.text = BenEntrevistaTitulo4;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista4 = true;
        }
        else if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && tiempo.Dia == 4 && TimeManager.Hora == 12 && BenEntrevista2 == false && bitacoras.PlantarPublico == true)
        {
            int IncrementoRating = -3;
            noticia.text = PlantarPublicoNoticia;//ABUCHEOS DURANTE ENTREVISTA!LA CREDBILIDAD DE BEN BENJI SE DESMORONA AL MOJAR SUS PANTALONES EN TV NACIONAL
            titular.text = PlantarPublicoTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            
        }

        else if (tiempo.Dia == 3 && TimeManager.Hora == 13)
        {
            int IncrementoRating = 0;
            noticia.text = PimientaPaluzaAnuncioNoticia;//se anuncia pimientapaluza
            titular.text = PimientaPaluzaAnuncioTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;

        }
        else if (tiempo.Dia == 4 && TimeManager.Hora == 10)
        {
            int IncrementoRating = 0;
            noticia.text = PimientaPaluzaAnuncioNoticia;//se anuncia pimientapaluza
            titular.text = PimientaPaluzaAnuncioTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;

        }
        else if (BenEliminado == false && tiempo.Dia == 5 && TimeManager.Hora == 9 && BenBombaCasa == false && bitacoras.BenRetirado == false)
        {
            int IncrementoRating = 3;
            noticia.text = BenBombaEscuelaNoticia;
            titular.text = BenBombaEscuelaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenBombaEscuela = true;
        }
        else if (BenEliminado == true && tiempo.Dia == 5 && TimeManager.Hora == 9 && bitacoras.BenRetirado == false)
        {
            int IncrementoRating = 3;
            noticia.text = BenBombaCasaNoticia;
            titular.text = BenBombaCasaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenBombaCasa = true;
        }
        else if (tiempo.Dia == 5 && TimeManager.Hora == 10)
        {
            int IncrementoRating = 0;
            noticia.text = PimientaPaluzaSeAdelantaNoticia;//Pimientapaluza se adelanta
            titular.text = PimientaPaluzaSeAdelantaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;

        }

        else if (bitacoras.PieGrandeEliminado == true && PieGrandeEliminado == true && tiempo.Dia == 5 && TimeManager.Hora == 17 && KateEliminado2 == false)
        {
            int IncrementoRating = 8;
            noticia.text = PieGrandeEliminadoNoticia2; //PIE GRANDE ERA MI FIANCÉ. REAPARECE KATE MILLIARD Y CUENTA TODO!
            titular.text = PieGrandeEliminadoTitulo2;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            PieGrandeEliminado = true;
        }
        else if (tiempo.Dia == 6 && TimeManager.Hora == 10)
        {
            int IncrementoRating = 0;
            noticia.text = PimientaPaluzaMañanaNoticia;//Pimientapaluza Mañana
            titular.text = PimientaPaluzaMañanaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;

        }
        else if (tiempo.Dia == 7 && TimeManager.Hora == 10)
        {
            int IncrementoRating = 0;
            noticia.text = PimientaPaluzaArrancaNoticia;//Pimientapaluza Arranca
            titular.text = PimientaPaluzaArrancaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;

        }


        else if (bitacoras.KateEliminada == false && PieGrandeEliminado == false && KateEliminada == false && tiempo.Dia == 7 && TimeManager.Hora == 17)
        {
            int IncrementoRating = 15;
            noticia.text = CasamientoNoticia;//KATE MILLIARD ANUNCIA CASAMIENTO CON PIE GRANDE! LAS LEYENDAS ERAN CIERTAS!
            titular.text = CasamientoTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;

        }
        //============================================================================ TV RUMOR =============================================================================//
        else if (tiempo.Dia == 3 && TimeManager.Hora == 7)
        {
            int IncrementoRating = 1;
            noticia.text = RumoresPuebloPimientaNoticia;//BIZARRO RUMOR TOMA MODERADO VUELO EN PUEBLO PIMIENTA
            titular.text = RumoresPuebloPimientaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
        }

        //============================================================================ TV Ben Benji =============================================================================//
        else if (bitacoras.BenEliminado == true && BenEliminado == false)
        {
            int IncrementoRating = 3;
            int RetencionNoticia = EliminarRetencion;
            StartCoroutine(ImprimirNoticia(BenDesapareceTitulo, BenDesapareceNoticia, IncrementoRating, RetencionNoticia));
            BenEliminado = true;
        }
       
        else if (bitacoras.BenLavado == true && BenBrainwash == false)//
        {
            int IncrementoRating = 1;
            int RetencionNoticia = LavarRetencion;
            StartCoroutine(ImprimirNoticia(BenBrainwashTitulo, BenBrainwashNoticia, IncrementoRating, RetencionNoticia));
            BenBrainwash = true;
        }
        else if (bitacoras.BenDifamado == true && bitacoras.BenHackeado == false && BenDifamado1 == false)// Hackeado = false
        {
            int IncrementoRating = -2;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(BenDifamadoTitulo1, BenDifamadoNoticia1, IncrementoRating, RetencionNoticia));
            BenDifamado1 = true;
        }
        else if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && bitacoras.BenRetirado == true && BenDifamado2 == false)// Hackeado = true
        {
            int IncrementoRating = -4;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(BenDifamadoTitulo2, BenDifamadoNoticia2, IncrementoRating, RetencionNoticia));
            BenDifamado1 = true;
            BenDifamado2 = true;
        }
        //============================================================================ TV Pie Grande ===================================================================//
        else if (bitacoras.PieGrandeEliminado == true && PieGrandeEliminado == false && KateEliminada == false)
        {
            int IncrementoRating = 5;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(PieGrandeEliminadoTitulo, PieGrandeEliminadoNoticia, IncrementoRating, RetencionNoticia));
            PieGrandeEliminado = true;
        }
        
        else if (bitacoras.PieGrandeDifamado == true && PieGrandeDifamado == false)
        {
            int IncrementoRating = 3;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(PieGrandeDifamadoTitulo, PieGrandeDifamadoNoticia, IncrementoRating, RetencionNoticia));
            PieGrandeDifamado = true;
        }
        //============================================================================ TV Kate Milliard ===================================================================//

        else if (bitacoras.KateEliminada == true && PieGrandeEliminado == false && KateEliminada == false)
        {
            int IncrementoRating = 7;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(KateEliminadaTitulo, KateEliminadaNoticia, IncrementoRating, RetencionNoticia));
            KateEliminada = true;
        }
        else if (bitacoras.KateEliminada == true && PieGrandeEliminado == false && KateEliminada == true && (tiempo.Dia == 6 || tiempo.Dia == 7))
        {
            int IncrementoRating = 13;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(KateEliminadaTitulo2, KateEliminadaNoticia2, IncrementoRating, RetencionNoticia));
            KateEliminada = true;
        }
        //============================================================================ TV Crear Escena ===================================================================//
        else if (bitacoras.CrearEscena == true && CrearEscena == false)
        {
            int IncrementoRating = -2;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(CrearEscenaTitulo, CrearEscenaNoticia, IncrementoRating, RetencionNoticia));
            CrearEscena = true;
        }
        //============================================================================ TV Pimienta Paluza ===================================================================//

        else if (bitacoras.PimientaPaluzaHackeado == true && PimientaPaluzaHackeado == false)
        {
            int IncrementoRating = 5;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(PimientaPaluzaCanceladoTitulo, PimientaPaluzaCanceladoNoticia, IncrementoRating, RetencionNoticia));
            PimientaPaluzaHackeado = true;
        }
        //============================================================================ TV Parque Pimienta =============================================================================//
        else if (bitacoras.ParquePimientaAislado == true && PimientaPaluzaHackeado == false && ParquePimientaAislado1 == false) // Hackeado = false
        {
            int IncrementoRating = 3;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(ParquePimientaTitulo1, ParquePimientaNoticia1, IncrementoRating, RetencionNoticia));
            ParquePimientaAislado1 = true;
            libreta.BtnPimientapaluzers.SetActive(true);
        }
        else if (bitacoras.ParquePimientaAislado == true && PimientaPaluzaHackeado == true && ParquePimientaAislado2 == false) // Hackeado = true
        {
            int IncrementoRating = 0;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(ParquePimientaTitulo2, ParquePimientaNoticia2, IncrementoRating, RetencionNoticia));
            ParquePimientaAislado2 = true;
        }
        else if (bitacoras.ParquePimientaAislado == true && bitacoras.BenEliminado == false && bitacoras.BenLavado == false && bitacoras.PepeLavado == false && bitacoras.PepeEliminado == false && PimientaPaluzaHackeado == true && ParquePimientaAislado3 == false) // Hackeado = true Ben Pepe
        {
            int IncrementoRating = 5;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(ParquePimientaTitulo3, ParquePimientaNoticia3, IncrementoRating, RetencionNoticia));
            ParquePimientaAislado3 = true;
        }
        else if (bitacoras.ParquePimientaAislado == true && bitacoras.PieGrandeEliminado == false && bitacoras.PieGrandeLavado == false && bitacoras.KateLavada == false && bitacoras.KateEliminada == false && PimientaPaluzaHackeado == true && ParquePimientaAislado3 == false && ParquePimientaAislado4 == false) // Hackeado = true Kate Pie Grande
        {
            int IncrementoRating = 5;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(ParquePimientaTitulo4, ParquePimientaNoticia4, IncrementoRating, RetencionNoticia));
            ParquePimientaAislado4 = true;
        }
        //============================================================================ TV Pimientapaluza ===================================================================//


        //============================================================================ TV Pimientapaluzers ===================================================================//

        else if (bitacoras.PimientapaluzersEliminado == true && PimientapaluzersEliminado == false)
        {
            int IncrementoRating = 8;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(PimientapaluzersTitulo, PimientapaluzersNoticia, IncrementoRating, RetencionNoticia));
            PimientapaluzersEliminado = true;
        }
        else if (bitacoras.PimientapaluzersDifamado == true && PimientapaluzersDifamado == false)
        {
            int IncrementoRating = 5;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(PimientapaluzersTitulo2, PimientapaluzersNoticia2, IncrementoRating, RetencionNoticia));
            PimientapaluzersDifamado = true;
        }
        //============================================================================ TV Pepe Queño ===================================================================//
        else if (bitacoras.PepeEliminado == true && bitacoras.BenEliminado == false && PepeQueñoEliminado1 == false)
        {
            int IncrementoRating = 0;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(PepeQueñoTitulo1, PepeQueñoNoticia1, IncrementoRating, RetencionNoticia));
            PepeQueñoEliminado1 = true;
        }
        else if (bitacoras.PepeEliminado == true && bitacoras.BenEliminado == false && PepeQueñoEliminado2 == false)
        {
            int IncrementoRating = 0;
            int RetencionNoticia = 3;
            StartCoroutine(ImprimirNoticia(PepeQueñoTitulo2, PepeQueñoNoticia2, IncrementoRating, RetencionNoticia));
            PepeQueñoEliminado2 = true;
        }
        //=========================================================================== TV Noticia Falsa ===============================================================//
        else if (bitacoras.NoticiaFalasa1 == true && NF1 == false )
        {
            int IncrementoRating = -2;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtNoticiaFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF1 = true;
        }
        else if (bitacoras.NoticiaFalasa2 == true && NF2 == false)
        {
            int IncrementoRating = -1;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtNoticiaFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF2 = true;
        }
        else if (bitacoras.NoticiaFalasa3 == true && NF3 == false)
        {
            int IncrementoRating = -2;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtNoticiaFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF3 = true;
        }
        else if (bitacoras.NoticiaFalasa4 == true && NF4 == false)
        {
            int IncrementoRating = -1;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtNoticiaFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF4 = true;
        }
        else if (bitacoras.NoticiaFalasa5 == true && NF5 == false)
        {
            int IncrementoRating = -2;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtNoticiaFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF5 = true;
        }
        else if (bitacoras.NoticiaFalsa6 == true && NF6 == false)
        {
            int IncrementoRating = -1;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtNoticiaFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF6 = true;
        }

    }

    IEnumerator ImprimirNoticia(string T, string N, int IncrementoRating, int RetencioNoticia)
    {
        x = true;
        yield return StartCoroutine(tiempo.RetencionBitacorasSegunAccion(RetencioNoticia));
        noticia.text = N;
        titular.text = T;
        PC.Rating = PC.Rating + IncrementoRating;
        if (PC.Rating >= 16) { PC.RatinMaximo(); }
        LaFuncionMasEspecificaDelMundoPorqueEsteJugoNoDejaDeTenerDetallesBoludos();
    }

    private void LaFuncionMasEspecificaDelMundoPorqueEsteJugoNoDejaDeTenerDetallesBoludos ()
    {
       if(BenDifamado2) libreta.BtnBen.SetActive(false);
    }

    /// ================================================================== Noticias Aleatorias ========================================================= ///
	string TitularAleatoria1 = "ALMONDIGAS DE MURCIEGALO: EL PLATO DEL MOMENTO";
    string NoticiaAleatoria1 = "PONETE LOS LENTES, PA";

    string TitularAleatoria2 = "¿DIETA O RADIACION? CÓMO QUEMAR ESOS KILOS DE MÁS";
    string NoticiaAleatoria2 = "PONETE LOS LENTES, PA";

    string TitularAleatoria3 = "CÓMO Y DÓNDE ENCONTRAR QUESO INVISIBLE";
    string NoticiaAleatoria3 = "Y CUANDO";

    string TitularAleatoria4 = "FESTIVAL 'PATEA UN TIBURÓN' TERMINA EN SORPRESIVA TRAGEDIA";
    string NoticiaAleatoria4 = "FINALMENTE PASÓ LO IMPENSABLE";

    string TitularAleatoria5 = "ASESINO SERIAL RAGE QUITS";
    string NoticiaAleatoria5 = "ASESINO SERIAL RAGE QUITS";

    string TitularAleatoria6 = "¿CUÁNTO GARPA SER UNA NINFA?";
    string NoticiaAleatoria6 = "PONETE LOS LENTES, PA";

    string TitularAleatoria7 = "MARIPOSA SENTENCIADA A 60 AÑOS EN PRISIÓN FEDERAL";
    string NoticiaAleatoria7 = "JUSTICIA AL FIN!";

    string TitularAleatoria8 = "REBOOT DE PRECUELA SE CONVIERTE EN SPIN-OFF DE REMAKE DEL LIBRO";
    string NoticiaAleatoria8 = "PONETE LOS LENTES, PA";

    string TitularAleatoria9 = "GAME DESIGNER PROPONE FEATURE A ÚLTIMO MOMENTO";
    string NoticiaAleatoria9 = "PONETE LOS LENTES, PA";

    string TitularAleatoria10 = "ES OFICIAL: JAMES, A NADIE LE IMPORTA AVATAR";
    string NoticiaAleatoria10 = "PONETE LOS LENTES, PA";

    string TitularAleatoria11 = "LORO BOCASUCIA ARRUINA BAUTISMO";
    string NoticiaAleatoria11 = "POLLY NO QUIERE UNA GALLETA, QUIERE &#$%@< Y +{<*/:(";

    string TitularAleatoria12 = "COMO ROBAR DESEOS DE CUMPLEAÑOS COMO ESE NENE DE LA PELI";
    string NoticiaAleatoria12 = "PONETE LOS LENTES, PA";

    string TitularAleatoria13 = "PATA PETA PITA POTA Y UNA HERMANA";
    string NoticiaAleatoria13 = "PONETE LOS LENTES, PA";

    string TitularAleatoria14 = "¿ES AMARILLO EL COLOR PARA TU PERSONAJE?";
    string NoticiaAleatoria14 = "PONETE LOS LENTES, PA";

    string TitularAleatoria15 = "TECHPROOF CUMPLE CON LA MÍNIMA. ALUMNOS SE REGOZIJAN";
    string NoticiaAleatoria15 = "PONETE LOS LENTES, PA";

    string TitularAleatoria16 = "APRENDE OTRO IDIOMA CAMBIANDOLO EN SETTINGS";
    string NoticiaAleatoria16 = "PONETE LOS LENTES, PA";

    string TitularAleatoria17 = "ES OFICIAL: NADA PASÓ EN UNA HORA";
    string NoticiaAleatoria17 = "PONETE LOS LENTES, PA";

    string TitularAleatoria18 = "ESTERNOCLEIDOMASTOIDEO Y OTRAS 10 PARALABRAS QUEMADAS PARA JUGAR AL AHORCADO COMO UN GIL";
    string NoticiaAleatoria18 = "PONETE LOS LENTES, PA";

    string TitularAleatoria19 = "ABUELITA REAPARECE DESPUES DE CAER EN DUDOSO POZO SIN FONDO";
    string NoticiaAleatoria19 = "PONETE LOS LENTES, PA";



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
                    NumNoticiasAteatorias++;
                    break;

                case 11:
                    titular.text = TitularAleatoria11;
                    noticia.text = NoticiaAleatoria11;
                    NumNoticiasAteatorias++;
                    break;

                case 12:
                    titular.text = TitularAleatoria12;
                    noticia.text = NoticiaAleatoria12;
                    NumNoticiasAteatorias++;
                    break;

                case 13:
                    titular.text = TitularAleatoria13;
                    noticia.text = NoticiaAleatoria13;
                    NumNoticiasAteatorias++;
                    break;

                case 14:
                    titular.text = TitularAleatoria14;
                    noticia.text = NoticiaAleatoria14;
                    NumNoticiasAteatorias++;
                    break;

                case 15:
                    titular.text = TitularAleatoria15;
                    noticia.text = NoticiaAleatoria15;
                    NumNoticiasAteatorias++;
                    break;

                case 16:
                    titular.text = TitularAleatoria16;
                    noticia.text = NoticiaAleatoria16;
                    NumNoticiasAteatorias++;
                    break;

                case 17:
                    titular.text = TitularAleatoria17;
                    noticia.text = NoticiaAleatoria17;
                    NumNoticiasAteatorias++;
                    break;

                case 18:
                    titular.text = TitularAleatoria18;
                    noticia.text = NoticiaAleatoria18;
                    NumNoticiasAteatorias++;
                    break;

                case 19:
                    titular.text = TitularAleatoria19;
                    noticia.text = NoticiaAleatoria19;
                    NumNoticiasAteatorias = 1;
                    CualLista = 0;
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
                    NumNoticiasAteatorias++;
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
                case 11:
                    titular.text = TitularAleatoria11;
                    noticia.text = NoticiaAleatoria11;
                    NumNoticiasAteatorias++;
                    break;

                case 12:
                    titular.text = TitularAleatoria12;
                    noticia.text = NoticiaAleatoria12;
                    NumNoticiasAteatorias++;
                    break;

                case 13:
                    titular.text = TitularAleatoria13;
                    noticia.text = NoticiaAleatoria13;
                    NumNoticiasAteatorias++;
                    break;

                case 14:
                    titular.text = TitularAleatoria14;
                    noticia.text = NoticiaAleatoria14;
                    NumNoticiasAteatorias++;
                    break;

                case 15:
                    titular.text = TitularAleatoria15;
                    noticia.text = NoticiaAleatoria15;
                    NumNoticiasAteatorias++;
                    break;

                case 16:
                    titular.text = TitularAleatoria16;
                    noticia.text = NoticiaAleatoria16;
                    NumNoticiasAteatorias++;
                    break;

                case 17:
                    titular.text = TitularAleatoria17;
                    noticia.text = NoticiaAleatoria17;
                    NumNoticiasAteatorias++;
                    break;

                case 18:
                    titular.text = TitularAleatoria18;
                    noticia.text = NoticiaAleatoria18;
                    NumNoticiasAteatorias++;
                    break;

                case 19:
                    titular.text = TitularAleatoria19;
                    noticia.text = NoticiaAleatoria19;
                    NumNoticiasAteatorias = 1;
                    CualLista = 1;
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
                    NumNoticiasAteatorias++;
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
                    NumNoticiasAteatorias++;
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

                case 12:
                    titular.text = TitularAleatoria11;
                    noticia.text = NoticiaAleatoria11;
                    NumNoticiasAteatorias++;
                    break;

                case 14:
                    titular.text = TitularAleatoria12;
                    noticia.text = NoticiaAleatoria12;
                    NumNoticiasAteatorias++;
                    break;

                case 13:
                    titular.text = TitularAleatoria13;
                    noticia.text = NoticiaAleatoria13;
                    NumNoticiasAteatorias++;
                    break;

                case 11:
                    titular.text = TitularAleatoria14;
                    noticia.text = NoticiaAleatoria14;
                    NumNoticiasAteatorias++;
                    break;

                case 16:
                    titular.text = TitularAleatoria15;
                    noticia.text = NoticiaAleatoria15;
                    NumNoticiasAteatorias++;
                    break;

                case 18:
                    titular.text = TitularAleatoria16;
                    noticia.text = NoticiaAleatoria16;
                    NumNoticiasAteatorias++;
                    break;

                case 17:
                    titular.text = TitularAleatoria17;
                    noticia.text = NoticiaAleatoria17;
                    NumNoticiasAteatorias++;
                    break;

                case 19:
                    titular.text = TitularAleatoria18;
                    noticia.text = NoticiaAleatoria18;
                    NumNoticiasAteatorias=1;
                    CualLista = 2;
                    break;

                case 15:
                    titular.text = TitularAleatoria19;
                    noticia.text = NoticiaAleatoria19;
                    NumNoticiasAteatorias++;
                    break;
            }
        }
    }
}
