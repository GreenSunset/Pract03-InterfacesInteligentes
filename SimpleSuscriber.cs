using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSuscriber : MonoBehaviour
{
    public SimpleNotificator notificator;
    // Start is called before the first frame update
    void Start()
    {
        notificator.OnMiEvento += miRespuesta;
    }

    // Update is called once per frame
    void miRespuesta() {
        Debug.Log("Respuesta");
        Debug.Log(notificator.contador);
    }
}
