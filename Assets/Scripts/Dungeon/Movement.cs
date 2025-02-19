using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float slowSpeed;
    public bool slowDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (slowDown)
        {
            transform.position += (Vector3.right * Input.GetAxisRaw("Horizontal") * slowSpeed + Vector3.up * Input.GetAxisRaw("Vertical") * slowSpeed);
        }
        else
        {
            transform.position += (Vector3.right * Input.GetAxisRaw("Horizontal") * speed + Vector3.up * Input.GetAxisRaw("Vertical") * speed);
        }
        slowDown = false;
    }
}
