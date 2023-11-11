using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject[] obstaclePrefab;
    
    private float startDelay = 1;
    private float repeatRate = 2;

    private Vector3 spawnPos = new Vector3(25, 0, 0);

    private PlayerController playerControllerScript;

    private int obstacleIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
            obstacleIndex = Random.Range(0, obstaclePrefab.Length);
            
            Instantiate(obstaclePrefab[obstacleIndex], spawnPos, obstaclePrefab[obstacleIndex].transform.rotation);
        }
        
    }
}
