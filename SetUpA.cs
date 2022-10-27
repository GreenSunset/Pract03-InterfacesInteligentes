using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpA : MonoBehaviour
{
    private Notificator notificator;
    public Transform cObject;
    public Vector3 colorMultiplier = new Vector3(0.2f, 0.1f, 0.3f);
    // Start is called before the first frame update
    void Start()
    {
        notificator = Notificator.instance;
        if (cObject == null)
        {
            cObject = GameObject.FindGameObjectWithTag("Object C").transform;
        }
        notificator.OnApproachC += Jump;
        notificator.OnApproachC += ChangeColor;
        notificator.OnTouchB += ApproachC;
    }

    void Jump()
    {
        Debug.Log("Jump");
        if(Physics.Raycast(transform.position, -Vector3.up, GetComponent<Collider>().bounds.extents.y + 0.1f)) {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }

    void ChangeColor()
    {
        Debug.Log("ChangeColor");
        Color original = GetComponent<Renderer>().material.color;
        Color newColor = new Color((original.r + colorMultiplier.x * Time.deltaTime), (original.g + colorMultiplier.y * Time.deltaTime), (original.b + colorMultiplier.z * Time.deltaTime));
        if (newColor.r > 1 || newColor.r < 0) colorMultiplier.x = -colorMultiplier.x;
        if (newColor.g > 1 || newColor.g < 0) colorMultiplier.y = -colorMultiplier.y;
        if (newColor.b > 1 || newColor.b < 0) colorMultiplier.z = -colorMultiplier.z;
        GetComponent<Renderer>().material.color = newColor;
        // Change emission color
        GetComponent<Renderer>().material.SetColor("_EmissionColor",newColor);
    }

    void ApproachC()
    {
        Debug.Log("ApproachC");
        transform.position = Vector3.MoveTowards(transform.position, cObject.position, Time.deltaTime);
    }
}
