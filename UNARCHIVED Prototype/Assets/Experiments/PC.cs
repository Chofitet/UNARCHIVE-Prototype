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
            txtInfo.text = "Ben Benji: Niño normal, no posee caracteristicas ni poderes especiales." 
                + System.Environment.NewLine + "Edad: 10 años" 
                + System.Environment.NewLine + "Estado: Niño de verdad" 
                + System.Environment.NewLine + "Ultima vez visto en: Pueblo Pimienta, Desulum";
        }
        //================================================================ Wiki Pie Grande ==============================================//
        else if (txtBuscador.text == "Pie Grande")
        {
            txtInfo.text = "Pie Grande: primo lejano del Hombre de las Nieves, esta criatura mitica ha sido avistado por todo el globo a lo largo de su existencia, pero eludiendo a las autoridades en cada oportunidad. Gracias a la intervención de su primo el tratado de paz firmado en el 79 terminó años de rivalidad y caceria entre Pie Grande y la agencia. Es considerado una especie en peligro de extincion, debe ser protegida y mantenida fuera del ojo publico." 
                + System.Environment.NewLine + "Edad: 134 años(segun el), relativamente joven en años pie." 
                + System.Environment.NewLine + "Estado: Divorciado en el 91."
                + System.Environment.NewLine + "Ultima vez visto en:  Monte Desulum";
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
            txtInfo.text = "Información sin correlación"
                + System.Environment.NewLine + "";
        }
        //================================================================ Wiki Pepe Queño =======================================================//

        // Antes de investigarlo
        else if (txtBuscador.text == "Pepe Queño" )
        {
            txtInfo.text = ""
                + System.Environment.NewLine + "";
        }
        //Despues de investigarlo
        else if (txtBuscador.text == "Pepe Queño" && bitacoras.PepeInvestigado == true)
        {
            txtInfo.text = ""
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
