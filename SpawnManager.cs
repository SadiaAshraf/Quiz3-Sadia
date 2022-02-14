using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnPrefab;
    //private Vector3 spawnPos = new Vector3(0, 0, Random.Range(-15, 15));//Random.Range(-15, 15)
    void Start()
    {
        //InvokeRepeating("SpawnObstacle", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //void SpawnObstacle()
    //{


    //    Instantiate(spawnPrefab, spawnPos, spawnPrefab.transform.rotation);


    //}
}
