using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolvePuzzle1 : MonoBehaviour
{
    //private static bool haveKey;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        //haveKey = Key.playerHasKey;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LilyScript.lBaseColor = ColorScript.red;
            TurtleScript.tBaseColor = ColorScript.green;
            FlowerScript.fBaseColor = ColorScript.yellow;

            Debug.Log("cheat");
        }
        // checks if Lily is Red, Turtle is Green, Flower is Yellow
        /*
        if (LilyScript.lily.material.color == ColorScript.red && TurtleScript.turtle.material.color == ColorScript.green &&
               FlowerScript.flower.material.color == ColorScript.yellow)
        {*/

        if(LilyScript.lBaseColor == ColorScript.red && TurtleScript.tBaseColor == ColorScript.green && FlowerScript.fBaseColor == ColorScript.yellow) 
        {
        // move game object
        // change camera
        // move the blocker up
        door.transform.position += new Vector3(0, 6, 0);
            // set the cutscene camera and deactivate camera1
            //CameraController.cameraCS.SetActive(true);
            //CameraController.camera2.SetActive(false);
            // this needs to be reactivated within an interval
        }

    }

    void OnTriggerEnter(Collider other)
    {
        // player collides with the object that changes cam and locks door
        if (other.gameObject.CompareTag("Player"))
        {
            CameraController.CameraMode = 2;
        }
    }

}
