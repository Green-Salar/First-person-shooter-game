using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermotions : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;
    public float groundDistance = 0.4f; // radious of ground groundCheck
    bool isGrounded;
    bool forward;
    bool backward;
    Vector3 velocity;// gives velocity of the player
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    float airTime;


    public LayerMask groundMask;//checking the mask of the one object wanted
    // a layer has made with name of ground and then in plane obget layer ground has choose. Then in the component of player variable
    // ground mask is choosed  to grounhd
    // After we push the obj with controller into anim we can change our parameters of the controller mentioned in the script
    public Animator anim;
    void Update()
    {

        if(Input.GetKey("up")||Input.GetKey("w")){
          forward = true;
          backward = false;
        }
        if(Input.GetKey("s")||Input.GetKey("down")){
          forward = false;
          backward = true;
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded){
          airTime = 0;
        } else{
          airTime = airTime + Time.deltaTime;
        }
        // for when it is on an object
        if(airTime > 1){
          isGrounded = true;
        }

        if(isGrounded && velocity.y<0){
          velocity.y = -2;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical"); // vertical in out cordination is forward!
        Vector3 move = transform.right * x + transform.forward * z ;// trasform correspond to the transform of the player object componnent
        controller.Move(move/10);
        anim.SetBool("isGrounded",isGrounded);
        anim.SetFloat("speed",move.magnitude);
        anim.SetBool("forward",forward);
        anim.SetBool("backward",backward);

        velocity.y += gravity * 1.8f * Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
        if(Input.GetButtonDown("Jump") && isGrounded){
            anim.SetBool("isGrounded",false);
            velocity.y = Mathf.Sqrt(jumpHeight * -2 *gravity);

        }
    }
}
