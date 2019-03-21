using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle2 : MonoBehaviour
{
    public static bool puzz2Solved;
    public Text winText;
    public Text helpText;

    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
        helpText.text = "Use WASD to move \nE to Interact \nSpace to Jump ";
    }

    // Update is called once per frame
    void Update()
    {
        if( puzz2Solved == true)
        {
            winText.text = "You Successfully Restored the Color Here!";
        }
    }
}
