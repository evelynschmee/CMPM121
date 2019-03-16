using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyTrigger : MonoBehaviour
{
    Color color1, color2;
    bool onTrigger = false;

    void Start()
    {

    }

    void Update()
    {
        // checks if Lily is Red, Turtle is Green, Flower is Yellow
        if (LilyScript.lily.material.color == ColorScript.red &&
        TurtleScript.turtle.material.color == ColorScript.green) //&&
            //FlowerScript.flower.material.color == ColorScript.yellow)
        {

        }
    }

    void OnTriggerEnter(Collider other)
    {
        // player contacts the trigger
        if (other.gameObject.CompareTag("Player"))
        {
            // set ontrigger to true since the player is touching the plate
            onTrigger = true;
            Debug.Log("touch");
            // if the player is contacting with the trigger; set the trigger to true
            if (onTrigger != false)
            {
                // if its black change it to red
                if (LilyScript.lilyBaseColor == ColorScript.black)
                {
                    color1 = ColorScript.black;
                    color2 = ColorScript.red;

                    ColorScript.changeColor(LilyScript.lily, color1, color2);
                    //ColorScript.lily.material.color = Color.red;
                    Debug.Log("its now red");
                    // play animation
                }



                // if its red change it to green
                if (LilyScript.lilyBaseColor == ColorScript.red)
                {
                    color1 = ColorScript.red;
                    color2 = ColorScript.green;

                    ColorScript.changeColor(LilyScript.lily, color1, color2);
                    Debug.Log("its now green");
                    //LilyScript.lily.material.color = Color.green;
                }
                /*
                // if its green change it to blue
                if (LilyScript.endColor == LilyScript.green)
                {
                    //LilyScript.changeColor(LilyScript., LilyScript.red);
                    LilyScript.lily.material.color = Color.blue;
                    Debug.Log("its now blue");
                }

                // if its blue change it to red
                if (LilyScript.endColor == LilyScript.blue)
                {
                    LilyScript.lily.material.color = Color.red;
                    Debug.Log("its now red");
                }
                */

                //colorEnd = pink;
                //Debug.Log("after change color");
            }
        }

    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        // when the player exits the trigger allow the color to change
        onTrigger = false;
        //LilyScript.color = endColor;
    }
}
