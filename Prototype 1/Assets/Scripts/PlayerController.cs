using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declaring a float requires f at the end. Public due to usage outside of class. 
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput; 
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Setting our horizontal and forward input floats to calculate turning/turn speed. 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical"); 

        // Making the vehicle move forward
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);

        // Making the vehicle turn left or right. At the end, I multiply this by forward input to not allow turning when there is no acceleration. 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput * forwardInput); 
        
    }
}
