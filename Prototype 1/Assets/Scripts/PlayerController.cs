using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 18f; // 18f
    private float turnSpeed = 90f; // 70f
    private float horizontalInput; 
    private float forwardInput; 
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input. 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical"); 

        // Making the vehicle move forward
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);

        // Making the vehicle turn left or right. At the end, I multiply this by forward input to not allow turning when there is no acceleration. 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput * forwardInput); 
        
    }
}
