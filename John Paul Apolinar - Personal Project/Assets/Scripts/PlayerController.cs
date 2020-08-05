using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public float windForce = 90f; // 70f
    private float horizontalInput;
    private float forwardInput;
    public float gravityModifier = 10;
    public float initialPush = 40f; 

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.AddForce(Vector3.forward*initialPush, ForceMode.Impulse);
        Physics.gravity *= gravityModifier;
    }


    // Update is called once per frame
    void Update()
    {
        // This is where we get player input. 
        horizontalInput = Input.GetAxis("Horizontal");
        
        // The player can activate "wind" that pushes the tire either left or right. 
        playerRb.AddForce(Vector3.right * Time.deltaTime * horizontalInput * windForce, ForceMode.Impulse);
    }
}
