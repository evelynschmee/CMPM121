using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControllerScript : MonoBehaviour
{
    // Player stuff
    CharacterController controller;
    Vector3 movement;
    Animator anim;

    [SerializeField]
    float speed = 30.0f;
    [SerializeField]
    float gravity = 2.0f;
    float jumpStrength = 50;
    float h,v;
    
    // collectible stuff
    public int score = 0;



    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {

            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

            movement = new Vector3(h, 0, v);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                movement += Vector3.up * jumpStrength;
            }


        } 
        else
        {
            movement += new Vector3(0, -gravity, 0);
        }
            //movement.y -= gravity * Time.deltaTime;
        controller.Move(movement.normalized*speed * Time.deltaTime);


    }

}
