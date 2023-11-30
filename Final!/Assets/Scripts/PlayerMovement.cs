using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables 
    float speed;     //controls speed of movement 
    float move;            //controls direction of movement 
    public float jump;    // 
    bool isJumping;         //tracks if object

    Rigidbody2D rb;      //stores the rigidbody in the variable "rb"

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        jump = 250f;
        rb = GetComponent<Rigidbody2D>();   //get the rigidbody of the object 
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");     //when any of the horizontal keys are pressed 
        rb.velocity = new Vector2(speed * move, rb.velocity.y);     //change the value of the rb to move 

        //single jump limit 
        if (Input.GetButtonDown("Jump") && !isJumping) 
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;

        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Platform")) 
        {
            isJumping = false; 
        }
    }
}
