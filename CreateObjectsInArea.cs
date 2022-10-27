using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjectsInArea : MonoBehaviour
{
    public Transform[] objects;
    public int numberOfObjects;
    public Vector2 rangeX = new Vector2(0, 10);
    public Vector2 rangeY = new Vector2(0, 10);
    public Vector2 rangeZ = new Vector2(0, 10);

    void Start()
    {
        // Creates the number of objects specified in the inspector in a random position within the range specified in the inspector
        for (int i = 0; i < numberOfObjects; i++)
        {
            int randomObject = Random.Range(0, objects.Length);
            Vector3 randomPosition = new Vector3(Random.Range(rangeX.x, rangeX.y), Random.Range(rangeY.x, rangeY.y), Random.Range(rangeZ.x, rangeZ.y));
            Transform obj = Instantiate(objects[randomObject], randomPosition, Quaternion.identity);
            obj.parent = transform;
        }
    }

}
