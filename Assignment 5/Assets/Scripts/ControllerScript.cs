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

    public ParticleSystem part;
    private Animator anim;

    public float knockBackForce;
    public float knockbackTime;
    private float knockBackCounter;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        part = GetComponent<ParticleSystem>();

        //score = 0;
        scoreText.text = "Score: " + score.ToString();

        controlText.text = "Arrowkeys to Move \n Spacebar to Jump \n C to Switch Camera \n Move Mouse to Look Around";
        winText.text = "";
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

            if (Input.GetKeyUp(KeyCode.Space))
            {
                anim.SetInteger("condition", 0);
                
            }
            /*
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

                       

            movement = new Vector3(h, 0, v);
        }
        else
        {
            movement += new Vector3(0, -gravity, 0);
            */
        }
        //controller.Move(movement * speed * Time.deltaTime);

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

        if (score >= 8)
        {
            winText.text = "You Win!";
        }
    }

    private void Knockback()
    {
        knockBackCounter = knockbackTime;

    }
}

/*Sources:
 * this tutorial that pretty much was the assignment https://unity3d.com/learn/tutorials/projects/roll-ball-tutorial/displaying-score-and-text?playlist=17141*/
