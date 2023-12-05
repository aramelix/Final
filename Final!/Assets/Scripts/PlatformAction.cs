using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAction : MonoBehaviour
{
    // I want the platforms to move a second after the player lands/moves on the platform. 
    //Two ways: Do a transform y-movement on the platform? OR get the rigidbody, and code to remove the freeze position on the y

    //variables 
    



    // Start is called before the first frame update
    void Start()
    {
        //bad = gameObject.GetComponent<RigidBody2D>();  //Look at gameObject (Which is the BadLilPlatform) 
                                                       //and then pay attention to the component (Which is RigidBody2D) 
    }

    // Update is called once per frame
    void Update() 
    {
        
    } 
}
