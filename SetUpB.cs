using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpB : MonoBehaviour
{
    private Notificator notificator;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Target").transform;
        }
        notificator = Notificator.instance;
        notificator.OnApproachC += LookAt;
        notificator.OnTouchA += Grow;
    }

    void LookAt()
    {
        Debug.Log("Looking at");
        transform.LookAt(target);
        Debug.DrawRay(transform.position, transform.forward, Color.blue);
    }

    void Grow()
    {
        Debug.Log("Growing");
        transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
    }
}
