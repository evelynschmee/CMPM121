using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    //public static Color baseColor; //= Color.black;
    public static Color black, gray, darkGray, red, green, yellow, blue, newColor;
    public static Color white, purple, orange, pink, nGreen, lightBlue ;

    // Start is called before the first frame update
    void Start()
    {
        black = new Color(0f, 0f, 0f, 0.7f);
        gray = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        darkGray = new Color(0.2f, 0.2f, 0.2f, 1f);
        red = new Color(1, 0, 0, 0.7f);
        green = new Color(0f, 1f, 0f, 1f);
        yellow = new Color(1f, 0.92f, 0.016f, 1f);
        blue = new Color(0, 0, 1, 1);

        white = new Color(1, 1, 1, 1);
        purple = new Color(.28f, .12f, .69f, 1f);
        orange = new Color(1.0f, 0.56f, 0.0f, 1f);
        pink = new Color(1, .33f, .95f, 1f);
        nGreen = new Color(0.33f, 1f, 0f, 1f); ;
        lightBlue = new Color(.59f, .86f, 1f, .99f);

    }
}

