using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Sonido : MonoBehaviour
{
    [Header("Prefabs sonidos")]
    public GameObject AbrirExpediente;
    public GameObject CerrarExpediente;
    public GameObject SonidoImprimir;
    public GameObject SonidoTachar;
    public GameObject SonidoPING;
    public GameObject RelojNormal;
    public GameObject RelojRapido;

    public GameObject[] EscribirPapel;
    public GameObject[] ClickMouse;
    public GameObject[] PasarHoja;
    public GameObject[] SonidoBoton;
    public GameObject[] SonidoTeclado;

    void NuevoSonido (GameObject prefabs, Vector3 posición,float duración = 5f )
    {
        float duración = 5f, (bool ModificarPitch = true)
        {
            GameObject obj = Instantiate(prefabs, posición, Quanterion.indentity);
            if (ModificarPitch)
            {
                obj.GetComponent<AudioSource>().pitch *= 1 + Random.Range(-0.2f, 0.2f);
            }
            Destroy(obj, duración);
        }
        
    }
    
    void Start()
    {
        //Abrir ecpediente

        NuevoSonido(AbrirExpediente, , 1f);
        Destroy(GameObject);

        //Cerrar expediente
        NuevoSonido(CerrarExpediente, , 1f);
        Destroy(GameObject);
        //Sonido imprimir
        NuevoSonido(SonidoImprimir, , 1f);
        Destroy(GameObject);

        //Sonido tachar
        NuevoSonido(SonidoTachar, , 1f);
        Destroy(GameObject);

        //Sonido PING
        NuevoSonido(SonidoPING, , 1f);
        Destroy(GameObject);

        //Reloj normal
        NuevoSonido(RelojNormal, , 1f);
        Destroy(GameObject);

        //Reloj rapido
        NuevoSonido(RelojRapido, , 1f);
        Destroy(GameObject);

        //Escribir papel
         int num = Random.range(0, 4);
        NuevoSonido(EscribirPapel[num], , 1f);
        Destroy(GameObject);

        //Click mouse
         int num = Random.range(0, 3);
        NuevoSonido(PasarHoja[num], , 1f);
        Destroy(GameObject);

        //Pasar hoja
        int num = Random.range(0, 3);
        NuevoSonido(PasarHoja[num], , 1f);
        Destroy(GameObject);

        //Sonido boton
        int num = Random.range(0, 2);
        NuevoSonido(SonidoBoton[num], , 1f);
        Destroy(GameObject);

        //Sonido teclado
        int num = Random.range(0, 5);
        NuevoSonido(SonidoTeclado[num], , 1f);
        Destroy(GameObject);
    }

    
    void Update()
    {
        
    }
}
