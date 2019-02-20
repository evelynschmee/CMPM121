using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControllerScript : MonoBehaviour
{
    // Player stuff
    CharacterController controller;
    //float jumpStrength = 50;
    Vector3 movement;
    [SerializeField]
    float speed = 6.0f;
    [SerializeField]
    float gravity = 9.0f;
    float h,v;
    float rotSpeed = 80;
    float rot = 0f;
    
    // collectible stuff
    public int score = 0;
    public Text scoreText;
    public Text controlText;
    public Text winText;
    public Text helpText;

    public ParticleSystem part;
    public static Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        part = GetComponent<ParticleSystem>();

        //score = 0;
        scoreText.text = "Score: " + score.ToString();

        controlText.text = "WASD to Move \nSpacebar to Use \n Your Power!";
        winText.text = "";
        helpText.text = "Get the 'Key' \nTo Open The Door"; 

    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            if( Input.GetKey(KeyCode.W))
            {
                anim.SetInteger("condition", 1);
                movement = new Vector3(0, 0, 1);
                movement *= speed;
                movement = transform.TransformDirection(movement);
            }

            if (Input.GetKeyUp(KeyCode.W))
            {
                anim.SetInteger("condition", 0);
                movement = new Vector3(0, 0, 0);
            }
            /*
            if (Input.GetKey(KeyCode.Space))
            {

                anim.SetInteger("condition", 2);
                movement = new Vector3(0, 0, 0);
                Debug.Log("space was pressed");

            }*/
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetInteger("condition", 2);
                movement = new Vector3(0, 0, 0);
            }

        }

        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        movement.y -= gravity * Time.deltaTime;
        controller.Move(movement * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            score += 1;
            SetScoreText();
        }
    }

    private void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();

        if (score >= 3)
        {
            winText.text = "All the Cubes!";
        }
    }

}

/*Sources:
 * this tutorial that pretty much was the assignment https://unity3d.com/learn/tutorials/projects/roll-ball-tutorial/displaying-score-and-text?playlist=17141
 * animating help: https://www.youtube.com/watch?v=ReauId6jFFI&t=1234s
 */    