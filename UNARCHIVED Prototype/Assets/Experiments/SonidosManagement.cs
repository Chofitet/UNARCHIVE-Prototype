using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosManagement : MonoBehaviour
{
    [Header("Prefabs sonidos")]

    public Transform camara;

    public GameObject AbrirExpediente;
    public GameObject CerrarExpediente;
    public GameObject SonidoImprimir;
    public GameObject SonidoTachar;
    public GameObject PING;
    public GameObject RelojNormal;
    public GameObject RelojRapido;

    public GameObject[] EscribirPapel;
    public GameObject[] ClickMouse;
    public GameObject[] PasarHoja;
    public GameObject[] SonidoBoton;
    public GameObject[] SonidoTeclado;

    void NuevoSonido(GameObject prefabs, Vector3 posición, float duración = 5f, bool ModificarPitch = true)
    {
        
        GameObject obj = Instantiate(prefabs, posición, Quaternion.identity);
        if (ModificarPitch)
        {
            obj.GetComponent<AudioSource>().pitch *= 1 + Random.Range(-0.2f, 0.2f);
        }
        Destroy(obj, duración);
        
    }
    void Start()
    {
        
    }

    public void SonidoAbrirExpediente()
    {
        NuevoSonido(AbrirExpediente, camara.position, 1f);
       // Destroy(AbrirExpediente);
    }

    public void SonidoCerrarExpediente()
    {
        NuevoSonido(CerrarExpediente, camara.position, 1f);
      //  Destroy(CerrarExpediente);
    }

    public void SonidodeImprimir()
    {
        NuevoSonido(SonidoImprimir, camara.position, 1f);
       // Destroy(SonidoImprimir);
    }

    public void SonidodeTachar()
    {
        NuevoSonido(SonidoTachar, camara.position, 1f);
       // Destroy(SonidoTachar);
    }

    public void SonidoPING()
    {
        NuevoSonido(PING, camara.position, 1f);
       // Destroy(PING);
    }

    public void SonidoRelojNormal()
    {
        NuevoSonido(RelojNormal, camara.position, 1f);
       // Destroy(RelojNormal);
    }

    public void SonidoRelojRapido()
    {
        NuevoSonido(RelojRapido, camara.position, 1f);
       // Destroy(RelojRapido);
    }

    public void SonidoEscribirPapel()
    {
        int num = Random.Range(0, 3);
        NuevoSonido(EscribirPapel[num], camara.position, 1f);
       // Destroy(EscribirPapel[num]);
    }

    public void SonidoClickMouse()
    {
        int num = Random.Range(0, 3);
        NuevoSonido(ClickMouse[num], camara.position, 1f);
       // Destroy(ClickMouse[num]);
    }

    public void SonidoPasarHoja()
    {
        int num = Random.Range(0, 2);
        NuevoSonido(PasarHoja[num], camara.position, 1f);
       // Destroy(PasarHoja[num]);
    }

    public void SonidodeBoton()
    {
        int num = Random.Range(0, 2);
        NuevoSonido(SonidoBoton[num], camara.position, 1f);
       // Destroy(SonidoBoton[num]);
    }

    public void SonidodeTeclado()
    {
        Debug.Log("teclado");
        int num = Random.Range(0, 4);
        NuevoSonido(SonidoTeclado[num], camara.position, 1f);
       // Destroy(SonidoTeclado[num]);
    }
}
