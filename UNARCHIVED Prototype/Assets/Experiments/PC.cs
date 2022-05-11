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
        if(txtBuscador.text == "Ben Benjinnnnnnnnnn")
        {
            txtInfo.text = "Ben Benji: Ni�o normal, no posee caracteristicas ni poderes especiales." 
                + System.Environment.NewLine + "Edad: 10 a�os" 
                + System.Environment.NewLine + "Estado: Ni�o de verdad" 
                + System.Environment.NewLine + "Ultima vez visto en: Pueblo Pimienta, Desulum";
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
            txtInfo.text = ""
                + System.Environment.NewLine + "";
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
                + System.Environment.NewLine + "";
        }
        //================================================================ Wiki Pimienta Paluza =======================================================//
        else if (txtBuscador.text == "Pimienta Paluza")
        {
            txtInfo.text = ""
                + System.Environment.NewLine + "";
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
