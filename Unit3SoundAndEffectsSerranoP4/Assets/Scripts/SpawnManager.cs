using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);


    void Start()
    {
        Istantiate(obstaclePrefab, spawnPos, obstaclePrefab.tansform.rotation);
    }


    void Update()
    {

    }
}