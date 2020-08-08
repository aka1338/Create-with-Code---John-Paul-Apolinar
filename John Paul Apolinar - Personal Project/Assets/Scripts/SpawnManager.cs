using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] hillPrefabs;
    public GameObject player; 
    private float hillThreshold;
    private float startDelay = 2;
    private float spawnInterval = 2.5f;
    private Vector3 initialPos = new Vector3(23.52642f, -8.64f, -6.99f); 
    

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(hillPrefabs[0], initialPos, hillPrefabs[0].transform.rotation); 
        hillThreshold = 22.52f + 119f; 
    }

    // Update is called once per frame
    void Update()
    {

        if (player.transform.position.y < -hillThreshold) {
            Instantiate(hillPrefabs[0], initialPos + new Vector3(0, -230.356554f, 299.599481f), hillPrefabs[0].transform.rotation);
            hillThreshold += 119f;
            initialPos = initialPos + new Vector3(0, -230.356554f, 299.599481f); 
        }

        
    }

}
