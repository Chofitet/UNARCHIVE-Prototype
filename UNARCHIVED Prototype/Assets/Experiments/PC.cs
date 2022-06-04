using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PC : MonoBehaviour
{
    [SerializeField] internal Libreta libreta;
    [SerializeField] Bitacoras bitacoras;
    public TMP_Text txtBuscador;
    public TMP_Text txtInfo;
    public TMP_Text txtRating;

    public int Rating;

    private void Update()
    {
        txtRating.text = Rating + " w/s";
    }

    public void MostrarPalabraBuscador()
    {
        txtBuscador.text =  libreta.palabra;     
    }
    //Actualiza la wiki cada vez que le das a la lupa
    public void MostrarWiki ()
    {
        //================================================================ Wiki Ben =======================================================//

        if(txtBuscador.text == libreta.palabrasCaso[0])

        {
            txtInfo.text = "Niño común, académicamente correcto, no posee características ni poderes especiales. Si leer esto parece aburrido y carente de imaginación, agradece que no conoces a Ben Benji."
                + System.Environment.NewLine
                + System.Environment.NewLine + "Edad: 10 años"
                + System.Environment.NewLine
                + System.Environment.NewLine + "Estado: Niño de verdad"
                + System.Environment.NewLine
                + System.Environment.NewLine + "Ultima vez visto en: Pueblo Pimienta";
        }
        //================================================================ Wiki Pie Grande ==============================================//
        else if (txtBuscador.text == libreta.palabrasCaso[1])
        {
            txtInfo.text = "La Leyenda es cierta. De naturaleza andante y esotérica, esta reservada criatura ha sido avistada a lo largo, ancho y alto del globo durante su centenaria existencia; eludiendo a cada largo paso de su personal travesía cualquier tipo de intento de captura." 
                + System.Environment.NewLine +  "Gracias a la intervención de su primo, el tratado de paz firmado en el 79 terminó años de rivalidad y cacería entre Pie Grande y La Agencia; aun así no es un ser ajeno a la violencia y deben evitarse situaciones incómodas."
                + System.Environment.NewLine + "Para la incredulidad del no iniciado, Pie Grande ha mantenido contacto con los avances tecnológicos y, debido a su reservada personalidad, se comunica mejor vía chat que en persona. Es considerado una noble especie en peligro de extinción, y como tal debe ser protegida del alcance del vulgar ciudadano común."
                + System.Environment.NewLine
                + System.Environment.NewLine + "Edad: 134 años(sin certificado), relativamente joven en años pie."
                + System.Environment.NewLine
                + System.Environment.NewLine + "Estado: Divorciado en el 91."
                + System.Environment.NewLine
                + System.Environment.NewLine + "Ultima vez visto en:  Monte Quete";
        }
        //================================================================ Wiki Kate Milliard =======================================================//
        else if (txtBuscador.text == libreta.palabrasCaso[2])
        {
            txtInfo.text = "Actriz de alto reconocimiento, saltó a la fama con la comedia romántica 'Bananorama' en 1994 y consolidó su lugar en el podio dramatúrgico con 'Not without my monkey' en 1997. Al negar teñir o cubrir su rojiza cabellera para interpretar roles ha logrado convertir ese capricho en su marca registrada. Aunque dice “aún no planea dejar la actuación, muchachos”, ha pasado a desarrollarse en los últimos años como directora de documentales sobre animales en peligro de extinción."
                + System.Environment.NewLine
                + System.Environment.NewLine + "Edad: 24 años"
                + System.Environment.NewLine
                + System.Environment.NewLine + "Estado: Soltera"
                + System.Environment.NewLine
                + System.Environment.NewLine + "Última vez vista en: Monte Quete.";
        }
        //================================================================ Wiki Colorada =======================================================//
        else if (txtBuscador.text == libreta.palabrasCaso[6])
        {
            txtInfo.text = "Filtro NSFW activado."
                + System.Environment.NewLine + "";
        }
        //================================================================ Wiki Pepe Queño =======================================================//

        // Antes de investigarlo
        else if (txtBuscador.text == libreta.palabrasCaso[8])
        {

            txtInfo.text = "Sujeto no cargado en BD."
                + System.Environment.NewLine + "Investigar.";

            if (bitacoras.PepeInvestigado == true && bitacoras.PepeAnalizado == false)
            {
                txtInfo.text = "Extaño niño en búsqueda de una buena afeitada. Reside actualmente en el orfanato local y su ÚNICO amigo es Ben Benji."
            + System.Environment.NewLine
            + System.Environment.NewLine + "Edad: 10 años."
            + System.Environment.NewLine
            + System.Environment.NewLine + "Estado: Pequeño niño raro."
            + System.Environment.NewLine
            + System.Environment.NewLine + "Última vez visto en: Pueblo Pimienta.";
            }
            if (txtBuscador.text == libreta.palabrasCaso[8] && bitacoras.PepeAnalizado == true)
            {
                txtInfo.text = "Hijo bastardo de Pie Grande y más que probable causa de su separación en el 91."
               + System.Environment.NewLine + "Su existencia fué un secreto para La Agencia hasta al incidente Venus in Fur. Reside actualmente en un orfanato. El paradero de su madre biológica permanece un misterio para todo aquel que no compra el DLC."
               + System.Environment.NewLine
               + System.Environment.NewLine + "Edad:10 años híbridos."
               + System.Environment.NewLine
               + System.Environment.NewLine + "Estado: Pequeño niño pie grande."
               + System.Environment.NewLine
               + System.Environment.NewLine + "Última vez visto en: Pueblo Pimienta.";
                
            }

        }
      
        //================================================================ Wiki Pimientapaluza =======================================================//
        else if (txtBuscador.text == libreta.palabrasCaso[3])
        {
            txtInfo.text = "Solo un absoluto careta buscaría el significado de la Pimientaexperiencia en una computadora."
            + System.Environment.NewLine + "Es el 27 de Marzo en Parque Pimienta. SIEMPRE. CARETA."
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine + "NOTA: POR FAVOR, GARY, MANTENER CIVILES LAS ENTRADAS DE LA BASE DE DATOS";
        }
        //================================================================ Wiki Parque Pimienta =======================================================//
        else if (txtBuscador.text== libreta.palabrasCaso[10])
        {
            txtInfo.text = "Enorme reserva ambiental ubicada entre el dorso de Pueblo Pimienta y Monte Quete, es el austero hogar de especies nativas tales como el caribú mostaza, la liebre vermin y el noble salmón araña."
            + System.Environment.NewLine + "A pesar de su propósito es también, controversialmente, el hogar del festival de música más masivo del planeta: El Pimentapaluza, festejado religiosamente en la inamovible fecha del 27 de Marzo de cada año."
            + System.Environment.NewLine + "Ubicación: Entre Pueblo Pimienta y Monte Quete.";
            libreta.BtnPimientaPaluza.SetActive(true);
        }
        //================================================================ Wiki Pueblo Pimienta =======================================================//
        else if (txtBuscador.text == libreta.palabrasCaso[5])
        {
            txtInfo.text = "Ex Ciudad Pimienta, descendida a Pueblo luego de la Triquiñuela del 68."
            + System.Environment.NewLine + "Es una zona semi rural pos urbana cuyos habitantes se encuentran en un proceso de reivindicación fiscal.Es el segundo pueblo más poblado de Quete."
            + System.Environment.NewLine + "Si bien los ingresos anuales generados en la reserva ambiental Parque Pimienta son suficientes para soportar la economía de diez Pueblos Pimienta, intentan mantener su urbanidad controlable."
           + System.Environment.NewLine
            + System.Environment.NewLine + "Habitantes: 274"
            + System.Environment.NewLine
            + System.Environment.NewLine + "Ubicacion: Quete.";
 
            libreta.BtnParquePimienta.SetActive(true);
        }
        //================================================================ Wiki Pimientapaluzers =======================================================//
        else if (txtBuscador.text == libreta.palabrasCaso[11])
        {
            txtInfo.text = "CARETA."
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine 
            + System.Environment.NewLine + "NOTA: GARY!!";
        }
        //consultanding para agregar entradas de todas las palabras de la libreta
        else if (txtBuscador.text == libreta.palabrasCaso[9])
        {
            txtInfo.text = "Cabellos rojizos donde?";
        }
        //================================================================ Wiki Bananorrama =======================================================//
        else if (txtBuscador.text == libreta.palabrasCaso[4])
        {
            txtInfo.text = "CARETA."
            + System.Environment.NewLine
            + System.Environment.NewLine
            + System.Environment.NewLine
            + System.Environment.NewLine
            + System.Environment.NewLine
            + System.Environment.NewLine
            + System.Environment.NewLine
            + System.Environment.NewLine
            + System.Environment.NewLine + "NOTA: GARY!!";
            libreta.BtnKateMilliard.gameObject.SetActive(true);
            libreta.BtnBananorrama.gameObject.SetActive(false);
            }

    }

    public void BorrarWiki ()
    {
        txtBuscador.text = "Buscar...";
        txtInfo.text = "";
    }
}
