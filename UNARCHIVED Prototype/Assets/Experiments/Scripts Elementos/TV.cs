using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


// hola si funciona
// hola si funciona 2
public class TV : MonoBehaviour
{
    public TMP_Text titular;
    public TMP_Text noticia;
    [SerializeField] TimeManager TimeManager;
    [SerializeField] Bitacoras bitacoras;
    [SerializeField] Libreta libreta;
    [SerializeField] PC PC;
    [SerializeField] Acciones A;
    [SerializeField] private Sprite[] Reporteros;
    [SerializeField] Image Reportero;
    [SerializeField] Image ReporteroDef;
    [SerializeField] Image FondoTV;
    [SerializeField] Image FondeoTVDef;
    [SerializeField] Image ImgNoticiaDef;
    [SerializeField] Image ImgNoticia;
    [SerializeField] private Sprite[] vcImgNoticia;
    [SerializeField] SonidosManagement Sonidos;
    bool x;
    int CualLista;
    int NumNoticiasAteatorias = 1;

    private void Start()
    {
        CualLista = Random.Range(0, 3);
        NoticiasAliatorias();
        Sonidos = FindObjectOfType<SonidosManagement>();
    }

    int EliminarRetencion = 2;
    int LavarRetencion = 3;
    int InvestigarRetencion = 4;
    int HackearRetencion = 3;
    int DifamarRetencion = 1;
    int CrearEscenaRetencion = 3;
    int AislarRetencion = 3;
    int LevantarCercaRetencion = 1;



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
    string RumoresPuebloPimientaTitulo = "BIZARRO RUMOR TOMA MODERADO VUELO EN EL TRANQUILO PUEBLO PIMIENTA";
    string RumoresPuebloPimientaNoticia = "BIZARRO RUMOR TOMA MODERADO VUELO EN PUEBLO PIMIENTA ??CREER O REVENTAR? " + System.Environment.NewLine +  "LAS RESPUESTAS SE ACERCAN";

    public bool BenEntrevista1; //aviso de que se har?? la entrevista
    string BenEntrevistaTitulo1 = "ENTREVISTA EXCLUSIVA CON NI??O AVISTADOR DE MISTERIOSA CRIATURA MA??ANA A LAS 12 AM. ";
    string BenEntrevistaNoticia1 = "ENTREVISTA EXCLUSIVA CON NI??O AVISTADOR DE MISTERIOSA CRIATURA! BENJI CONTAR?? TODO EN ESTE MISMO CANAL MA??ANA A LAS 12 AM.";

    bool BenEntrevista1b;
    string BenEntrevistaTitulo1b = "REITERAMOS: ENTREVISTA EXCLUSIVA CON NI??O AVISTADOR DE MISTERIOSA CRIATURA HOY A LAS 12 AM";
    string BenEntrevistaNoticia1b = "REITERAMOS: BENJI EL PISPIADOR CONTAR?? TODO EN IMPERDIBLE EXCLUSIVA HOY A LAS 12 AM.";

    public bool BenEntrevista2; // entrevista de ben
    string BenEntrevistaTitulo2 = "\"ERA PIE GRANDE Y LO V?? EN PARQUE PIMIENTA\". PELUDAS DECLARACIONES!!!";
    string BenEntrevistaNoticia2 = "BENJI EL PISPIADOR CONFIRMA QUE LA CRIATURA EN PARQUE PIMIENTA SE TRATA DE EL M??TICO PIE GRANDE. PERO...??QUI??N ERA LA COLORADA?";

    bool BenEntrevista3;
    string BenEntrevistaTitulo3 = "TURBA ENFURECIDA SE DIRIJE A PARQUE PIMIENTA EN B??SQUEDA DE BENJI EL PISPIADOR";
    string BenEntrevistaNoticia3 = "TURBA ENFURECIDA SE DIRIJE A PARQUE PIMIENTA EN B??SQUEDA DE BENJI ??DONDE EST?? NUESTRO PISPIADOR?";

    bool BenEntrevista3b;
    string BenEntrevistaTitulo3b = "TURBA ENTUSIASTA SE DIRIJE A PARQUE PIMIENTA EN BUSQUEDA DE CRIATURA";
    string BenEntrevistaNoticia3b = "TURBA ENTUSIASTA SE DIRIJE A PARQUE PIMIENTA EN BUSQUEDA DE CRIATURA";

    bool BenEntrevista4;
    string BenEntrevistaTitulo4 = "TURBA AMATEUR ES ATACADA POR CRIATURA MONSTRUOSA EN PARQUE PIMIENTA!";
    string BenEntrevistaNoticia4 = "TURBA AMATEUR ES ATACADA POR MONSTRUOSA CRIATURA EN PARQUE PIMIENTA! MASACRE A PLENA LUZ DEL DIA!";

    bool BenEliminado;
    string BenDesapareceTitulo = "NI??O TESTIGO DESAPARECE. ??ES PIE GRANDE EL CULPABLE O EL GOBIERNO?";
    string BenDesapareceNoticia = "BENJI EL PISPIADOR HA DESAPARECIDO SIN DEJAR RASTRO ??RAPTADO POR LA CRIATURA? ??O BAJO ORDENES DEL GOBIERNO?";

    bool BenBombaCasa;
    string BenBombaCasaTitulo = "CASA DE BEN BENJI VUELA EN ALEVOSA EXPLOSI??N. ??QUE EST?? PASANDO EN PUEBLO PIMIENTA?";
    string BenBombaCasaNoticia = "CASA DE BEN BENJI VUELA EN ALEVOSA EXPLOSI??N. ??QUE EST?? PASANDO EN PUEBLO PIMIENTA?";

    bool BenBombaEscuela;
    string BenBombaEscuelaTitulo = "ESCUELA  EXPLOTA! ??QUE ESTA PASANDO EN PUEBLO PIMIENTA?";
    string BenBombaEscuelaNoticia = "ESCUELA EXPLOTA EN PUEBLO PIMIENTA! GRACIAS A LA GRACIA DEL SE??OR NO HAY VICTIMAS AL ENCONTRARSE TODOS EN EXCURSION BARRIAL.";

    bool IbelieveinPispiador;
    string IbelieveinPispiadorTitulo = "";
    string IbelieveinPispiadorNoticia = "EXTRA??O MOVIMIENTO UNDERGROUND ARRANCA EN PUEBLO PIMIENTA. \"I BELIEVE IN EL PISPIADOR\"";//WIP AGREGAR FOTOS Y UBICAR ESTO


    bool BenBrainwash;
    string BenBrainwashTitulo = "NI??O AVISTADOR NIEGA TODO Y CANCELA ENTREVISTA ??COBARDE MENTIROSO O CONSPIRADOR?";//ANTES DE LA ENTREVISTA
    string BenBrainwashNoticia = "EL PISPIADOR NIEGA TODO Y CANCELA FUTURAS ENTREVISTAS ??COBARDE MENTIROSO O CONSPIRADOR EN POTENCIA?";


    bool BenPostBrainwash1;
    string BenPostBrainwas1hTitulo = "\"A MI HIJO LE HICIERON ALGO\" FAMILIAN DE BENJI COMPARTE QUE EL JOVEN YA NO ES EL MISMO";//despues DE LA ENTREVISTA
    string BenPostBrainwash1Noticia = "\"A MI HIJO LE HICIERON ALGO\" FAMILIAN DE BENJI COMPARTE QUE EL JOVEN YA NO ES EL MISMO";//WIP AGREGAR FOTOS Y UBICAR ESTO

    bool BenPostBrainwash2;
    string BenPostBrainwash2Titulo = "NEUROLOGO LOCAL CONFIRMA \"A BENJI LE FRISLARON LA CAPUCHA \" ";
    string BenPostBrainwash2Noticia = "NEUROLOGO LOCAL CONFIRMA: \"A BENJI LE FRISLARON LA CAPUCHA\"" + System.Environment.NewLine + "??QUI??N EST?? TRATANDO DE OCULTAR LA VERDAD?";//WIP AGREGAR FOTOS Y UBICAR ESTO


    bool BenDifamado1;
    string BenDifamadoTitulo1 = "NI??O MENTIROSO MIENTE DEVUELTA. 10 MENTIRAS QUE BENJI YA TE DIJO Y NO SAB??AS!"; ///ESTE ES EL CASO Hackeado = false
    string BenDifamadoNoticia1 = "10 MENTIRAS QUE BENJI YA TE DIJO Y NI TE HAB??AS ENTERADO! ??DONDE EMPIEZA LA MITOMAN??A?" + System.Environment.NewLine + "??EN EL HOGAR O EN LAS AULAS?";///ESTE ES EL CASO Hackeado = false

    bool BenDifamado2;
    string BenDifamadoTitulo2 = "ENTUSIASTA AVISTADOR DE PIE GRANDES RESULTA TERRORISTA AMATEUR! PERPETUA PARA BENJI"; ///ESTE ES EL CASO Hackeado = true
    string BenDifamadoNoticia2 = "EXPLOSIVA REVELACI??N DESENMASCA A BENJI EL PISPIADOR COMO TERRORISTA AMATEUR! PUEBLO PIMIENTA PIDE PERPETUA"; ///ESTE ES EL CASO Hackeado = true

    bool TurbaReclamaDia5;
    string TurbaReclamaDia5Titulo = "TURBA ENFURECIDA RECLAMA LEVANTAMIENTO DE CERCA FRENTE A PARQUE PIMIENTA";
    string TurbaReclamaDia5Noticia = "TURBA AMATEUR RECLAMA CON VIGOR LA QUITA DEL CERCO FRENTE A PARQUE PIMIENTA";

    bool TurbaReclamaDia6;
    string TurbaReclamaDia6Titulo = "TURBA ENFURECIDA RECLAMA LEVANTAMIENTO DE CERCA FRENTE A PARQUE PIMIENTA";
    string TurbaReclamaDia6Noticia = "TURBA AMATEUR ENFURECIDA RECLAMA CON AHINCO LA QUITA DEL CERCO FRENTE A PARQUE PIMIENTA";

