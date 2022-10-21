using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpB : MonoBehaviour
{
    public Notificator notificator;
    // Start is called before the first frame update
    void Start()
    {
        notificator.OnApproachC += LookAt;
        notificator.OnTouchA += Grow;
    }

    void LookAt()
    {
        Debug.Log("Looking at");
    }

    void Grow()
    {
        Debug.Log("Growing");
    }
}
