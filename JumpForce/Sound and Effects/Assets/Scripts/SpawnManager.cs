using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(40, 0, 0);
    private float startDelay = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnObstacle", startDelay);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void spawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            float repeatRate = Random.Range(2, 5);
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            Invoke("spawnObstacle", repeatRate);
        }
    }
}
