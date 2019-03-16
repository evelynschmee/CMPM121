using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleTrigger : MonoBehaviour
{
    Color color1, color2;
    bool onTrigger = false;

    void Start()
    {
    
    }
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            // set ontrigger to true since the player is touching the plate
            onTrigger = true;
            Debug.Log("turtle");
            if (onTrigger != false)
            {
                // if its gray change it to blue
                if (TurtleScript.tBaseColor == ColorScript.gray)
                {
                    color1 = ColorScript.gray;
                    color2 = ColorScript.green;

                    ColorScript.changeColor( TurtleScript.turtle, color1, color2);
                    //PuzzleLily.lily.material.color = Color.red;
                    Debug.Log(" 2 its now green");
                }

                /*

                // if its red change it to green
                if (PuzzleLily.color == PuzzleLily.red)
                {
                    startColor = PuzzleLily.red;
                    endColor = PuzzleLily.green;

                    PuzzleLily.changeColor(startColor, endColor);
                    Debug.Log("its now green");
                    //PuzzleLily.lily.material.color = Color.green;
                }
                /*
                // if its green change it to blue
                if (PuzzleLily.endColor == PuzzleLily.green)
                {
                    //PuzzleLily.changeColor(PuzzleLily., PuzzleLily.red);
                    PuzzleLily.lily.material.color = Color.blue;
                    Debug.Log("its now blue");
                }

                // if its blue change it to red
                if (PuzzleLily.endColor == PuzzleLily.blue)
                {
                    PuzzleLily.lily.material.color = Color.red;
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
        //PuzzleLily.color = endColor;
    }


}
