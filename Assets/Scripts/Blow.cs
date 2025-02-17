using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blow : MonoBehaviour
{
    public GameObject balloon;
    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();

        button.onClick.AddListener(BlowBalloon);
        //start scene with balloon not there
        balloon.SetActive(false);
    }

    void BlowBalloon()
    {
        //balloob is set on when button is clicked and turned off when time is up
        balloon.SetActive(true);
        Instantiate(balloon, new Vector3(-0.01f, -3.06f, 0), Quaternion.identity);
        balloon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
