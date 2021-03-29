using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 5.0f;
    private float animationDuration = 3.0f; //animation duration at the start of the game

    private bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;//exit when dead
        }
        if(Time.time < animationDuration)//if time right now below 3 seconds
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;//player cant move
        }
        //pass 3 seconds

        moveVector = Vector3.zero;
        //X - Left and Right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

        //Z - Forward and Backward
        moveVector.z = speed;

        controller.Move(moveVector * Time.deltaTime);
    }

    public void SetSpeed(float mod)
    {
        speed = 5.0f + mod*3.0f;
    }

    //Obstacle detection
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.point.z > transform.position.z + controller.radius) //the point of z-axis of player passes z-axis of something
        {
            Death();
        }
    }

    private void Death()
    {
        Debug.Log("test death");
        isDead = true;
        GetComponent<Score>().OnDeath();
    }
}
