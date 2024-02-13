using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public Vector3 spawnPosition;

    private float initialDelay = 2f;
    private float repeatInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", initialDelay, repeatInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab);
    }
}
