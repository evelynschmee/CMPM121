using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyTrigger : MonoBehaviour
{
    Color newColor;
    bool onTrigger = false;

    private void Start()
    {
        LilyScript.lBaseColor = ColorScript.black;
    }

    void OnTriggerEnter(Collider other)
    {
        // player contacts the trigger
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("hi");
            // set ontrigger to true since the player is touching the plate
            onTrigger = true;

            // if the player is contacting with the trigger; set the trigger to true
            if (onTrigger != false)
            {
                Debug.Log("hey");
                Debug.Log("lbasecolor" + LilyScript.lBaseColor);
                // if its black change it to red
                if (LilyScript.lBaseColor == ColorScript.black)
                {
                    Debug.Log("uhhh");

                    newColor = ColorScript.red;
                    LilyScript.lBaseColor = newColor;
                }

                // if its red change it to green
                else if (LilyScript.lBaseColor == ColorScript.red)
                {
                    newColor = ColorScript.green;
                    LilyScript.lBaseColor = newColor;

                    // change the turtle to red
                    TurtleScript.tBaseColor = ColorScript.red;
                }

                // if its green change it to blue
                else if (LilyScript.lBaseColor == ColorScript.green)
                {
                    newColor = ColorScript.blue;
                    LilyScript.lBaseColor = newColor;

                    // change the turtle to red
                    TurtleScript.tBaseColor = ColorScript.yellow;
                }

                // if its blue change it to red
                else if (LilyScript.lBaseColor == ColorScript.blue)
                {
                    newColor = ColorScript.red;
                    LilyScript.lBaseColor = newColor;

                    // change the turtle to blue
                    TurtleScript.tBaseColor = ColorScript.blue;
                }
                // if its yellow change it to red
                else if (LilyScript.lBaseColor == ColorScript.yellow)
                {
                    newColor = ColorScript.red;
                    LilyScript.lBaseColor = newColor;

                    // change the turtle to blue
                    TurtleScript.tBaseColor = ColorScript.blue;
                }
                onTrigger = false;
            }
        }

    }


    private void OnTriggerExit(Collider other)
    {
        // when the player exits the trigger, leaves or jumping, allow the color to change
        onTrigger = false;
    }
}
