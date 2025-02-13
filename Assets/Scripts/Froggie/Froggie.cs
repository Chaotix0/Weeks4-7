using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Froggie : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Input.GetAxisRaw("Vertical") * speed;
        transform.position += Vector3.right * Input.GetAxisRaw("Horizontal") * speed;
    }
}
