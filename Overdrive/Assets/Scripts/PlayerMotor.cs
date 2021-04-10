using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 5.0f;
    private float animationDuration = 3.0f; //animation duration at the start of the game
    private float startTime;

    private bool isDead = false;

    private Mesh characterMesh;

    private static CosmeticItem character;

    public GameObject player;

    public PauseMenu pause;

    private bool isPaused;



    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Time.timeScale = 1; //unpauses the time
        startTime = Time.time;

        isPaused = false;
        //set character model based on selection
        characterMesh = Resources.GetBuiltinResource<Mesh>(character.getName() + ".fbx");
        // resize if necessary
        if (character.getName() == "Capsule") {
            //characterMesh.transform.localScale -= 0.5;
            Vector3 newScale = transform.localScale;
            newScale *= 0.5f;
            transform.localScale = newScale;
            controller.radius *= 0.5f;
        } else if (character.getName() == "Sphere") {
            Vector3 newScale = transform.localScale;
            newScale *= 0.5f;
            transform.localScale = newScale;
            controller.radius *= 0.5f;
        }
        characterMesh.RecalculateNormals();
        characterMesh.RecalculateBounds();
        player.GetComponent<MeshFilter>().mesh = characterMesh;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;//exit when dead
        }
        if(Time.time - startTime < animationDuration)//if time right now below 3 seconds (need to minus startTime because playing again doesnt reset the time)
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
        float scaleFactor = 1.0f;
        if (character.getName() != "Cube") {
            scaleFactor = 0.5f;
        }
        if(hit.point.z > transform.position.z*scaleFactor + controller.radius && transform.position.z > 0) //the point of z-axis of player passes z-axis of something
        {
            Time.timeScale = 0; //pauses the time
            Death();
            
        }
    }

    private void Death()
    {
        isDead = true;
        GetComponent<Score>().OnDeath();
    }

    public static void setPlayerCosmetic(CosmeticItem cosmetic) {
        character = cosmetic;
    }

    public void pauseGame(){
        isPaused = true;
        GetComponent<PauseMenu>().pause();
    }
    public void resumeGame(){
        isPaused = false;
        GetComponent<PauseMenu>().resume();
    }

}
