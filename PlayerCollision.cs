using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Object B")
        {
            Notificator.instance.InvokeOnTouchB();
        }
        if (collision.gameObject.tag == "Object A")
        {
            Notificator.instance.InvokeOnTouchA();
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Object C")
        {
            Notificator.instance.InvokeOnApproachC();
        }
    }
}
