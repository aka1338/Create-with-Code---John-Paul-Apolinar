using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public float windForce = 220f; // 70f
    private float horizontalInput;
    private float forwardInput;
    public float gravityModifier = 1.5f;
    public float initialPush = 40f;
    public float jumpForce = 40f;

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

        Debug.Log(playerRb.velocity.magnitude);

        if (playerRb.velocity.magnitude > 50) {
            playerRb.AddForce(Vector3.back*playerRb.velocity.magnitude, ForceMode.Impulse); 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse); 
        }

    }
}
