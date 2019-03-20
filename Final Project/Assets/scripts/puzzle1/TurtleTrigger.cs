using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleTrigger : MonoBehaviour
{
    Color color1, color2, newColor;
    bool onTrigger = false;

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
                    color1 = ColorScript.gray;
                    color2 = ColorScript.blue;

                    // change the turtle to blue
                    //ColorScript.changeColor( TurtleScript.turtle,color2);
                    TurtleScript.tBaseColor = color2;

                    Debug.Log("turt b");

                }
                // if its blue change it to yellow
                else if (TurtleScript.tBaseColor == ColorScript.blue)
                {
                    //color1 = ColorScript.red;
                    color2 = ColorScript.yellow;

                    //ColorScript.changeColor(TurtleScript.turtle, color2);
                    TurtleScript.tBaseColor = color2;

                    // change the flower to red
                    //ColorScript.changeColor(FlowerScript.flower, ColorScript.red);
                    FlowerScript.fBaseColor = ColorScript.red;

                    // change the lily to 

                }

                // if its yellow change it to green
                else if (TurtleScript.tBaseColor == ColorScript.yellow)
                {
                    //color1 = ColorScript.green;

                    //ColorScript.changeColor(TurtleScript.turtle, ColorScript.green);
                    TurtleScript.tBaseColor = ColorScript.green;
                    
                    // change the flower to yellow
                    //ColorScript.changeColor(FlowerScript.flower, ColorScript.yellow);
                    FlowerScript.fBaseColor = ColorScript.yellow;
                }

                // if its green change it to red
                else if (TurtleScript.tBaseColor == ColorScript.green)
                {
                    //color1 = ColorScript.blue;
                    color2 = ColorScript.red;
                   // ColorScript.changeColor(TurtleScript.turtle, ColorScript.red);
                    TurtleScript.tBaseColor = color2;

                    // change the flower to blue
                   // ColorScript.changeColor(FlowerScript.flower, ColorScript.blue);
                    FlowerScript.fBaseColor = ColorScript.blue;

                }
                // if its red change it to blue
                else if (TurtleScript.tBaseColor == ColorScript.red)
                {
                    //color1 = ColorScript.blue;
                    color2 = ColorScript.blue;
                    //ColorScript.changeColor(TurtleScript.turtle, ColorScript.blue);
                    TurtleScript.tBaseColor = color2;

                    // change the flower to blue
                   // ColorScript.changeColor(FlowerScript.flower, ColorScript.blue);
                    FlowerScript.fBaseColor = ColorScript.blue;

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
        //PuzzleLily.color = endColor;
    }


}
