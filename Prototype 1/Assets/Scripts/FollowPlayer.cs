using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// It is in good practice to have zero hard coded numbers. 
public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, -8);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Offset the camera behind the player
        transform.position = player.transform.position + offset;
    }
}