    bool TurbaReclamaDia7;
    string TurbaReclamaDia7Titulo = "TURBA ENFURECIDA RECLAMA LEVANTAMIENTO DE CERCA FRENTE A PARQUE PIMIENTA";
    string TurbaReclamaDia7Noticia = "FURIOSA TURBA RECLAMA CON FRENES?? LA QUITA DEL CERCO FRENTE A PARQUE PIMIENTA";

    //============================================================================ TV Pie Grande ===================================================================//
    bool PieGrandeEliminado;
    string PieGrandeEliminadoTitulo = "REVELACIONES PELUDAS! LA NOVIA SECRETA DE PIE GRANDE DECLARA TODO HOY A LAS 17";
    string PieGrandeEliminadoNoticia = "??LTIMO MOMENTO! LA IDENTIDAD DE LA COLORADA SE REVELA? DECLARAR?? TODO HOY A LAS 17 HS";

    bool KateEliminado2;
    string PieGrandeEliminadoTitulo2 = "PIE GRANDE ERA MI FIANC??. REAPARECE KATE MILLIARD Y CUENTA TODO!";
    string PieGrandeEliminadoNoticia2 = "PELUDAS DECLARACIONES! \"PIE GRANDE ERA MI FIANC??...\" REAPARECE KATE MILLIARD Y CUENTA TODO! PERO TODO TODO!";

    bool PieGrandeDifamado;
    string PieGrandeDifamadoTitulo = "TE EXPLICAMOS CON CIENCIA 10 MOTIVOS QUE DEMUESTRAN QUE PIE GRANDE ES UN SALAME";
    string PieGrandeDifamadoNoticia = "TE EXPLICAMOS CON CIENCIA 10 MOTIVOS QUE DEMUESTRAN QUE PIE GRANDE ES UN SALAME";//wip
    //============================================================================ TV Kate Milliard ===================================================================//
    bool KateEliminada;
    string KateEliminadaTitulo = "EMERGENCIA! MOSTRUOSA CRIATURA ATACA PUEBLO PIMIENTA!";
    string KateEliminadaNoticia = "ALERTA DE CRISIS! MOSTRUOSA CRIATURA ATACA PUEBLO PIMIENTA! LAS AUTORIDADES LOCALES PIDEN AYUDA INMEDIATA!";

    string KateEliminadaTitulo2 = "PUEBLO PIMIENTA DESTRUIDO! HA SIDO POR ARRASADO POR ENLOQUECIDA MARA??A DE PELOS";
    string KateEliminadaNoticia2 = "PUEBLO PIMIENTA DESTRUIDO! EL TRANQUILO POBLADO HA SIDO POR ARRASADO POR ENLOQUECIDA MARA??A DE PELOS";

    bool KateDifamada;
    string KateDifamadaNoticia = "ASISTENTE DE KATE MILLIARD DECLARA:\" PATE?? UN MONO EN EL SET DURANTE LA FILMACI??N DE BANANORRAMA\"";
    string KateDifamadaTitulo = "ASISTENTE DE KATE MILLIARD DECLARA: \"PATE?? UN MONO EN EL SET DURANTE LA FILMACI??N DE BANANORRAMA\"";

    bool CrearEscena;
    string CrearEscenaTitulo = "HOMBRE PELUDO Y COLORADA DESMIENTEN LOS DICHOS DE BENJI ??ERA FALSO EL RUMOR?";
    string CrearEscenaNoticia = "HOMBRE PELUDO Y COLORADA DESMIENTEN TODOS LOS DICHOS DEL PISPIADOR ??BENJI NOS PAPARRUCHE???";

    bool Casamiento;
    string CasamientoTitulo = "KATE MILLIARD REAPARECE Y ANUNCIA CASAMIENTO CON PIE GRANDE! LAS LEYENDAS ERAN CIERTAS Y AMOROSAS!";
    string CasamientoNoticia = "\"NOS CASAMOS!\"KATE MILLIARD ANUNCIA CASAMIENTO CON PIE GRANDE! LAS LEYENDAS ERAN CIERTAS Y AMOROSAS!";


    bool ColoradaDifamada;
    string ColoradaDifamadaTitulo = "NINF??MANA CABELLOS DE SAT??N REALIZA ACTOS INDEBIDOS ANTE LA JUVENTUD. MANTENGAN A SUS HIJOS BAJO LLAVE.";
    string ColoradaDifamadaNoticia = "NINF??MANA CABELLOS DE SAT??N REALIZA ACTOS INDEBIDOS ANTE LA JUVENTUD. MANTENGAN A SUS HIJOS BAJO LLAVE.";

    //============================================================================ TV Pimientapaluza ===================================================================//
    string PimientaPaluzaAnuncioTitulo = "SE APROXIMA EL PIMIENTAPALUZA! TODOS PREPARADOS PARA EL 28"; //EL 24
    string PimientaPaluzaAnuncioNoticia = "SE APROXIMA EL PIMIENTAPALUZA! EL FESTIVAL MAS GRANDE DEL PLANETA DA COMIENZA ESTE 28 EN PARQUE PIMIENTA. ENTRADAS AGOTADAS!";

    public bool PimientapaluzaSeAdelanta;
    string PimientaPaluzaSeAdelantaTitulo = "PIMIENTAPALUZA SE ADELANTA AL 27/03";//EL 25
    string PimientaPaluzaSeAdelantaNoticia = "PIMIENTAPALUZA SE ADELANTA AL 27. EL FESTIVAL AGREGA UN D??A DANDO INICIO ANTES DE LO ESPERADO. ENTRADAS AGOTADAS!";

    string PimientaPaluzaMa??anaTitulo = "PIMIENTAPALUZA COMIENZA MA??ANA";//EL 26
    string PimientaPaluzaMa??anaNoticia = "PIMIENTAPALUZA COMIENZA MA??ANA. EL FESTIVAL SE ADELANT?? UN D??A COMENZANDO AHORA EL 27/03 ";

    string PimientaPaluzaArrancaTitulo = "DA INICIO EL PIMIENTAPALUZA";//EL 27
    string PimientaPaluzaArrancaNoticia = "DA INICIO EL PIMIENTAPALUZA!EL FESTIVAL DE M??SICA MAS GRANDE DEL PLANETA HA DADO COMIENZO EN PARQUE PIMIENTA";

    public bool PimientaPaluzaNoPuedeEntrar;
    string PimientaPaluzaNoPuedeEntrarTitulo1 = "PIMIENTAPALUZA NO PUEDE COMENZAR DEBIDO A MISTERIOSA CERCA";
    string PimientaPaluzaNoPuedeEntrarNoticia1 = "PIMIENTAPALUZA NO PUEDE SER MONTADO DEBIDO A MISTERIOSA CERCA. ORGANIZADORES RECLAMAN INGRESO A PARQUE PIMIENTA";

    bool Pimientapaluzaaislado;
    string PimientaPaluzaAisladoTitulo = "CERCA GIGANTE RODEA LA CERCA GIGANTE DEL PIMIENTAPALUZA";
    string PimientaPaluzaAisladoNoticia = "MISTERIOSA CERCA SE CIERRA SOBRE EL FESTIVAL. PIMIENTAPALUZERS SE MUESTRAN AP??TICOS ANTE ESTE SUCESO.";

    bool PimientaPaluzaLevantarCerca;
    string PimientaPaluzaLevantarCercaTitulo = "MISTERIOSA CERCA QUE RODEABA AL PIMIENTAPALUZA DESAPARECE MISTERIOSAMENTE";
    string PimientaPaluzaLevantarCercaNoticia = "\"SE FU?? COMO LLEG??\". MISTERIOSA CERCA QUE RODEABA AL PIMIENTAPALUZA DESAPARECE MISTERIOSAMENTE. ";

    bool PimientapaluzaDifamado;
    string PimientapaluzaDifamadoTitulo = "PIMIENTAPALUZA HACE CAMBIO DE LINEUP A ??LTIMO MOMENTO";
    string PimientapaluzaDifamadoNoticia = "PIMIENTAPALUZA HACE CAMBIO DE LINEUP A ??LTIMO MOMENTO. PROPONE 4 DIAS SEGUIDOS DE REGGAETON";

    bool BananorramaDifamadoTV;
    string BananorramaDifamadoTVTitulo = "ACUSAN AL FILM BANANORRAMA DE TENER MENSAJES SUBLIMINALES INDECENTES. \"MI HIJO AHORA TIENE IDEAS.\"";
    string BananorramaDifamadoTVNoticia = "ACUSAN AL FILM BANANORRAMA DE TENER MENSAJES SUBLIMINALES INDECENTES. \"MI HIJO AHORA TIENE IDEAS.\"";


    bool PimientapaluzaCancelado;
    string PimientaPaluzaCanceladoTitulo = "??PIMIENTA PALUZA CANCELADO! DON PALUZA DEVUELVE LA PLATA. QUE AGRADABLE SUJETO";
    string PimientaPaluzaCanceladoNoticia = "??PIMIENTA PALUZA CANCELADO! DON PALUZA DEVUELVE LA PLATA. QUE AGRADABLE SUJETO";
    //============================================================================ TV Pimientapaluzers ===================================================================//
    bool PimientapaluzersEliminado;
    string PimientapaluzersTitulo = "??MASACRE FRENTE A PARQUE PIMIENTA!";
    string PimientapaluzersNoticia = "SANGRE Y PULSERAS POR DOQUIER. ??MASACRE FRENTE A PARQUE PIMIENTA! LLUVIA DE MUNICIONES DESCIENDE SOBRE PIMIENTAPALUZERS";

    bool PimientapaluzersDifamado;
    string PimientapaluzersTitulo2 = "ESTUDIO DEMUESTRA QUE SER PIMIENTAPALUZER EQUIVALE A SER UN POSER";
    string PimientapaluzersNoticia2 = "ESTUDIO DEMUESTRA QUE SER PIMIENTAPALUZER EQUIVALE A SER UN POSER";

    bool PimientapaluzersReclamanDia6;
    string PimientapaluzersReclamanDia6Titulo = "PIMIENTAPALUZERS RECLAMAN INGRESO A PARQUE PIMIENTA";
    string PimientapaluzersReclamanDia6Noticia = "PIMIENTAPALUZERS RECLAMAN INGRESO A PARQUE PIMIENTA. TENGO MI ENTRADA Y NO MI PALUZA!";

