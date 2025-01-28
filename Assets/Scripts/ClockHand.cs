using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHand : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public bool hour;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -5 * Time.deltaTime);
        //Debug.Log();
        if (transform.eulerAngles.z <= -30) {
            hour = true;
        }
        //Vector3 rot = transform.eulerAngles;
        //rot.z += 1;
        //transform.eulerAngles = rot;

        //play audio
        //audioSource.Play();
        if (hour == true) {
            audioSource.PlayOneShot(clip);
            
        }
    }
}

