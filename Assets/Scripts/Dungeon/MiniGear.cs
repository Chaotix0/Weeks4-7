using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGear : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, transform.position) < 0.5f)
        {
            player.GetComponent<Player>().gears += 1;
            Destroy(this.gameObject);
        }
    }
}
