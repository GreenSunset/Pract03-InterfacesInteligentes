using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpA : MonoBehaviour
{
    public Notificator notificator;
    // Start is called before the first frame update
    void Start()
    {
        notificator.OnApproachC += Jump;
        notificator.OnApproachC += ChangeColor;
        notificator.OnTouchB += ApproachC;
    }

    void Jump()
    {
        Debug.Log("Jump");
    }

    void ChangeColor()
    {
        Debug.Log("ChangeColor");
    }

    void ApproachC()
    {
        Debug.Log("ApproachC");
    }
}
