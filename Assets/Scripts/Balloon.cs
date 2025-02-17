using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    //varibles for Balloon
    public float speed = 3;
    public Transform balloon;
    public AnimationCurve curve;
    float t;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        Movement(); 
    }
    void Movement()
    {
        //scales up the balloon
        t += Time.deltaTime;
        transform.position += transform.up * speed * Time.deltaTime;
        transform.localScale = Vector2.one * curve.Evaluate(t);
        //destroys balloon after 7 seconds
        if (t >= 7) 
        {
            Destroy(self);
        }
    }
}
