using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoVolumesTiempo : MonoBehaviour
{
    [SerializeField] MovimientoVolumeTiempoExagerado tiempoExagerado;
    public Transform PosicionInicio;
    public Transform PosicionFinal;
    public float transitionSpeed;
    private Transform transform;
    private Transform posicion;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    public void ColocarEfectoTiempo()
    {
        posicion = PosicionFinal;
        tiempoExagerado.ColocarEfectoTiempoExagerado();
        StartCoroutine(EfectoTiempoExagerado());

    }
    public void QuitarEfectoTiempo()
    {
        posicion = PosicionInicio;
        
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, posicion.position, Time.deltaTime * transitionSpeed);
    }

    IEnumerator EfectoTiempoExagerado ()
    {
        yield return  new WaitForSeconds(0.6f);
        tiempoExagerado.QuitarEfectoTiempoExagerado();
    }
}
