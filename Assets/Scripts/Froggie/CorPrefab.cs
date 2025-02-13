using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorPrefab : MonoBehaviour
{
    public GameObject car;
    public Vector3 StartPos;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 9; i++)
        {
            Instantiate(car, (Vector3.right * Random.Range(-7.5f, 7.5f)) + (Vector3.up * Random.Range(-2.5f, 2.5f)), transform.rotation);
        }
        car.SetActive(false);
    }
}
