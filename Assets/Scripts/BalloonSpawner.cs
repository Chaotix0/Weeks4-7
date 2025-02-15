using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Balloon balloon;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (balloon == null)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        GameObject BalloonGO = Instantiate(prefab);
        balloon = BalloonGO.GetComponent<Balloon>();
    }

}