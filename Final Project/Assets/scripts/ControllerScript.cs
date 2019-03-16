using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControllerScript : MonoBehaviour
{
    // Player stuff
    CharacterController controller;
    Vector3 movement;

    [SerializeField]
    float speed = 6.0f;
    [SerializeField]
    float gravity = 2.0f;
    float jumpStrength = 50;
    float h,v;
    
    // collectible stuff
    public int score = 0;

    /*
    public Text scoreText;
    public Text controlText;
    public Text winText;
    public Text helpText;
    */   

        /*
    public ParticleSystem part;
    public static Animator anim;
    */   


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //anim = GetComponent<Animator>();
        //part = GetComponent<ParticleSystem>();

        //score = 0;
        //scoreText.text = "Score: " + score.ToString();

        //controlText.text = "WASD to Move \nSpacebar to Use \n Your Power!";
       // winText.text = "";
        //helpText.text = "Get the 'Key' \nTo Open The Door"; 

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
    /*
    void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PuzzleLily.changeColor(PuzzleLily.black, PuzzleLily.pink);
        }
    }
    */
    /*

private void SetScoreText()
{
    scoreText.text = "Score: " + score.ToString();

    if (score >= 3)
    {
        winText.text = "All the Cubes!";
    }
}
*/

}

/*Sources:
 * this tutorial that pretty much was the assignment https://unity3d.com/learn/tutorials/projects/roll-ball-tutorial/displaying-score-and-text?playlist=17141
 * animating help: https://www.youtube.com/watch?v=ReauId6jFFI&t=1234s
 */    