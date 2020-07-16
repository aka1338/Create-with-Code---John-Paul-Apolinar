using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ObjectCollision : MonoBehaviour
{
    private Vector3 outsideMap = new Vector3(0, -100, 0);
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collided with " + col.gameObject.name);
        if (col.gameObject.name == "Vehicle") {
            Debug.Log("Caught it!");
            gameObject.transform.position = outsideMap; 
            
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
