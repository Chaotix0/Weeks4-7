using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Spider : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float viewDistance;

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, transform.position) < viewDistance)
        {
            transform.position += -(transform.position - player.transform.position).normalized * speed;
        }
    }
}
