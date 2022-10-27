using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificator : MonoBehaviour
{
    public static Notificator instance;
    public delegate void message();
    public event message OnTouchB;
    public event message OnTouchA;
    public event message OnApproachC;

    private void Awake()
    {
        instance = this;
    }

    public Notificator GetInstance()
    {
        return instance;
    }

    public void InvokeOnTouchB()
    {
        OnTouchB();
    }

    public void InvokeOnTouchA()
    {
        OnTouchA();
    }

    public void InvokeOnApproachC()
    {
        OnApproachC();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            OnTouchB();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            OnTouchA();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            OnApproachC();
        }
    }
}
