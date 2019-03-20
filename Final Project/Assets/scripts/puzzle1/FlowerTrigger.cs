using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerTrigger : MonoBehaviour
{
    Color color1, color2, newColor;
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
        Debug.Log("hello");
        // player contacts the trigger
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("trig: " + onTrigger);
            // set ontrigger to true since the player is touching the plate
            onTrigger = true;

            // if the player is contacting with the trigger; set the trigger to true
            if (onTrigger != false)
            {
                // if its darkgray change it to yellow
                if (FlowerScript.fBaseColor == ColorScript.darkGray)
                {
                    //color1 = ColorScript.black;
                    newColor = ColorScript.yellow;

                    //ColorScript.changeColor(FlowerScript.flower, newColor);
                    FlowerScript.fBaseColor = newColor;

                    // play animation

                }
                // if its yellow change it to blue
                else if (FlowerScript.fBaseColor == ColorScript.yellow)
                {
                    //color1 = ColorScript.red;
                    color2 = ColorScript.blue;

                    //ColorScript.changeColor(FlowerScript.flower, color2);
                    FlowerScript.fBaseColor = color2;

                    // change the turtle to yellow
                    //ColorScript.changeColor(TurtleScript.turtle, ColorScript.yellow);
                    TurtleScript.tBaseColor = ColorScript.yellow;

                }

                // if its blue change it to red
                else if (FlowerScript.fBaseColor == ColorScript.blue)
                {
                    //color1 = ColorScript.green;

                    //ColorScript.changeColor(FlowerScript.flower, ColorScript.red);
                    FlowerScript.fBaseColor = ColorScript.red;

                    // change the turtle to blue
                    //ColorScript.changeColor(TurtleScript.turtle, ColorScript.blue);
                    TurtleScript.tBaseColor = ColorScript.blue;

                }

                // if its red change it to green
                else if (FlowerScript.fBaseColor == ColorScript.red)
                {
                    //color1 = ColorScript.blue;
                    color2 = ColorScript.green;
                    //ColorScript.changeColor(FlowerScript.flower, ColorScript.green);
                    FlowerScript.fBaseColor = color2;
      
                    // change the turtle to red
                    //ColorScript.changeColor(TurtleScript.turtle, ColorScript.red);
                    TurtleScript.tBaseColor = ColorScript.red;
                }

                // if its green change it to yellow
                else if (FlowerScript.fBaseColor == ColorScript.green)
                {
                    //color1 = ColorScript.blue;
                    color2 = ColorScript.yellow;
                    //ColorScript.changeColor(FlowerScript.flower, ColorScript.yellow);
                    FlowerScript.fBaseColor = color2;

                    // change the turtle to red
                   // ColorScript.changeColor(TurtleScript.turtle, ColorScript.red);
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
