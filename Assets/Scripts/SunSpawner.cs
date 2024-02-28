using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawner : MonoBehaviour
{
    public GameObject sunObject;

    private void Start()
    {
        SpawnSun();
    }

    void SpawnSun()
    {
        GameObject mySun = Instantiate(sunObject, new Vector3(Random.Range(-4f, 8.35f), 6, 0), Quaternion.identity);
        mySun.GetComponent<Sun>().dropToYPos = Random.Range(1.5f, 3.5f);
        Invoke("SpawnSun", Random.Range(4, 10));
    }
}
