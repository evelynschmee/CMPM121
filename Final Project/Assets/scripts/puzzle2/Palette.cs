using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Palette : MonoBehaviour
{
    // counts how many times player uses space
    public static int paintCount;
    public Renderer palette;
    public static bool showPaint;
    public Text paintText;
    public Text help2Text;


    // Update is called once per frame
    void Update()
    {
        if( showPaint == true)
        {
            paintText.text = "Paint: " + paintCount.ToString() + "/3";
            help2Text.text = "Step on the Palette Square to refill your paint";
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(LBFlower.lbBaseColor);
            Debug.Log(OrangeFlower.oBaseColor);
            Debug.Log(PurpleFlower.purpBaseColor);
            Debug.Log(PinkFlower.pinkBaseColor);
            Debug.Log(GreenFlower.gBaseColor);
            Debug.Log(Puzzle2.puzz2Solved);

        }
        if (LBFlower.lbBaseColor == ColorScript.lightBlue &&
OrangeFlower.oBaseColor == ColorScript.orange &&
PurpleFlower.purpBaseColor == ColorScript.purple &&
PinkFlower.pinkBaseColor == ColorScript.pink &&
GreenFlower.gBaseColor == ColorScript.nGreen)
        {
            Puzzle2.puzz2Solved = true;
        }

        // the player is still trying to solve the puzzle
        if (Puzzle2.puzz2Solved == false) {

            // change color to red 'refilled' if the player has no paint
            if (paintCount <= 0)
            {
                palette.material.color = ColorScript.red;
                // the circle is not on the player
                AreaDetection.startCircle = false;
            } 
            // the player is actively using their 3 paint tries
            else
            {
                palette.material.color = ColorScript.white;
            }
        }
        // the player solved the puzzle, keep it white
        else
        {
            palette.material.color = Color.white;
        }
        // press E to use paint : lose a paint
        if (Input.GetKeyDown(KeyCode.E)){
            paintCount -= 1;
            // if the player used it twice the circle is now blue
            if ( paintCount == 1 )
            {
                AreaDetection.circleColor = 1;
            }
        }

    }

    // changes all flowers to darkGray when no paint is left ( player fails 3 tries)
    public static void alldarkGray()
    {
        LBFlower.lbBaseColor = ColorScript.darkGray;
        OrangeFlower.oBaseColor = ColorScript.darkGray;
        PurpleFlower.purpBaseColor = ColorScript.darkGray;
        PinkFlower.pinkBaseColor = ColorScript.darkGray;
        GreenFlower.gBaseColor = ColorScript.darkGray;
    }
}
