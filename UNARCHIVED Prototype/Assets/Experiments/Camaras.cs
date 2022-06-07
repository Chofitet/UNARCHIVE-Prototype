using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaras : MonoBehaviour
{

    public Transform[] views;
    public float transitionSpeed;
    Transform currentview;


    void Start()
    {
        currentview = transform;
    }

    
    void Update()
    {
        if(Input.g)
        {
            currentview = views[0];
        }
        if (Input.Get)
        {
            currentview = views[1];
        }
        if (Input.Get)
        {
            currentview = views[2];
        }
        if (Input.Get)
        {
            currentview = views[3];
        }
    }

    private void LateUpdate ()
    {
        transform.position = Vector3.Lerp (transform.position, Time.deltaTime * transitionSpeed);
    }
}
