using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleNotificator : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje OnMiEvento;
    public int contador = 0;
    void Update()
    {
        contador++;
        if (contador % 1000 == 0)
        {
            OnMiEvento();
        }
    }
}
