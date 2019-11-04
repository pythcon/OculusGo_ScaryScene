using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMove : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public bool initial;
    public Transform originalObject;
    public Transform reflectedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (initial)
        {
            // Move the object forward along its z axis 1 unit/second.
            transform.Translate(0, 0, -Time.deltaTime * moveSpeed);
        }
        else
        {
            // Move the object forward along its z axis 1 unit/second.
            transform.Translate(0, 0, -Time.deltaTime * moveSpeed);
            reflectedObject.position = Vector3.Reflect(originalObject.position, Vector3.right);
        }
    }
}
