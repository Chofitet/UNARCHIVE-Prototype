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
    
    private void Start()
    {
    }

    public void MostrarPalabraBuscador()
    {
        txtBuscador.text =  libreta.palabra; 
        
    }
    //Actualiza la wiki cada vez que le das a la lupa
    public void MostrarWiki ()
    {
        //================================================================ Wiki Ben =======================================================//
        if(txtBuscador.text == "Ben Benji")
        {
            txtInfo.text = "Ben Benji: Niño común, académicamente correcto, no posee características ni poderes especiales. Si leer esto parece aburrido y carente de imaginación, agradece que no conoces a Ben Benji." 
                + System.Environment.NewLine + "Edad: 10 a�os" 
                + System.Environment.NewLine + "Estado: Ni�o de verdad" 
                + System.Environment.NewLine + "Ultima vez visto en: Pueblo Pimienta";
        }
        //================================================================ Wiki Pie Grande ==============================================//
        else if (txtBuscador.text == "Pie Grande")
        {
            txtInfo.text = "Pie Grande: La Leyenda es cierta. De naturaleza andante y esotérica, está reservada criatura ha sido avistada a lo largo, ancho y alto del globo durante su centenaria existencia; eludiendo a cada largo paso de su personal travesía cualquier tipo de intento de captura.Gracias a la intervención de su primo, el tratado de paz firmado en el 79, terminó años de rivalidad y cacería entre Pie Grande y La Agencia; aun así no es un ser ajeno a la violencia y deben evitarse situaciones incómodas./nPara la incredulidad del no iniciado, Pie Grande ha mantenido contacto con los avances tecnológicos y, debido a su reservada personalidad, se comunica mejor vía chat que en persona."
                + System.Environment.NewLine + "Es considerado una noble especie en peligro de extinción, y como tal debe ser protegida del alcance del vulgar ciudadano común."
                + System.Environment.NewLine + "Para la incredulidad del no iniciado, Pie Grande ha mantenido contacto con los avances tecnológicos y, debido a su reservada personalidad, se comunica mejor vía chat que en persona./nEs considerado una noble especie en peligro de extinción, y como tal debe ser protegida del alcance del vulgar ciudadano común."
                + System.Environment.NewLine + "Edad: 134 años(sin certificado), relativamente joven en años pie." 
                + System.Environment.NewLine + "Estado: Divorciado en el 91."
                + System.Environment.NewLine + "Ultima vez visto en:  Monte Quete";
        }
        //================================================================ Wiki Kate Milliard =======================================================//
        else if (txtBuscador.text == "Kate Milliard")
        {
            txtInfo.text = "Kate Milliard: Actriz de alto reconocimiento, saltó a la fama con la comedia romántica "Bananarama" en 1994 y consolidó su lugar en el podio dramatúrgico con "Not without my monkey" en 1997. Al negar teñir o cubrir su rojiza cabellera para interpretar roles ha logrado convertir ese capricho en su marca registrada. Aunque dice “aún no planea dejar la actuación, muchachos”, ha pasado a desarrollarse en los últimos años como directora de documentales sobre animales en peligro de extinción."
                + System.Environment.NewLine + "Edad: 24 años"
                + System.Environment.NewLine + "Estado: Soltera"
                + System.Environment.NewLine + "Última vez vista en: Monte Quete.";
        }
        //================================================================ Wiki Colorada =======================================================//
        else if (txtBuscador.text == "Colorada")
        {
            txtInfo.text = "Informaci�n sin correlaci�n"
                + System.Environment.NewLine + "";
        }
        //================================================================ Wiki Pepe Que�o =======================================================//

        // Antes de investigarlo
        else if (txtBuscador.text == "Pepe Que�o" )
        {
            txtInfo.text = "No hashdasdhas"
                + System.Environment.NewLine + "";
        }
        //Despues de investigarlo
        else if (txtBuscador.text == "Pepe Que�o" && bitacoras.PepeInvestigado == true)
        {
            txtInfo.text = ""
                + System.Environment.NewLine + "";
        }
        else if (txtBuscador.text == "Pepe Que�o" && bitacoras.PepeInvestigado == true)//////post laboratorio , analisis
        {
            txtInfo.text = " Hijo bastardo de Pie Grande y posible causa de la separación de este en el 91. Su existencia fué un secreto para La Agencia hasta al incidente Venus in Fur. Reside actualmente en un orfanato. El paradero de su madre biológica permanece un misterio para todo aquel que no compra el DLC."
                + System.Environment.NewLine + "Edad:10 años híbridos."
                + System.Environment.NewLine + "Estado: Pequeño niño pie grande."
                + System.Environment.NewLine + "Última vez visto en: Pueblo Pimienta.";
        }
        //================================================================ Wiki Pimienta Paluza =======================================================//
        else if (txtBuscador.text == "Pimientapaluza")
        {
            txtInfo.text = "Pimentapaluza: Solo un absoluto careta buscaría el significado de la Pimientaexperiencia en una computadora."
            + System.Environment.NewLine + "Es el 27 de Marzo. SIEMPRE. CARETA."
            + System.Environment.NewLine +
            + System.Environment.NewLine +
            + System.Environment.NewLine +
            + System.Environment.NewLine +
            + System.Environment.NewLine +
            + System.Environment.NewLine +
            + System.Environment.NewLine +
            + System.Environment.NewLine +
            + System.Environment.NewLine + "NOTA: POR FAVOR, GARY,  MANTENER CIVILES LAS ENTRADAS DE LA BASE DE DATOS";
        }
        //================================================================ Wiki Parque Pimienta =======================================================//
        else if (txtBuscador.text== "Parque Pimienta")
        {
            txtInfo.text = ""
                + System.Environment.NewLine + "";
        }

    }

    public void BorrarWiki ()
    {
        txtBuscador.text = "Search.....";
        txtInfo.text = "";
    }
}
