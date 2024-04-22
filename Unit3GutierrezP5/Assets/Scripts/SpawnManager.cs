using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obsticlePrefabs;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    private int randomObsticle;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObsticle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObsticle ()
    {
        if(playerControllerScript.gameOver == false)
        {
            randomObsticle = Random.Range(0, obsticlePrefabs.Length);
            Instantiate(obsticlePrefabs[randomObsticle], spawnPos, obsticlePrefabs[randomObsticle].transform.rotation);
        }

    }
}
