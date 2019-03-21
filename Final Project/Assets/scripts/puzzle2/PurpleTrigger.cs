﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleTrigger : MonoBehaviour
{
    Color newColor;
    bool onTrigger = false;


    void Update()
    {
        if (onTrigger == true)
        {
            // is circle contacting trigger; player presses E, and they have paint
            if (Input.GetKey(KeyCode.E) && Palette.paintCount >= 1)
            {
                // checks if the player is trying to apply RED
                if (AreaDetection.circleColor == 0)
                {
                    // if the flower is blue
                    if (PurpleFlower.purpBaseColor == ColorScript.blue)
                    {
                        // its now purple
                        newColor = ColorScript.purple;
                        PurpleFlower.purpBaseColor = newColor;
                    }
                }
                // the circle is blue
                else if (AreaDetection.circleColor == 1)
                {
                    // super bluE!!
                }
            }
        }
    }


    void OnTriggerEnter(Collider other)
    {
        // circle contacts the trigger
        if (other.gameObject.tag == "Circle")
        {
            // set ontrigger to true since the circle is touching the plate
            onTrigger = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        // when the player exits the trigger allow the color to change
        onTrigger = false;
    }
}

