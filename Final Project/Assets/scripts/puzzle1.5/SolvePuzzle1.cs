using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolvePuzzle1 : MonoBehaviour
{
    public GameObject door;

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
        if(LilyScript.lBaseColor == ColorScript.red && TurtleScript.tBaseColor == ColorScript.green && FlowerScript.fBaseColor == ColorScript.yellow) 
        {
            // move the blocker up
            door.transform.position += new Vector3(0, 6, 0);
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
