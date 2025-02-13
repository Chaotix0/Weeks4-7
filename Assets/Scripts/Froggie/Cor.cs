using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cor : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right * speed;
        if (transform.position.x <= -7.5)
        {
            transform.position += Vector3.right * 15;
        }
    }
}
