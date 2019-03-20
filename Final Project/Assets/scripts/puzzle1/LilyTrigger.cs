using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyTrigger : MonoBehaviour
{
    Color color1, color2, newColor;
    bool onTrigger = false;

    void Start()
    {
    }

    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("ontrigger: " +onTrigger);
            Debug.Log("LilyScript.lBaseColor+ " + LilyScript.lBaseColor);
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
                // if its black change it to red
                if (LilyScript.lBaseColor == ColorScript.black)
                {
                    //color1 = ColorScript.black;
                    newColor = ColorScript.red;

                    ColorScript.changeColor(LilyScript.lily, newColor);
                    LilyScript.lBaseColor = newColor;

                    //ColorScript.lily.material.color = Color.red;
                    Debug.Log("its now red");


                    // play animation

                }
                // if its red change it to green
                else if (LilyScript.lBaseColor == ColorScript.red)
                {
                    //color1 = ColorScript.red;
                    color2 = ColorScript.green;

                    ColorScript.changeColor(LilyScript.lily, color2);
                    LilyScript.lBaseColor = color2;
                    Debug.Log("its now green");
                    //LilyScript.lily.material.color = Color.green;


                    // change the turtle to red
                    ColorScript.changeColor(TurtleScript.turtle, ColorScript.red);
                    TurtleScript.tBaseColor = ColorScript.red;

                }

                // if its green change it to blue
                else if (LilyScript.lBaseColor == ColorScript.green)
                {
                    //color1 = ColorScript.green;

                    ColorScript.changeColor(LilyScript.lily, ColorScript.blue);
                    LilyScript.lBaseColor = ColorScript.blue;
                    //LilyScript.lily.material.color = Color.blue;
                    Debug.Log("its now blue");

                    // change the turtle to red
                    ColorScript.changeColor(TurtleScript.turtle, ColorScript.yellow);
                    TurtleScript.tBaseColor = ColorScript.yellow;

                }

                // if its blue change it to red
                else if (LilyScript.lBaseColor == ColorScript.blue)
                {
                    //color1 = ColorScript.blue;
                    color2 = ColorScript.red;
                    ColorScript.changeColor(LilyScript.lily, ColorScript.red);
                    LilyScript.lBaseColor = color2;
                    //LilyScript.lily.material.color = Color.red;
                    Debug.Log("its now red");

                    // change the turtle to blue
                    ColorScript.changeColor(TurtleScript.turtle, ColorScript.blue);
                    TurtleScript.tBaseColor = ColorScript.blue;

                }

                // if its yellow change it to red
                else if (LilyScript.lBaseColor == ColorScript.yellow)
                {
                    //color1 = ColorScript.blue;
                    color2 = ColorScript.red;
                    ColorScript.changeColor(LilyScript.lily, ColorScript.red);
                    LilyScript.lBaseColor = color2;

                    // change the turtle to blue
                    ColorScript.changeColor(TurtleScript.turtle, ColorScript.blue);
                    TurtleScript.tBaseColor = ColorScript.blue;

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
