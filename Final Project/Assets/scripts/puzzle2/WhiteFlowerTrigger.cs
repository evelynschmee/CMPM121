/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteFlowerTrigger : MonoBehaviour
{ 
    Color color1, color2, newColor;
    bool onTrigger = false;

    void OnTriggerEnter(Collider other)
    {
        // circle contacts the trigger
        if (other.gameObject.CompareTag("Circle"))
        {
            // set ontrigger to true since the circle is touching the plate
            onTrigger = true;

            // if the circle is contacting with the trigger; set the trigger to true and player presses space
            if (onTrigger != false && Input.GetKeyDown(KeyCode.Space))
            {

            }




            // if its red change it to blue
            else if (Flower1.f1BaseColor == ColorScript.red)
            {
                if (its yellow ){
                    Color_Changer it to orange
                            colorCount += 1;
                }
                if its blue{
                    Color_Changer it  to purple
                    }
                //color1 = ColorScript.red;
                color2 = ColorScript.blue;

                ColorScript.changeColor(Flower1.flower1, color2);
                Flower1.f1BaseColor = color2;

                // change the turtle to yellow
                ColorScript.changeColor(TurtleScript.turtle, ColorScript.yellow);
                TurtleScript.tBaseColor = ColorScript.yellow;

            }

            // if its blue change it to red
            else if (Flower1.f1BaseColor == ColorScript.blue)
            {
                //color1 = ColorScript.green;

                ColorScript.changeColor(Flower1.flower1, ColorScript.red);
                Flower1.f1BaseColor = ColorScript.red;

                // change the turtle to blue
                ColorScript.changeColor(TurtleScript.turtle, ColorScript.blue);
                TurtleScript.tBaseColor = ColorScript.blue;

            }

            // if its red change it to green
            else if (Flower1.f1BaseColor == ColorScript.red)
            {
                //color1 = ColorScript.blue;
                color2 = ColorScript.green;
                ColorScript.changeColor(Flower1.flower1, ColorScript.green);
                Flower1.f1BaseColor = color2;

                // change the turtle to red
                ColorScript.changeColor(TurtleScript.turtle, ColorScript.red);
                TurtleScript.tBaseColor = ColorScript.red;
            }

            // if its green change it to yellow
            else if (Flower1.f1BaseColor == ColorScript.green)
            {
                //color1 = ColorScript.blue;
                color2 = ColorScript.yellow;

                ColorScript.changeColor(Flower1.flower1, ColorScript.yellow);
                Flower1.f1BaseColor = color2;

                // change the turtle to red
                ColorScript.changeColor(TurtleScript.turtle, ColorScript.red);
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
*/