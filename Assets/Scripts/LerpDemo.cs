using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour

{
    [Range(0, 1)]
    public float t;
    public AnimationCurve curve;
    public Transform start;
    public Transform end;
    public GameObject self;

    // Start is called before the first frame update
    void Start()
    {
        t = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
        //gets the time and runs at 60fps
        t += Time.deltaTime / 10;
        if (t >= 1)
        {
            Destroy(self);
        }
    }
}
