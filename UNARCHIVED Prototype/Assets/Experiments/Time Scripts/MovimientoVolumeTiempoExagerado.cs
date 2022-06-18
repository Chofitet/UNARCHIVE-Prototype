using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoVolumeTiempoExagerado : MonoBehaviour
{
    public Transform PosicionInicio;
    public Transform PosicionFinal;
    public float transitionSpeed;
    private Transform transform;
    private Transform posicion;
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    public void ColocarEfectoTiempoExagerado()
    {
        posicion = PosicionFinal;
    }
    public void QuitarEfectoTiempoExagerado()
    {
        posicion = PosicionInicio;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, posicion.position, Time.deltaTime * transitionSpeed);
    }
}
