using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palette : MonoBehaviour
{
    // refilling out of 3
    public static int paintRefill;
    // counts how many times player uses space
    public static int paintCount;
    // is it y or b
    public static int circleColor;
    public Renderer palette;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // the player is still trying to solve the puzzle
        if (Puzzle2.puzz2Solved == false) {

            //  refill the paint / player failed paint it red to indicate it refilled
            if (paintRefill == 0 || paintRefill == 3 )
            {
                palette.material.color = ColorScript.red;
            } 
            // the player is actively using their 3 paint tries
            else if( paintRefill != 0 || paintRefill != 3)
            {
                palette.material.color = Color.white;
            }
        }
        // the player solved the puzzle, keep it white
        else
        {
            palette.material.color = Color.white;
        }
        // press space to use paint : lose a paint
        if (Input.GetKeyDown(KeyCode.Space)){
            paintCount -= 1;
        }
    }

    // changes all flowers to white when no paint is left ( player fails 3 tries)
    static void allGray()
    {
        Flower1.f1BaseColor = Color.gray;
        Flower2.f2BaseColor = Color.gray;
        Flower3.f3BaseColor = Color.gray;
        Flower4.f4BaseColor = Color.gray;
    }
}
