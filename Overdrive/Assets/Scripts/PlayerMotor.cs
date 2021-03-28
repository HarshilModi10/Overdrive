using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 5.0f;
    private float animationDuration = 3.0f; //animation duration at the start of the game
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time < animationDuration)//if time right now below 3 seconds
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;//player cant move
        }
        //pass 3 seconds

        moveVector = Vector3.zero;
        //X - Left and Right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        //Y - Up and Down

        //Z - Forward and Backward
        moveVector.z = speed;

        controller.Move(moveVector * Time.deltaTime);
    }
}
