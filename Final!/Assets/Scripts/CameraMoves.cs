using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoves : MonoBehaviour
{
    //variables 
    public GameObject target; 

    // Update is called once per frame
    void Update() 
    {
        transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);       //camera follows player left and right 

    }
}
