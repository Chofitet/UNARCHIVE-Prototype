using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaras : MonoBehaviour
{
    [SerializeField] TelefonoCamara telefono;
    public Transform[] posCamara;
    public float transitionSpeed;
    Transform currentview;
    public GameObject TV;
    public GameObject PC;

    void Start()
    {
        currentview = transform;
    }

    
    void Update()
    {
       if(telefono.telefonoCamara == true)
        {
            currentview = posCamara[0];
        }
        if(TV.activeSelf == true)
        {
            currentview = posCamara[2];
        }
        if (PC.activeSelf == true)
        {
            currentview = posCamara[1];
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) == true && PasoDeDia.PantallaDia == false)
        {
            currentview = posCamara[3];
        }
       
    }

    private void LateUpdate ()
    {
        Quaternion currentAngle;
        
        transform.position = Vector3.Lerp (transform.position, currentview.position, Time.deltaTime * transitionSpeed);


        currentAngle = Quaternion.Lerp(transform.rotation, currentview.rotation, Time.deltaTime * transitionSpeed);
      
        /*
        Vector3 currentAngle = new Vector3(
            Mathf.Lerp(transform.rotation.eulerAngles.x, currentview.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
            Mathf.Lerp(transform.rotation.eulerAngles.y, currentview.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
            Mathf.Lerp(transform.rotation.eulerAngles.z, currentview.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed)
            );
        */

        transform.rotation= currentAngle;


    }
}
