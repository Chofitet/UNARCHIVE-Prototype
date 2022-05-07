using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PC : MonoBehaviour
{
    [SerializeField] internal Libreta libreta;
    public TMP_Text txtBuscador;
    public TMP_Text txtInfo;
   

    private void Start()
    {
    }

    public void MostrarPalabraBuscador()
    {
        txtBuscador.text = "   " + libreta.palabra; 
        
    }
    //Actualiza la wiki cada vez que le das a la lupa
    public void MostrarWiki ()
    {
        if(libreta.palabra == "Ben Benji")
        {
            txtInfo.text = "Ben Benji: Ni�o normal, no posee caracteristicas ni poderes especiales." 
                + System.Environment.NewLine + "Edad: 10 a�os" 
                + System.Environment.NewLine + "Estado: Ni�o de verdad" 
                + System.Environment.NewLine + "Ultima vez visto en: Pueblo Pimienta, Desulum";
        }
        else if (libreta.palabra == "Pie Grande")
        {
            txtInfo.text = "Pie Grande: primo lejano del Hombre de las Nieves, esta criatura mitica ha sido avistado por todo el globo a lo largo de su existencia, pero eludiendo a las autoridades en cada oportunidad. Gracias a la intervenci�n de su primo el tratado de paz firmado en el 79 termin� a�os de rivalidad y caceria entre Pie Grande y la agencia. Es considerado una especie en peligro de extincion, debe ser protegida y mantenida fuera del ojo publico." 
                + System.Environment.NewLine + "Edad: 134 a�os(segun el), relativamente joven en a�os pie." 
                + System.Environment.NewLine + "Estado: Divorciado en el 91."
                + System.Environment.NewLine + "Ultima vez visto en:  Monte Desulum";
        } 
        else if (libreta.palabra == "Kate Milliard")
        {
            txtInfo.text = ""
                + System.Environment.NewLine + "";
        }
        else if (libreta.palabra == "Colorada")
        {
            txtInfo.text = "Informaci�n sin correlaci�n"
                + System.Environment.NewLine + "";
        }
        else if (libreta.palabra == "Pepe Que�o" )
        {
            txtInfo.text = ""
                + System.Environment.NewLine + "";
        }
        else if (libreta.palabra == "Pimienta Paluza")
        {
            txtInfo.text = ""
                + System.Environment.NewLine + "";
        }
        else if (libreta.palabra == "Parque Pimienta")
        {
            txtInfo.text = ""
                + System.Environment.NewLine + "";
        }

    }

    public void BorrarWiki ()
    {
        txtBuscador.text = "  Search...";
        txtInfo.text = "";
    }
}