    bool PimientapaluzersReclamanDia7;
    string PimientapaluzersReclamanDia7Titulo = "PIMIENTAPALUZERS RECLAMAN INGRESO A PARQUE PIMIENTA";
    string PimientapaluzersReclamanDia7Noticia = "PIMIENTAPALUZERS RECLAMAN INGRESO A PARQUE PIMIENTA. TENGO MI ENTRADA Y NO MI PALUZA!";

    bool PimientapaluzerEncuentraCuevaPieGrande;
    string PimientapaluzerEncuentraCuevaPieGrandeTitulo = "PIMIENTAPALUZER ENCUENTRA LA CUEVA SECRETA DE PIE GRANDE. \"ME PERD?? VOLVIENDO DE LOS BA??OS\"";
    string PimientapaluzerEncuentraCuevaPieGrandeNoticia = "PIMIENTAPALUZER ENCUENTRA LA CUEVA SECRETA DE PIE GRANDE. \"ME PERD?? VOLVIENDO DE LOS BA??OS\"";

    //============================================================================ TV Pepe Que??o ===================================================================//
    bool PepeQue??oEliminado1;
    string PepeQue??oTitulo1 = "BENJI EL PISPIADOR ORGANIZA B??SQUEDA POR SU AMIGO IMAGINARIO"; //Parte 1
    string PepeQue??oNoticia1 = "BENJI EL PISPIADOR ORGANIZA B??SQUEDA POR SU AMIGO IMAGINARIO";

    bool PepeQue??oEliminado2;
    string PepeQue??oTitulo2 = "NADIE SE PRESENTA A BUSQUEDA DE NI??O PELUDO, TRISTE Y RARO"; //Parte 2
    string PepeQue??oNoticia2 = "NADIE SE PRESENTA A BUSQUEDA DE NI??O PELUDO, TRISTE Y RARO";

    bool FotosAnonimas;
    string FotosAnonimasTitulo = "RECIBIMOS FOTOS AN??NIMAS DEL EXTRA??O AVISTAMIENTO EN PARQUE PIMIENTA"; //Parte 2
    string FotosAnonimasNoticia = "RECIBIMOS FOTOS AN??NIMAS DEL EXTRA??O AVISTAMIENTO EN PARQUE PIMIENTA ??QU?? DICEN QUE SE VE AH???";

    //============================================================================ TV Parque Pimienta =============================================================================//
    bool ParquePimientaAislado1;
    string ParquePimientaTitulo1 = "MISTERIOSA CERCA RODEA PARQUE PIMIENTA!";
    string ParquePimientaNoticia1 = "MISTERIOSA CERCA RODEA PARQUE PIMIENTA!??QUE EST?? PASANDO EN PUEBLO PIMIENTA?";

    bool ParquePimientaLevantarCerca;
    string ParquePimientaLevantarCercaTitulo = "\"COMO LLEG?? SE FU??.\" QUITAN CERCA QUE RODEABA PARQUE PIMIENTA";
    string ParquePimientaLevantarCercaNoticia = "\"COMO LLEG?? SE FU??.\" QUITAN CERCA QUE RODEABA PARQUE PIMIENTA";

    bool ParquePimientaAislado2;
    string ParquePimientaTitulo2 = "MISTERIOSA CERCA RODEA PARQUE PIMIENTA!";
    string ParquePimientaNoticia2 = "MISTERIOSA CERCA RODEA PARQUE PIMIENTA!??QUE EST?? PASANDO EN PUEBLO PIMIENTA?";

    bool ParquePimientaAislado3;
    string ParquePimientaTitulo3 = ""; //Pimienta paluza hackeado = true y pepe/ben eliminado/lavado = false
    string ParquePimientaNoticia3 = ""; //Pimienta paluza hackeado = true

    bool ParquePimientaAislado4;
    string ParquePimientaTitulo4 = ""; //Pimienta paluza hackeado = true Kate/PieGrande eliminado/lavado = false
    string ParquePimientaNoticia4 = ""; //Pimienta paluza hackeado = true

    bool ParquePimientaDifamado;
    string ParquePimientaDifamadoTitulo = "TURISTA DECLARA: ME AGARR?? DIARREA DE LEGIONARIO EN PARQUE PIMIENTA.";
    string ParquePimientaDifamadoNoticia = "TURISTA DECLARA: ME AGARR?? DIARREA DE LEGIONARIO EN PARQUE PIMIENTA. POR QU?? NO HAY QUE VISITAR LA RESERVA";
    //============================================================================ TV Pie Grande ===================================================================//
    bool PlantarPublico;
    string PlantarPublicoTitulo = "ABUCHEOS DURANTE ENTREVISTA!LA CREDiBILIDAD DE BENJI SE DESMORONA!!";
    string PlantarPublicoNoticia = "ABUCHEOS DURANTE ENTREVISTA!LA CREDiBILIDAD DE BENJI SE DESMORONA AL MOJAR SUS PANTALONES EN TELEVISI??N NACIONAL";

    //============================================================================ TV Pueblo Pimienta ===================================================================//

    bool PuebloPimientaDifamado;
    string PuebloPimientaDifamadoTitulo = "ENCUESTA MUNDIAL INDICA QUE LOS HABITANTES DE PUEBLO PIMIENTA CREEN EN CUALQUIER COSA";
    string PuebloPimientaDifamadoNoticia = "ENCUESTA MUNDIAL INDICA QUE LOS HABITANTES DE PUEBLO PIMIENTA CREEN EN CUALQUIER COSA";

    bool PuebloPimientaAislado;
    string PuebloPimientaAisladoTitulo = "MISTERIOSA CERCA AISLA A PUEBLO PIMIENTA Y SUS HABITANTES ??QU?? EST??N INTENTANDO ESCONDER?";
    string PuebloPimientaAisladoNoticia = "MISTERIOSA CERCA AISLA A PUEBLO PIMIENTA Y SUS HABITANTES ??QU?? EST??N INTENTANDO ESCONDER?";

    bool PuebloPimientaLevantarCerca;
    string PuebloPimientaLevantarCercaTitulo = "CERCO QUE AISLABA POBLADO ENTERO DESAPARECE. LA GENTE NO ENTIENDE NADA";
    string PuebloPimientaLevantarCercaNoticia = "CERCO QUE AISLABA POBLADO ENTERO DESAPARECE. LA GENTE NO ENTIENDE NADA";

    //============================================================================ TV Red78 ===================================================================//
    bool Red78Difamada;
    string Red78DifamadaTitulo = "NINF??MANA SUELTA EN LA WEB. ??CON QUIEN CHEATEAN LOS NI??OS?";
    string Red78DifamadaNoticia = "NINF??MANA SUELTA EN LA WEB. ??CON QUIEN CHEATEAN LOS NI??OS?";

    //============================================================================ TV WifiRobado ===================================================================//

    bool WifiRobadoDifamado;
    string WifiRobadoDifamadoTitulo = "PERSONA ESCONDIDA EN PARQUE PIMIENTA LE VIVE EL WIFI A LOS GUARDABOSQUES";
    string WifiRobadoDifamadoNoticia = "PERSONA ESCONDIDA EN PARQUE PIMIENTA LE VIVE EL WIFI A LOS GUARDABOSQUES";

