using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleTrigger : MonoBehaviour
{
    Color newColor;
    bool onTrigger = false;
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("ontrigger: " + onTrigger);
            Debug.Log("Turtlescript.tBaseColor+ " + TurtleScript.tBaseColor);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // player contacts the trigger
        if (other.gameObject.CompareTag("Player"))
        {
            // set ontrigger to true since the player is touching the plate
            onTrigger = true;

            // if the player is contacting with the trigger; set the trigger to true
            if (onTrigger != false)
            {
                // if its gray change it to blue
                if (TurtleScript.tBaseColor == ColorScript.gray)
                {
                    newColor = ColorScript.blue;

                    // change the turtle to blue
                    TurtleScript.tBaseColor = newColor;
                }
                // if its blue change it to yellow
                else if (TurtleScript.tBaseColor == ColorScript.blue)
                {
                    newColor = ColorScript.yellow; 
                    TurtleScript.tBaseColor = newColor;

                    // change the flower to red
                    FlowerScript.fBaseColor = ColorScript.red;
                }

                // if its yellow change it to green
                else if (TurtleScript.tBaseColor == ColorScript.yellow)
                {
                    newColor = ColorScript.green;
                    TurtleScript.tBaseColor = newColor;
                    
                    // change the flower to yellow
                    FlowerScript.fBaseColor = ColorScript.yellow;
                }

                // if its green change it to red
                else if (TurtleScript.tBaseColor == ColorScript.green)
                {
                    newColor = ColorScript.red;
                    TurtleScript.tBaseColor = newColor;

                    // change the flower to blue
                    FlowerScript.fBaseColor = ColorScript.blue;
                }
                // if its red change it to blue
                else if (TurtleScript.tBaseColor == ColorScript.red)
                {
                    newColor = ColorScript.blue;
                    TurtleScript.tBaseColor = newColor;

                    // change the flower to blue
                    FlowerScript.fBaseColor = ColorScript.blue;
                }
                onTrigger = false;
            }
        }

    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        // when the player exits the trigger allow the color to change
        onTrigger = false;
    }
}
