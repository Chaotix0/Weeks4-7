using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject player;
    public string trap;
    GameObject trapObj;

    void Start()
    {
        trapObj = this.gameObject.transform.parent.gameObject.transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if (Vector2.Distance(player.transform.position, transform.position) < 1f)
        {
            switch (trap)
            {
                case "Pendulum":
                    Pendulum script1 = trapObj.GetComponent<Pendulum>();
                    script1.Trap();
                    break;
                case "Bird":
                    Bird script2 = trapObj.GetComponent<Bird>();
                    script2.Trap();
                    break;
                case "BigGear":
                    BigGear script3 = trapObj.GetComponent<BigGear>();
                    script3.Trap();
                    break;
                default:
                    Debug.Log("A pressure plate is empty or not set up correctly");
                    break;
            }
        }
    }
}