    //===============================================================================================================================================//


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
        SetearReportero(0);
        SetearImagenesNoticias(0);
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
        if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && TimeManager.Dia == 3 && TimeManager.Hora == 10 && BenEntrevista1 == false && bitacoras.BenRetirado == false)
        {
            int IncrementoRating = 2;
            noticia.text = BenEntrevistaNoticia1;//ENTREVISTA EXCLUSIVA CON NI??O AVISTADOR DE MISTERIOSA CRIATURA MA??ANA A LAS 12 AM
            titular.text = BenEntrevistaTitulo1;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista1 = true;
            SetearImagenesNoticias(8);
        }
        else if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && TimeManager.Dia == 4 && TimeManager.Hora == 7 && BenEntrevista1 == true && BenEntrevista1b == false && bitacoras.BenRetirado == false)
        {
            int IncrementoRating = 2;
            noticia.text = BenEntrevistaNoticia1b;//REITERAMOS: ENTREVISTA EXCLUSIVA CON NI??O AVISTADOR DE MISTERIOSA CRIATURA HOY A LAS 12 AM
            titular.text = BenEntrevistaTitulo1b;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista1b = true;
            SetearImagenesNoticias(8);
        }
        else if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && TimeManager.Dia == 4 && TimeManager.Hora == 12 && BenEntrevista2 == false && bitacoras.PlantarPublico == false && bitacoras.BenRetirado == false)
        {
            int IncrementoRating = 6;
            noticia.text = BenEntrevistaNoticia2; //"ERA PIE GRANDE Y LO V?? EN PARQUE PIMIENTA\". PELUDAS DECLARACIONES!!!
            titular.text = BenEntrevistaTitulo2;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista2 = true;
            SetearImagenesNoticias(8);
        }
        else if (TimeManager.Dia == 4 && TimeManager.Hora == 15 && BenEntrevista2 == true && BenEliminado == true)
        {
            int IncrementoRating = 5;
            noticia.text = BenEntrevistaNoticia3;//TURBA ENFURECIDA SE DIRIJE A PARQUE PIMIENTA EN B??SQUEDA DE BENJI EL PISPIADOR
            titular.text = BenEntrevistaTitulo3;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista3 = true;
            SetearImagenesNoticias(11);
        }
        else if (TimeManager.Dia == 4 && TimeManager.Hora == 15 && BenEntrevista2 == true && BenEliminado == false)
        {
            int IncrementoRating = 5;
            noticia.text = BenEntrevistaNoticia3b;//TURBA ENTUSIASTA SE DIRIJE A PARQUE PIMIENTA EN BUSQUEDA DE CRIATURA
            titular.text = BenEntrevistaTitulo3b;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista3b = true;
            SetearImagenesNoticias(11);
        }
        else if (TurbaReclamaDia5 == false && TimeManager.Dia == 5 && TimeManager.Hora == 9 && bitacoras.ParquePimientaAislado == true && libreta.LevantarCercaPuebloPimienta == false)
        {
            int IncrementoRating = 2;
            noticia.text = TurbaReclamaDia5Noticia;
            titular.text = TurbaReclamaDia5Titulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            TurbaReclamaDia5 = true;
            SetearImagenesNoticias(11);
        }
        else if (TurbaReclamaDia6 == false && TimeManager.Dia == 6 && TimeManager.Hora == 9 && bitacoras.ParquePimientaAislado == true && libreta.LevantarCercaPuebloPimienta == false)
        {
            int IncrementoRating = 2;
            noticia.text = TurbaReclamaDia6Noticia;
            titular.text = TurbaReclamaDia6Titulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            TurbaReclamaDia6 = true;
            SetearImagenesNoticias(11);
        }
        else if (TurbaReclamaDia7 == false && TimeManager.Dia == 7 && TimeManager.Hora == 9 && bitacoras.ParquePimientaAislado == true && libreta.LevantarCercaPuebloPimienta == false)
        {
            int IncrementoRating = 2;
            noticia.text = TurbaReclamaDia7Noticia;
            titular.text = TurbaReclamaDia7Titulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            TurbaReclamaDia7 = true;
            SetearImagenesNoticias(11);
        }
        else if (TimeManager.Dia == 5 && TimeManager.Hora == 16 && BenEntrevista3 == true && PieGrandeEliminado == false)
        {
            int IncrementoRating = 15;
            noticia.text = BenEntrevistaNoticia4;//TURBA AMATEUR ES ATACADA POR CRIATURA MONSTRUOSA EN PARQUE PIMIENTA!
            titular.text = BenEntrevistaTitulo4;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista4 = true;
            SetearImagenesNoticias(11);
        }
        else if (TimeManager.Dia == 5 && TimeManager.Hora == 16 && BenEntrevista3b == true && PieGrandeEliminado == false)
        {
            int IncrementoRating = 15;
            noticia.text = BenEntrevistaNoticia4;//TURBA AMATEUR ES ATACADA POR CRIATURA MONSTRUOSA EN PARQUE PIMIENTA!
            titular.text = BenEntrevistaTitulo4;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenEntrevista4 = true;
            SetearImagenesNoticias(11);
        }
        else if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && TimeManager.Dia == 4 && TimeManager.Hora == 12 && BenEntrevista2 == false && bitacoras.PlantarPublico == true)
        {
            int IncrementoRating = -3;
            noticia.text = PlantarPublicoNoticia;//ABUCHEOS DURANTE ENTREVISTA!LA CREDBILIDAD DE BEN BENJI SE DESMORONA AL MOJAR SUS PANTALONES EN TV NACIONAL
            titular.text = PlantarPublicoTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(8);

        }


        else if (TimeManager.Dia == 3 && TimeManager.Hora == 13)
        {
            int IncrementoRating = 0;
            noticia.text = PimientaPaluzaAnuncioNoticia;//se anuncia pimientapaluza
            titular.text = PimientaPaluzaAnuncioTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(4);

        }
        else if (TimeManager.Dia == 4 && TimeManager.Hora == 10)
        {
            int IncrementoRating = 0;
            noticia.text = PimientaPaluzaAnuncioNoticia;//se anuncia pimientapaluza
            titular.text = PimientaPaluzaAnuncioTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(4);

        }
        else if (BenEliminado == false && TimeManager.Dia == 5 && TimeManager.Hora == 9 && BenBombaCasa == false && bitacoras.BenRetirado == false)
        {
            int IncrementoRating = 3;
            noticia.text = BenBombaEscuelaNoticia;
            titular.text = BenBombaEscuelaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenBombaEscuela = true;
        }
        else if (BenEliminado == true && TimeManager.Dia == 5 && TimeManager.Hora == 9 && bitacoras.BenRetirado == false)
        {
            int IncrementoRating = 3;
            noticia.text = BenBombaCasaNoticia;
            titular.text = BenBombaCasaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            BenBombaCasa = true;
            SetearImagenesNoticias(8);
        }



        else if (bitacoras.ParquePimientaAislado == true && TimeManager.Dia == 5 && TimeManager.Hora == 12 && PimientaPaluzaNoPuedeEntrar == true)
        {
            int IncrementoRating = 2;
            noticia.text = PimientaPaluzaNoPuedeEntrarNoticia1;
            titular.text = PimientaPaluzaNoPuedeEntrarTitulo1;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(4);

        }

        else if (TimeManager.Dia == 5 && TimeManager.Hora == 10)
        {
            int IncrementoRating = 0;
            noticia.text = PimientaPaluzaSeAdelantaNoticia;//Pimientapaluza se adelanta
            titular.text = PimientaPaluzaSeAdelantaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(4);
        }

        else if (bitacoras.PieGrandeEliminado == true && PieGrandeEliminado == true && TimeManager.Dia == 5 && TimeManager.Hora == 17 && KateEliminado2 == false)
        {
            int IncrementoRating = 8;
            noticia.text = PieGrandeEliminadoNoticia2; //PIE GRANDE ERA MI FIANC??. REAPARECE KATE MILLIARD Y CUENTA TODO!
            titular.text = PieGrandeEliminadoTitulo2;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            PieGrandeEliminado = true;
            SetearImagenesNoticias(3);
        }
        else if (TimeManager.Dia == 6 && TimeManager.Hora == 10 && PimientaPaluzaNoPuedeEntrar == false)
        {
            int IncrementoRating = 0;
            noticia.text = PimientaPaluzaMa??anaNoticia;//Pimientapaluza Ma??ana
            titular.text = PimientaPaluzaMa??anaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(4);
        }

        else if (TimeManager.Dia == 6 && TimeManager.Hora == 10 && PimientaPaluzaNoPuedeEntrar == true)
        {
            int IncrementoRating = 2;
            noticia.text = PimientaPaluzaNoPuedeEntrarNoticia1;//Organizadores  reclaman que levanten cerca
            titular.text = PimientaPaluzaNoPuedeEntrarNoticia1;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(4);
        }

        else if (TimeManager.Dia == 7 && TimeManager.Hora == 10 && PimientaPaluzaNoPuedeEntrar == false)
        {
            int IncrementoRating = 0;
            noticia.text = PimientaPaluzaArrancaNoticia;//Pimientapaluza Arranca
            titular.text = PimientaPaluzaArrancaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(4);
        }

        else if (TimeManager.Dia == 7 && TimeManager.Hora == 10 && PimientaPaluzaNoPuedeEntrar == true)
        {
            int IncrementoRating = 2;
            noticia.text = PimientaPaluzaNoPuedeEntrarNoticia1;//Pimientapaluza no puede arrancar
            titular.text = PimientaPaluzaNoPuedeEntrarNoticia1;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(4);
        }

        else if (bitacoras.KateEliminada == false && bitacoras.KateLavada == false && PieGrandeEliminado == false && KateEliminada == false && TimeManager.Dia == 7 && TimeManager.Hora == 17 && bitacoras.KateProteccionAceptada == false)
        {
            int IncrementoRating = 15;
            noticia.text = CasamientoNoticia;//KATE MILLIARD ANUNCIA CASAMIENTO CON PIE GRANDE! LAS LEYENDAS ERAN CIERTAS!
            titular.text = CasamientoTitulo; // WIP (pregunta de sofi) ??No deberia poder evitarse lavandole el cerebro a kate?
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(7);
        }

        /*else if (TimeManager.Dia == 5 && TimeManager.Hora == 6 && BenEntrevista2 == false && bitacoras.PepeEliminado == false && bitacoras.PepeLavado == false && FotosAnonimas == false)
        {
            int IncrementoRating = 6;
            noticia.text = FotosAnonimasNoticia;
            titular.text = FotosAnonimasTitulo; 
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(12); ;
        }*/
        else if (bitacoras.PimientaPaluzaAislado == true && bitacoras.PimientaPaluzaCancelado == false && TimeManager.Dia == 6 && TimeManager.Hora == 6 && Pimientapaluzaaislado == false)
        {
            int IncrementoRating = 2;
            noticia.text = PimientapaluzersReclamanDia6Titulo;
            titular.text = PimientapaluzersReclamanDia6Noticia;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo();}
            x = true;
            SetearImagenesNoticias(5);
            PimientapaluzersReclamanDia6 = true;

        }

        else if (bitacoras.PimientaPaluzaAislado == true && bitacoras.PimientaPaluzaCancelado == false && TimeManager.Dia == 7 && TimeManager.Hora == 7)
        {
            int IncrementoRating = 2;
            noticia.text = PimientapaluzersReclamanDia7Titulo;
            titular.text = PimientapaluzersReclamanDia7Noticia;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(5);
            PimientapaluzersReclamanDia7 = true;

        }

        else if (bitacoras.PimientaPaluzaAislado == false && bitacoras.PimientaPaluzaCancelado == false && PimientapaluzaCancelado == false && bitacoras.ConvertirCueva == false && TimeManager.Dia == 7 && TimeManager.Hora == 12)
        {
            int IncrementoRating = 16;
            noticia.text = PimientapaluzerEncuentraCuevaPieGrandeTitulo;
            titular.text = PimientapaluzerEncuentraCuevaPieGrandeNoticia;
            ;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(5);
            PimientapaluzerEncuentraCuevaPieGrande = true;

        }

        //============================================================================ TV RUMOR =============================================================================//
        else if (TimeManager.Dia == 3 && TimeManager.Hora == 7)
        {
            int IncrementoRating = 2;
            noticia.text = RumoresPuebloPimientaNoticia;//BIZARRO RUMOR TOMA MODERADO VUELO EN PUEBLO PIMIENTA
            titular.text = RumoresPuebloPimientaTitulo;
            PC.Rating = PC.Rating + IncrementoRating;
            if (PC.Rating >= 16) { PC.RatinMaximo(); }
            x = true;
            SetearImagenesNoticias(1);
        }
        //============================================================================ TV Ben Benji =============================================================================//
        else if (bitacoras.BenEliminado == true && BenEliminado == false)
        {
            int IncrementoRating = 3;
            int RetencionNoticia = EliminarRetencion;
            StartCoroutine(ImprimirNoticia(BenDesapareceTitulo, BenDesapareceNoticia, IncrementoRating, RetencionNoticia));
            BenEliminado = true;
        }

        else if (bitacoras.BenLavado == true && BenBrainwash == false)
        {
            int IncrementoRating = 1;
            int RetencionNoticia = LavarRetencion;
            StartCoroutine(ImprimirNoticia(BenBrainwashTitulo, BenBrainwashNoticia, IncrementoRating, RetencionNoticia));
            BenBrainwash = true;
        }
        else if (bitacoras.BenDifamado == true && bitacoras.BenHackeado2 == false && BenDifamado1 == false)// Hackeado = false
        {
            int IncrementoRating = -2;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(BenDifamadoTitulo1, BenDifamadoNoticia1, IncrementoRating, RetencionNoticia));
            BenDifamado1 = true;
        }
        else if (bitacoras.BenEliminado == false && bitacoras.BenLavado == false && bitacoras.BenRetirado == true && BenDifamado2 == false)// Hackeado = true
        {
            int IncrementoRating = -4;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(BenDifamadoTitulo2, BenDifamadoNoticia2, IncrementoRating, RetencionNoticia));
            BenDifamado1 = true;
            BenDifamado2 = true;
        }
        //============================================================================ TV Pueblo Pimienta ===================================================================//

        else if (bitacoras.PuebloPimientaDifamado == true && PuebloPimientaDifamado == false)// 
        {
            int IncrementoRating = -1;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(PuebloPimientaDifamadoTitulo, PuebloPimientaDifamadoNoticia, IncrementoRating, RetencionNoticia));
            PuebloPimientaDifamado = true;
        }

        else if (bitacoras.PuebloPimientaAislado == true && PuebloPimientaAislado == false)// 
        {
            int IncrementoRating = 8;
            int RetencionNoticia = AislarRetencion;
            StartCoroutine(ImprimirNoticia(PuebloPimientaAisladoTitulo, PuebloPimientaAisladoNoticia, IncrementoRating, RetencionNoticia));
            PuebloPimientaAislado = true;
        }


        else if (bitacoras.PuebloPimientaLevantarCerca == true && PuebloPimientaLevantarCerca == false)// 
        {
            int IncrementoRating = 2;
            int RetencionNoticia = LevantarCercaRetencion;
            StartCoroutine(ImprimirNoticia(PuebloPimientaLevantarCercaTitulo, PuebloPimientaLevantarCercaNoticia, IncrementoRating, RetencionNoticia));
            PuebloPimientaLevantarCerca = true;
        }
        //============================================================================ TV Bananorrama ===================================================================//

        else if (bitacoras.BananorramaDifamado == true && BananorramaDifamadoTV == false)// Hackeado = false
        {
            int IncrementoRating = -2;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(BananorramaDifamadoTVTitulo, BananorramaDifamadoTVNoticia, IncrementoRating, RetencionNoticia));
            BananorramaDifamadoTV = true;
        }
        //============================================================================ TV Pimientapaluza ===================================================================//


        else if (bitacoras.PimientaPaluzaDifamado == true && PimientapaluzaDifamado == false)// 
        {
            int IncrementoRating = -1;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(PimientapaluzaDifamadoTitulo, PimientapaluzaDifamadoNoticia, IncrementoRating, RetencionNoticia));
            PimientapaluzaDifamado = true;
        }
        else if (bitacoras.PimientaPaluzaCancelado == true && PimientapaluzaCancelado == false)
        {
            int IncrementoRating = -1;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(PimientaPaluzaCanceladoTitulo, PimientaPaluzaCanceladoNoticia, IncrementoRating, RetencionNoticia));
            PimientapaluzaCancelado = true;
        }


        //============================================================================ TV Pie Grande ===================================================================//
        else if (bitacoras.PieGrandeEliminado == true && PieGrandeEliminado == false && KateEliminada == false)
        {
            int IncrementoRating = 5;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(PieGrandeEliminadoTitulo, PieGrandeEliminadoNoticia, IncrementoRating, RetencionNoticia));
            PieGrandeEliminado = true;
        }

        else if (bitacoras.PieGrandeDifamado == true && PieGrandeDifamado == false)
        {
            int IncrementoRating = 3;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(PieGrandeDifamadoTitulo, PieGrandeDifamadoNoticia, IncrementoRating, RetencionNoticia));
            PieGrandeDifamado = true;
        }
        //============================================================================ TV Kate Milliard ===================================================================//

        else if (bitacoras.KateEliminada == true && PieGrandeEliminado == false && KateEliminada == false)
        {
            int IncrementoRating = 7;
            int RetencionNoticia = EliminarRetencion;
            StartCoroutine(ImprimirNoticia(KateEliminadaTitulo, KateEliminadaNoticia, IncrementoRating, RetencionNoticia));
            KateEliminada = true;
        }
        else if (bitacoras.KateEliminada == true && PieGrandeEliminado == false && KateEliminada == true)
        {
            int IncrementoRating = 13;
            int RetencionNoticia = 4; // SON 4.
            StartCoroutine(ImprimirNoticia(KateEliminadaTitulo2, KateEliminadaNoticia2, IncrementoRating, RetencionNoticia));
            KateEliminada = true;
        }

        else if (bitacoras.KateDifamada == true && KateDifamada == false)
        {
            int IncrementoRating = -2;
            int RetencionNoticia = DifamarRetencion; // SON 4.
            StartCoroutine(ImprimirNoticia(KateDifamadaTitulo, KateDifamadaNoticia, IncrementoRating, RetencionNoticia));
            KateDifamada = true;
        }

        //============================================================================ TV Colorada ===================================================================//

        else if (bitacoras.ColoradaDifamada == true && ColoradaDifamada == false)
        {
            int IncrementoRating = -1;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(ColoradaDifamadaTitulo, ColoradaDifamadaNoticia, IncrementoRating, RetencionNoticia));
            ColoradaDifamada = true;
        }

        //============================================================================ TV Red78 ===================================================================//


        else if (bitacoras.Red78Difamada == true && Red78Difamada == false)
        {
            int IncrementoRating = -1;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(Red78DifamadaTitulo, Red78DifamadaNoticia, IncrementoRating, RetencionNoticia));
            ColoradaDifamada = true;
        }

        //============================================================================ TV Wifi Robado ===================================================================//

        else if (bitacoras.WifiRobadoDifamado == true && WifiRobadoDifamado == false)
        {
            int IncrementoRating = 1;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(WifiRobadoDifamadoTitulo, WifiRobadoDifamadoNoticia, IncrementoRating, RetencionNoticia));
            WifiRobadoDifamado = true;
        }

        //============================================================================ TV Crear Escena ===================================================================//
        else if (bitacoras.CrearEscena == true && CrearEscena == false)
        {
            int IncrementoRating = -2;
            int RetencionNoticia = CrearEscenaRetencion;
            StartCoroutine(ImprimirNoticia(CrearEscenaTitulo, CrearEscenaNoticia, IncrementoRating, RetencionNoticia));
            CrearEscena = true;
        }
        //============================================================================ TV PimientaPaluza ===================================================================//


        else if (bitacoras.PimientaPaluzaAislado == true)
        {
            int IncrementoRating = 3;
            int RetencionNoticia = AislarRetencion;
            StartCoroutine(ImprimirNoticia(PimientaPaluzaAisladoTitulo, PimientaPaluzaAisladoNoticia, IncrementoRating, RetencionNoticia));
            Pimientapaluzaaislado = true;
        }


        else if (bitacoras.PimientaPaluzaLevantarCerca == true)
        {
            int IncrementoRating = 1;
            int RetencionNoticia = LevantarCercaRetencion;
            StartCoroutine(ImprimirNoticia(PimientaPaluzaLevantarCercaTitulo, PimientaPaluzaLevantarCercaNoticia, IncrementoRating, RetencionNoticia));
            PimientaPaluzaLevantarCerca = true;
        }
        //============================================================================ TV Parque Pimienta =============================================================================//
        else if (bitacoras.ParquePimientaAislado == true && ParquePimientaAislado1 == false)
        {
            int IncrementoRating = 3;
            int RetencionNoticia = AislarRetencion;
            StartCoroutine(ImprimirNoticia(ParquePimientaTitulo1, ParquePimientaNoticia1, IncrementoRating, RetencionNoticia));
            ParquePimientaAislado1 = true;

        }
        /* else if (bitacoras.ParquePimientaAislado == true && ParquePimientaAislado2 == false) 
         {
             int IncrementoRating = 0;
             int RetencionNoticia = AislarRetencion;
             StartCoroutine(ImprimirNoticia(ParquePimientaTitulo2, ParquePimientaNoticia2, IncrementoRating, RetencionNoticia));
             ParquePimientaAislado2 = true;
         }
         else if (bitacoras.ParquePimientaAislado == true && bitacoras.BenEliminado == false && bitacoras.BenLavado == false && bitacoras.PepeLavado == false && bitacoras.PepeEliminado == false && PimientaPaluzaHackeado == true && ParquePimientaAislado3 == false) // Hackeado = true Ben Pepe
         {
             int IncrementoRating = 5;
             int RetencionNoticia = 3; //wip
             StartCoroutine(ImprimirNoticia(ParquePimientaTitulo3, ParquePimientaNoticia3, IncrementoRating, RetencionNoticia));
             ParquePimientaAislado3 = true;
         }
         else if (bitacoras.ParquePimientaAislado == true && bitacoras.PieGrandeEliminado == false && bitacoras.PieGrandeLavado == false && bitacoras.KateLavada == false && bitacoras.KateEliminada == false && PimientaPaluzaHackeado == true && ParquePimientaAislado3 == false && ParquePimientaAislado4 == false) // Hackeado = true Kate Pie Grande
         {
             int IncrementoRating = 5;
             int RetencionNoticia = 3; //WIP
             StartCoroutine(ImprimirNoticia(ParquePimientaTitulo4, ParquePimientaNoticia4, IncrementoRating, RetencionNoticia));
             ParquePimientaAislado4 = true;
         }*/

        else if (bitacoras.ParquePimientaLevantarCerca == true && ParquePimientaLevantarCerca == false)
        {
            int IncrementoRating = 1;
            int RetencionNoticia = LevantarCercaRetencion;
            StartCoroutine(ImprimirNoticia(ParquePimientaLevantarCercaTitulo, ParquePimientaLevantarCercaNoticia, IncrementoRating, RetencionNoticia));
            ParquePimientaLevantarCerca = true;
        }

        else if (bitacoras.ParquePimientaDifamado == true && ParquePimientaDifamado == false)
        {
            int IncrementoRating = -1;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(ParquePimientaDifamadoTitulo, ParquePimientaDifamadoNoticia, IncrementoRating, RetencionNoticia));
            ParquePimientaDifamado = true;
        }
        //============================================================================ TV Pimientapaluzers ===================================================================//

        else if (bitacoras.PimientapaluzersEliminado == true && PimientapaluzersEliminado == false)
        {
            int IncrementoRating = 8;
            int RetencionNoticia = EliminarRetencion;
            StartCoroutine(ImprimirNoticia(PimientapaluzersTitulo, PimientapaluzersNoticia, IncrementoRating, RetencionNoticia));
            PimientapaluzersEliminado = true;
        }
        else if (bitacoras.PimientapaluzersDifamado == true && PimientapaluzersDifamado == false)
        {
            int IncrementoRating = 5;
            int RetencionNoticia = DifamarRetencion;
            StartCoroutine(ImprimirNoticia(PimientapaluzersTitulo2, PimientapaluzersNoticia2, IncrementoRating, RetencionNoticia));
            PimientapaluzersDifamado = true;
        }

        //============================================================================ TV Pepe Que??o ===================================================================//
        else if (bitacoras.PepeEliminado == true && bitacoras.BenEliminado == false && PepeQue??oEliminado1 == false)
        {
            int IncrementoRating = 0;
            int RetencionNoticia = EliminarRetencion;
            StartCoroutine(ImprimirNoticia(PepeQue??oTitulo1, PepeQue??oNoticia1, IncrementoRating, RetencionNoticia));
            PepeQue??oEliminado1 = true;
        }
        else if (bitacoras.PepeEliminado == true && bitacoras.BenEliminado == false && PepeQue??oEliminado2 == false)
        {
            int IncrementoRating = 0;
            int RetencionNoticia = EliminarRetencion;
            StartCoroutine(ImprimirNoticia(PepeQue??oTitulo2, PepeQue??oNoticia2, IncrementoRating, RetencionNoticia));
            PepeQue??oEliminado2 = true;
        }

        //=========================================================================== TV Noticia Falsa ===============================================================//
        else if (bitacoras.NoticiaFalasa1 == true && NF1 == false)
        {
            int IncrementoRating = -2;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtTituloFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF1 = true;
            SetearImagenesNoticias(10);
            SetearReportero(1);
        }
        else if (bitacoras.NoticiaFalasa2 == true && NF2 == false)
        {
            int IncrementoRating = -1;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtTituloFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF2 = true;
            SetearReportero(1);
            SetearImagenesNoticias(10);
        }
        else if (bitacoras.NoticiaFalasa3 == true && NF3 == false)
        {
            int IncrementoRating = -2;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtTituloFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF3 = true;
            SetearReportero(1);
            SetearImagenesNoticias(10);
        }
        else if (bitacoras.NoticiaFalasa4 == true && NF4 == false)
        {
            int IncrementoRating = -1;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtTituloFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF4 = true;
            SetearReportero(1);
            SetearImagenesNoticias(10);
        }
        else if (bitacoras.NoticiaFalasa5 == true && NF5 == false)
        {
            int IncrementoRating = -2;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtTituloFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF5 = true;
            SetearReportero(1);
            SetearImagenesNoticias(10);
        }
        else if (bitacoras.NoticiaFalsa6 == true && NF6 == false)
        {
            int IncrementoRating = -1;
            noticia.text = bitacoras.txtNoticiaFalsa;
            titular.text = bitacoras.txtTituloFalsa;
            PC.Rating = PC.Rating + IncrementoRating;
            x = true;
            NF6 = true;
            SetearReportero(1);
            SetearImagenesNoticias(10);
        }

    }

    IEnumerator ImprimirNoticia(string T, string N, int IncrementoRating, int RetencioNoticia)
    {
        yield return StartCoroutine(TimeManager.RetencionBitacorasSegunAccion(RetencioNoticia));
        noticia.text = N;
        titular.text = T;
        PC.Rating = PC.Rating + IncrementoRating;
        if (PC.Rating >= 16) { PC.RatinMaximo(); }
        LaFuncionMasEspecificaDelMundoPorqueEsteJugoNoDejaDeTenerDetallesBoludos();
        ImagenesNoticiasPorReacci??n();
    }

    private void LaFuncionMasEspecificaDelMundoPorqueEsteJugoNoDejaDeTenerDetallesBoludos()
    {
        if (BenDifamado2) libreta.TacharPalabra(libreta.BenBtn, libreta.txtBen, 0);
        if (FotosAnonimas == true) { A.tglExtraerFotos.SetActive(false); }

    }

    public void PulsadoDeTV()
    {
        if (ParquePimientaTitulo1 == titular.text) libreta.EscribirNuevaPalabra(libreta.BtnPimientapaluzers, 3);
        if (titular.text == PimientaPaluzaAnuncioTitulo) libreta.EscribirNuevaPalabra(libreta.BtnPimientaPaluza, 3);
        if (titular.text == PimientaPaluzaSeAdelantaTitulo) libreta.EscribirNuevaPalabra(libreta.BtnPimientaPaluza, 3);
        if (titular.text == PimientaPaluzaMa??anaTitulo) libreta.EscribirNuevaPalabra(libreta.BtnPimientaPaluza, 3);
        if (titular.text == PimientaPaluzaArrancaTitulo) libreta.EscribirNuevaPalabra(libreta.BtnPimientaPaluza, 3);

        if (titular.text == PieGrandeEliminadoTitulo2) libreta.EscribirNuevaPalabra(libreta.BtnKateMilliard, 2);
        if (titular.text == CasamientoTitulo) libreta.EscribirNuevaPalabra(libreta.BtnKateMilliard, 2);

        if (titular.text == BenEntrevistaTitulo2)
        {
            libreta.EscribirNuevaPalabra(libreta.BtnParquePimienta, 10);

        }

        if (titular.text == PimientaPaluzaAisladoTitulo) libreta.EscribirNuevaPalabra(libreta.BtnPimientapaluzers, 11);

        if (titular.text == BenEntrevistaTitulo1) A.tglPlantarPublico.SetActive(true);
        if (titular.text == BenEntrevistaTitulo1b && PlantarPublico == false) A.tglPlantarPublico.SetActive(true);


        if (titular.text == BenEntrevistaTitulo2 && A.tglLevantarCerca.activeSelf == false) A.tglAislar.SetActive(true);
        if (titular.text == BenEntrevistaTitulo3b && A.tglLevantarCerca.activeSelf == false) A.tglAislar.SetActive(true);

        if (titular.text == BenEntrevistaTitulo3 && A.tglLevantarCerca.activeSelf == false) A.tglAislar.SetActive(true);

        if (titular.text == PimientaPaluzaMa??anaTitulo && A.tglLevantarCerca.activeSelf == false) A.tglAislar.SetActive(true);
        if (titular.text == PimientaPaluzaArrancaTitulo && A.tglLevantarCerca.activeSelf == false) A.tglAislar.SetActive(true);
        if (titular.text == PimientaPaluzaSeAdelantaTitulo && A.tglLevantarCerca.activeSelf == false) A.tglAislar.SetActive(true);

        /*if (titular.text == ) A.tglCrearEscena.SetActive(true);
        */
        if (titular.text == BenEntrevistaTitulo4 && bitacoras.PieGrandeUbicacion == false) /*bitacoras.PieGrandeUbicacion == true*/;
        if (titular.text == KateEliminadaTitulo && bitacoras.PieGrandeEliminado == false) /*bitacoras.PieGrandeUbicacion == true*/;
    }

    void ImagenesNoticiasPorReacci??n()
    {
        if (KateEliminadaTitulo == titular.text) SetearImagenesNoticias(1);
        if (KateEliminadaTitulo2 == titular.text) SetearImagenesNoticias(1);

        if (ParquePimientaTitulo1 == titular.text) SetearImagenesNoticias(2);
        if (ParquePimientaTitulo2 == titular.text) SetearImagenesNoticias(2);
        if (titular.text == ParquePimientaDifamadoTitulo) SetearImagenesNoticias(2);
        if (titular.text == ParquePimientaLevantarCercaTitulo) SetearImagenesNoticias(2);

        if (titular.text == PuebloPimientaAisladoTitulo) SetearImagenesNoticias(1);
        if (titular.text == PuebloPimientaLevantarCercaTitulo) SetearImagenesNoticias(1);

        if (titular.text == PimientaPaluzaAisladoTitulo) SetearImagenesNoticias(4);
        if (titular.text == PimientaPaluzaCanceladoTitulo) SetearImagenesNoticias(4);
        if (titular.text == PimientaPaluzaLevantarCercaTitulo) SetearImagenesNoticias(4);



        if (titular.text == PimientapaluzersTitulo) SetearImagenesNoticias(5);
        if (titular.text == PimientapaluzersTitulo2) SetearImagenesNoticias(5);

        if (titular.text == PimientapaluzaDifamadoTitulo) SetearImagenesNoticias(4);

        if (titular.text == BananorramaDifamadoTVTitulo) SetearImagenesNoticias(12);


        if (PieGrandeDifamadoTitulo == titular.text) SetearImagenesNoticias(6);

        if (CrearEscenaTitulo == titular.text) { SetearImagenesNoticias(10); SetearReportero(1); }

        if (BenDesapareceTitulo == titular.text) SetearImagenesNoticias(8);
        if (PepeQue??oTitulo1 == titular.text) SetearImagenesNoticias(8);
        if (PepeQue??oTitulo2 == titular.text) SetearImagenesNoticias(8);

        if (BenBrainwashTitulo == titular.text) SetearImagenesNoticias(9);
        if (BenDifamadoTitulo1 == titular.text) SetearImagenesNoticias(9);
        if (BenDifamadoTitulo2 == titular.text) SetearImagenesNoticias(9);
    }

    void SetearReportero(int i)
    {
        Reportero.sprite = Reporteros[i];
        ReporteroDef.sprite = Reporteros[i];
        if (i == 0)
        {
            FondoTV.color = new Color(1, 1, 1);
            FondeoTVDef.color = new Color(1, 1, 1);
        }
        if (i == 1)
        {
            FondoTV.color = new Color(1, 0.5f, 1);
            FondeoTVDef.color = new Color(1, 0.5f, 1);
        }
    }

    void SetearImagenesNoticias(int i)
    {
        ImgNoticia.sprite = vcImgNoticia[i];
        ImgNoticiaDef.sprite = vcImgNoticia[i];
    }

    /// ================================================================== Noticias Aleatorias ========================================================= ///
	string TitularAleatoria1 = "ALMONDIGAS DE MURCIEGALO: EL PLATO DEL MOMENTO";
    string NoticiaAleatoria1 = "ALM??NDIGAS DE MURCI??GALO" + System.Environment.NewLine + "EL MEN?? DISL??XICO QUE ATRAE A MULTITUDES";

    string TitularAleatoria2 = "??DIETA O RADIACION? C??MO QUEMAR ESOS KILOS DE M??S";
    string NoticiaAleatoria2 = "??DIETA O RADIACI??N?"+ System.Environment.NewLine +  "C??MO QUEMAR ESOS KILOS DE M??S";

    string TitularAleatoria3 = "??BIZCOCHITOS DE ADAMANTIUM?";
    string NoticiaAleatoria3 = "??BIZCOCHITOS DE ADAMANTIUM?" + System.Environment.NewLine + "SORPRENDE A TUS VISITAS CON EL LIBRO DE RECETAS DE LA ABUELA HARDCORE";

    string TitularAleatoria4 = "FESTIVAL 'PATEA UN TIBUR??N' TERMINA EN SORPRESIVA TRAGEDIA";
    string NoticiaAleatoria4 = "FESTIVAL 'PATEA UN TIBUR??N' TERMINA EN SORPRESIVA TRAGEDIA." + System.Environment.NewLine + "FINALMENTE PAS?? LO IMPENSABLE.";

    string TitularAleatoria5 = "ASESINO SERIAL RAGE QUITS. CONFIEZA QUE NO LA ESTABA PASANDO BIEN";
    string NoticiaAleatoria5 = "ASESINO SERIAL RAGE QUITS." + System.Environment.NewLine + "CONFIEZA QUE NO LA ESTABA PASANDO BIEN";

    string TitularAleatoria6 = "??CU??NTO GARPA SER UNA NINFA?";
    string NoticiaAleatoria6 = "??CU??NTO GARPA SER UNA NINFA DEL BOSQUE? HABLAMOS CON ESPECIALISTAS DEL RUBRO";

    string TitularAleatoria7 = "MARIPOSA SENTENCIADA A 60 A??OS EN PRISI??N FEDERAL";
    string NoticiaAleatoria7 = "MARIPOSA SENTENCIADA A 60 A??OS EN PRISI??N FEDERAL. FAMILIARES DE LAS V??CTIMAS CELEBRAN: \"JUSTICIA AL FIN!\"";

    string TitularAleatoria8 = "REBOOT DE PRECUELA SE CONVIERTE EN SPIN-OFF DE REMAKE DEL LIBRO";
    string NoticiaAleatoria8 = "REBOOT DE PRECUELA SE CONVIERTE EN SPIN-OFF DE REMAKE DEL LIBRO";

    string TitularAleatoria9 = "GAME DESIGNER PROPONE FEATURE A ??LTIMO MOMENTO";
    string NoticiaAleatoria9 = "GAME DESIGNER SORPRENDE A EQUIPO PROPONIENDO FEATURE ESCENCIAL A HORAS DE ENTREGA";

    string TitularAleatoria10 = "COCEAODANU OSAVNIHEE CE A TAU DNUNAZBNMN A AATNATVE";
    string NoticiaAleatoria10 = "PONETE LOS LENTES, PA";

    string TitularAleatoria11 = "LORO BOCASUCIA ARRUINA BAUTISMO";
    string NoticiaAleatoria11 = "LORO BOCASUCIA ARRUINA BAUTISMO." + System.Environment.NewLine + "POLLY NO QUIERE UNA GALLETA, QUIERE &#$%@ Y +{<*/A. ";

    string TitularAleatoria12 = "JOVEN PIERDE LA VISTA LUEGO DE ESTORNUDAR CON LOS OJOS ABIERTOS";
    string NoticiaAleatoria12 = "JOVEN PIERDE LA VISTA LUEGO DE ESTORNUDAR CON LOS OJOS ABIERTOS ??POR QUE ES IMPORTANTE QUE LA EDUCACI??N COMIENCE EN EL HOGAR?";

    string TitularAleatoria13 = "PATA PETA PITA POTA Y UNA HERMANA";
    string NoticiaAleatoria13 = "PATA PETA PITA POTA Y UNA HERMANA" + System.Environment.NewLine + "LAS NUEVAS RIMAS DE LA SE??O FLAVIA CAUSAN CONTROVERSIA";

    string TitularAleatoria14 = "SONAMBULA DESPIERTA CON TITULO DE MEDICINA Y 7 HIJOS";
    string NoticiaAleatoria14 = "SONAMBULA DESPIERTA CON TITULO DE MEDICINA Y 7 HIJOS. \"Y ESO QUE NO ME ACOST?? TEMPRANO\"";

    string TitularAleatoria15 = "TECHPROOF CUMPLE CON LA M??NIMA. ALUMNOS SE REGOZIJAN";
    string NoticiaAleatoria15 = "TECHPROOF CUMPLE CON LA M??NIMA. ALUMNOS SE REGOZIJAN. LA LEY DEL MINIMO ESFUERZO DEMUESTRA RESULTADOS UNA VEZ MAS";

    string TitularAleatoria16 = "APRENDE OTRO IDIOMA CAMBIANDOLO EN SETTINGS";
    string NoticiaAleatoria16 = "APRENDE OTRO IDIOMA CAMBIANDOLO EN SETTINGS. DETECTAR MENTIRAS COMO ESTA ES ESENCIAL PARA SOBREVIVIR EN ESTE MUNDO CONTEMPORANEO";

    string TitularAleatoria17 = "HACE UNA HORA QUE NO PASA NADA";
    string NoticiaAleatoria17 = "HACE UNA HORA QUE NO PASA NADA" + System.Environment.NewLine + "??ES ESTE EL FIN DEL MUNDO DEL PERIODISMO TAL COMO LO CONOCEMOS?";

    string TitularAleatoria18 = "ESTERNOCLEIDOMASTOIDEO Y OTRAS 10 PARALABRAS QUEMADAS PARA JUGAR AL AHORCADO COMO UN BONAFIDE GIL";
    string NoticiaAleatoria18 = "ESTERNOCLEIDOMASTOIDEO Y OTRAS 10 PARALABRAS QUEMADAS PARA JUGAR AL AHORCADO COMO UN BONAFIDE GIL";

    string TitularAleatoria19 = "ABUELITA REAPARECE A DOS A??OS DE CAER EN DUDOSO POZO SIN FONDO";
    string NoticiaAleatoria19 = "ABUELITA REAPARECE A DOS A??OS DE CAER EN DUDOSO POZO SIN FONDO. " + System.Environment.NewLine + "NIETOS RECLAMAN REGALOS";

    string TitularAleatoria20 = "THE OUTTER FRAME 2 CANCELADO";
    string NoticiaAleatoria20 = "THE OUTTER FRAME 2 CANCELADO. TODOS NOS LA VE??AMOS VENIR.";

    string TitularAleatoria21 = "TODO EST?? TRANQUILO POR ACA";
    string NoticiaAleatoria21 = "TODO EST?? TRANQUILO POR ACA" + System.Environment.NewLine + "C??LEBRES ??LTIMAS PALABRAS DE JOVEN APLASTADO POR VACA MET??LICA CAIDA DEL CIELO";

    string TitularAleatoria22 = "POLENTA OLVIDADA EN EL FONDO DE LA HELADERA SE COBRA OTRA VIDA";
    string NoticiaAleatoria22 = "POLENTA OLVIDADA EN EL FONDO DE LA HELADERA SE COBRA OTRA VIDA ??CUANDO APRENDEREMOS?";

    string TitularAleatoria23 = "??ES EL MOMENTO DE INVERTIR EN CIRCOS DE TERMITAS?" + System.Environment.NewLine + " ??QUE DICE EL MERCADO?";
    string NoticiaAleatoria23 = "??ES EL MOMENTO DE INVERTIR EN CIRCOS DE TERMITAS?" + System.Environment.NewLine + " ??QU?? DICE EL MERCADO?";

    string TitularAleatoria24 = "DESAF??O DE CHUPARSE EL CODO DEJA A PAR DE AMIGOS CUADRIPL??JICOS";
    string NoticiaAleatoria24 = "DESAF??O DE CHUPARSE EL CODO DEJA A PAR DE AMIGOS CUADRIPL??JICOS";

    string TitularAleatoria25 = "HOMBRE EXTRAV??A SUS PIES EN LA PLAYA LUEGO DE ENTERRARLOS EN LA ARENA";
    string NoticiaAleatoria25 = "HOMBRE EXTRAV??A SUS PIES EN LA PLAYA LUEGO DE ENTERRARLOS EN LA ARENA. \"NO ENTIENDO DONDE PUEDEN ESTAR... NI ME MOV?? DE AC??\"";

    string TitularAleatoria26 = "??POR QUE ES QUE SOLO PASAN COSAS CADA 1 HORA?";
    string NoticiaAleatoria26 = "??POR QUE ES QUE SOLO PASAN COSAS CADA 1 HORA? " + System.Environment.NewLine + "CUAL ES EL MOTIVO DETRAS DE ESTE ORDEN COSMICO QUE ORGANIZA CADA EVENTO A EXACTAMENTE UNA HORA DEL SIGUIENTE?";

    string TitularAleatoria27 = "TE CONTAMOS C??MO Y D??NDE ENCONTRAR QUESO INVISIBLE";
    string NoticiaAleatoria27 = "TE CONTAMOS C??MO Y D??NDE ENCONTRAR QUESO INVISIBLE";

    string TitularAleatoria28 = "ASTILLA EN EL CEREBRO BRINDA A HOMBRE LA HABILIDAD DE VER ATRAVES DE PUERTAS DE MADERA";
    string NoticiaAleatoria28 = "ASTILLA EN EL CEREBRO BRINDA A HOMBRE LA HABILIDAD DE VER ATRAVES DE PUERTAS DE MADERA";

    string TitularAleatoria29 = "THE OUTTER FRAME 2 CANCELADO";
    string NoticiaAleatoria29 = "THE OUTTER FRAME 2 CANCELADO. TODOS NOS LA VE??AMOS VENIR.";

    string TitularAleatoria30 = "MILANESAS DE HERO??NA." + System.Environment.NewLine + "EL PLATO DEL QUE NO HAY VUELTA ATR??S";
    string NoticiaAleatoria30 = "MILANESAS DE HERO??NA." + System.Environment.NewLine + "EL PLATO DEL QUE NO HAY VUELTA ATR??S";

    string TitularAleatoria31 = "";
    string NoticiaAleatoria31 = "MUJER LAGARTO";

    string TitularAleatoria33 = "ES OFICIAL: JAMES, A NADIE LE IMPORTA AVATAR";
    string NoticiaAleatoria33 = "";

    string TitularAleatoria34 = "PIANISTA";
    string NoticiaAleatoria34 = "";

    string TitularAleatoria35 = "VERDULERO";
    string NoticiaAleatoria35 = "";

    string TitularAleatoria36 = "AGUA EN POLVO";
    string NoticiaAleatoria36 = "";

    string TitularAleatoria37 = "";
    string NoticiaAleatoria37 = "SUPUESTA GONODA DE GODZILLA ENCONTRADA EN EL FONDO DEL MAR RESULTA SER UN SIMPLE METEORITO";

    string TitularAleatoria38 = "MEDICINA HIPPIE";
    string NoticiaAleatoria38 = "";

    string TitularAleatoria39 = "CRISIS EXISTENCIAL";
    string NoticiaAleatoria39 = "COMO EVITAR UNA CRISIS EXISTENCIAL";

    string TitularAleatoria40 = "ES POSIBLE?";
    string NoticiaAleatoria40 = "";

    string TitularAleatoria41 = "";
    string NoticiaAleatoria41 = "EL MISTERIO DEL PERRO MOMIA VAMPIRO ERA UN ";

    string TitularAleatoria42 = "EL PERDIDO ARTE DE ESCRIBIR DIALOGO RANDOMIZADO";
    string NoticiaAleatoria42 = "";

    string TitularAleatoria43 = "THE OUTTER FRAME CANCELADO";
    string NoticiaAleatoria43 = "";

    string TitularAleatoria44 = "";
    string NoticiaAleatoria44 = "ESPECTRO CHOCARRERO DE LA CALLE 18 ERA ENREALIDAD UN INDIGENTE EN POSESI??N DE UNA MAQUINA DE HUMO";

    string TitularAleatoria45 = "";
    string NoticiaAleatoria45 = "";

    string TitularAleatoria46 = "";
    string NoticiaAleatoria46 = "";

    string TitularAleatoria47 = "";
    string NoticiaAleatoria47 = "";

    string TitularAleatoria48 = "";
    string NoticiaAleatoria48 = "";

    string TitularAleatoria49 = "";
    string NoticiaAleatoria49 = "";

    string TitularAleatoria50 = "";
    string NoticiaAleatoria50 = "";

    string TitularAleatoria51 = "";
    string NoticiaAleatoria51 = "";

    string TitularAleatoria52 = "";
    string NoticiaAleatoria52 = "";

    string TitularAleatoria53 = "";
    string NoticiaAleatoria53 = "";

    string TitularAleatoria54 = "";
    string NoticiaAleatoria54 = "";

    string TitularAleatoria55 = "";
    string NoticiaAleatoria55 = "SI ESTAS LEYENDO ESTO HAS LLEGADO DE ALGUNA FORMA";


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
                    NumNoticiasAteatorias++;
                    break;

                case 20:
                    titular.text = TitularAleatoria20;
                    noticia.text = NoticiaAleatoria20;
                    NumNoticiasAteatorias++;
                    break;

                case 21:
                    titular.text = TitularAleatoria21;
                    noticia.text = NoticiaAleatoria21;
                    NumNoticiasAteatorias++;
                    break;

                case 22:
                    titular.text = TitularAleatoria22;
                    noticia.text = NoticiaAleatoria22;
                    NumNoticiasAteatorias++;
                    break;

                case 23:
                    titular.text = TitularAleatoria23;
                    noticia.text = NoticiaAleatoria23;
                    NumNoticiasAteatorias++;
                    break;

                case 24:
                    titular.text = TitularAleatoria24;
                    noticia.text = NoticiaAleatoria24;
                    NumNoticiasAteatorias++;
                    break;

                case 25:
                    titular.text = TitularAleatoria25;
                    noticia.text = NoticiaAleatoria25;
                    NumNoticiasAteatorias++;
                    break;

                case 26:
                    titular.text = TitularAleatoria26;
                    noticia.text = NoticiaAleatoria26;
                    NumNoticiasAteatorias++;
                    break;

                case 27:
                    titular.text = TitularAleatoria27;
                    noticia.text = NoticiaAleatoria27;
                    NumNoticiasAteatorias++;
                    break;

                case 28:
                    titular.text = TitularAleatoria28;
                    noticia.text = NoticiaAleatoria28;
                    NumNoticiasAteatorias++;
                    break;

                case 29:
                    titular.text = TitularAleatoria29;
                    noticia.text = NoticiaAleatoria29;
                    NumNoticiasAteatorias++;
                    break;

                case 30:
                    titular.text = TitularAleatoria30;
                    noticia.text = NoticiaAleatoria30;
                    CualLista = 0;
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

                case 30:
                    titular.text = TitularAleatoria20;
                    noticia.text = NoticiaAleatoria20;
                    NumNoticiasAteatorias++;
                    CualLista = 0;
                    NumNoticiasAteatorias = 1;
                    break;

                case 29:
                    titular.text = TitularAleatoria21;
                    noticia.text = NoticiaAleatoria21;
                    NumNoticiasAteatorias++;
                    break;

                case 28:
                    titular.text = TitularAleatoria22;
                    noticia.text = NoticiaAleatoria22;
                    NumNoticiasAteatorias++;
                    break;

                case 27:
                    titular.text = TitularAleatoria23;
                    noticia.text = NoticiaAleatoria23;
                    NumNoticiasAteatorias++;
                    break;

                case 26:
                    titular.text = TitularAleatoria24;
                    noticia.text = NoticiaAleatoria24;
                    NumNoticiasAteatorias++;
                    break;

                case 25:
                    titular.text = TitularAleatoria25;
                    noticia.text = NoticiaAleatoria25;
                    NumNoticiasAteatorias++;
                    break;

                case 24:
                    titular.text = TitularAleatoria26;
                    noticia.text = NoticiaAleatoria26;
                    NumNoticiasAteatorias++;
                    break;

                case 23:
                    titular.text = TitularAleatoria27;
                    noticia.text = NoticiaAleatoria27;
                    NumNoticiasAteatorias++;
                    break;

                case 22:
                    titular.text = TitularAleatoria28;
                    noticia.text = NoticiaAleatoria28;
                    NumNoticiasAteatorias++;
                    break;

                case 21:
                    titular.text = TitularAleatoria29;
                    noticia.text = NoticiaAleatoria29;
                    NumNoticiasAteatorias++;
                    break;

                case 20:
                    titular.text = TitularAleatoria30;
                    noticia.text = NoticiaAleatoria30;
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
                    NumNoticiasAteatorias++;
                    break;

                case 15:
                    titular.text = TitularAleatoria19;
                    noticia.text = NoticiaAleatoria19;
                    NumNoticiasAteatorias++;
                    break;

                case 20:
                    titular.text = TitularAleatoria20;
                    noticia.text = NoticiaAleatoria20;
                    NumNoticiasAteatorias++;
                    break;

                case 25:
                    titular.text = TitularAleatoria21;
                    noticia.text = NoticiaAleatoria21;
                    NumNoticiasAteatorias++;
                    break;

                case 23:
                    titular.text = TitularAleatoria22;
                    noticia.text = NoticiaAleatoria22;
                    NumNoticiasAteatorias++;
                    break;

                case 30:
                    titular.text = TitularAleatoria23;
                    noticia.text = NoticiaAleatoria23;
                    CualLista = 2;
                    NumNoticiasAteatorias = 1;
                    break;

                case 24:
                    titular.text = TitularAleatoria24;
                    noticia.text = NoticiaAleatoria24;
                    NumNoticiasAteatorias++;
                    break;

                case 26:
                    titular.text = TitularAleatoria25;
                    noticia.text = NoticiaAleatoria25;
                    NumNoticiasAteatorias++;
                    break;

                case 27:
                    titular.text = TitularAleatoria26;
                    noticia.text = NoticiaAleatoria26;
                    NumNoticiasAteatorias++;
                    break;

                case 28:
                    titular.text = TitularAleatoria27;
                    noticia.text = NoticiaAleatoria27;
                    NumNoticiasAteatorias++;
                    break;

                case 29:
                    titular.text = TitularAleatoria28;
                    noticia.text = NoticiaAleatoria28;
                    NumNoticiasAteatorias++;
                    break;

                case 22:
                    titular.text = TitularAleatoria29;
                    noticia.text = NoticiaAleatoria29;
                    NumNoticiasAteatorias++;
                    break;

                case 21:
                    titular.text = TitularAleatoria30;
                    noticia.text = NoticiaAleatoria30;
                    NumNoticiasAteatorias++;

                    break;
            }
        }
    }
}