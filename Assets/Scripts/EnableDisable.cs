using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public SpriteRenderer sr;
    public EnableDisable Script;
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when mouse is pressed down disable sprite renderer
        if (Input.GetMouseButtonDown(0)) {
            sr.enabled = false;
            go.SetActive(false);
        }

        //when space is pressed enable sprite renderer
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = true;
            go.SetActive(true);
        }
    }
}
