using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerTrigger : MonoBehaviour
{
    Color newColor;
    bool onTrigger = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("base: " + FlowerScript.fBaseColor);
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
                // if its darkgray change it to yellow
                if (FlowerScript.fBaseColor == ColorScript.darkGray)
                {
                    newColor = ColorScript.yellow;
                    FlowerScript.fBaseColor = newColor;
                }
                // if its yellow change it to blue
                else if (FlowerScript.fBaseColor == ColorScript.yellow)
                {
                    newColor = ColorScript.blue;
                    FlowerScript.fBaseColor = newColor;

                    // change the turtle to yellow
                    TurtleScript.tBaseColor = ColorScript.yellow;
                }

                // if its blue change it to red
                else if (FlowerScript.fBaseColor == ColorScript.blue)
                {
                    newColor = ColorScript.red;
                    FlowerScript.fBaseColor = newColor;

                    // change the turtle to blue
                    TurtleScript.tBaseColor = ColorScript.blue;
                }

                // if its red change it to green
                else if (FlowerScript.fBaseColor == ColorScript.red)
                {
                    newColor = ColorScript.green;
                    FlowerScript.fBaseColor = newColor;
      
                    // change the turtle to red
                    TurtleScript.tBaseColor = ColorScript.red;
                }

                // if its green change it to yellow
                else if (FlowerScript.fBaseColor == ColorScript.green)
                {
                    newColor = ColorScript.yellow;
                    FlowerScript.fBaseColor = newColor;

                    // change the turtle to red
                    TurtleScript.tBaseColor = ColorScript.red;
                }
                onTrigger = false;
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        // when the player exits the trigger allow the color to change
        onTrigger = false;
    }
}
