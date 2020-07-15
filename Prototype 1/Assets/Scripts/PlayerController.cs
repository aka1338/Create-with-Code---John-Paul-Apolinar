using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declaring a float requires f at the end. Public due to usage outside of class. 
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Making the vehicle move forward
        transform.Translate(Vector3.forward*Time.deltaTime * speed);
    
    }
}
