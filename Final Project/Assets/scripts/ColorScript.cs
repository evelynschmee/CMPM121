using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    //public static Color baseColor; //= Color.black;
    public static Color black, gray, darkGray, red, green, yellow, blue, newColor;
    public static Color purple, orange;
    [SerializeField]
    public static float duration = 3f;

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

        purple = new Color(1, 0, 1, 0.7f);
        orange = new Color(1.0f, 0.64f, 0.0f);
    }


    public static void changeColor(Renderer thing, Color color)
    {
        //float lerp = Mathf.PingPong(Time.time, duration) / duration;
        /// endColor = Color.Lerp(color1, color2, lerp);
        newColor = color;
        thing.material.color = newColor;
    }


    // Update is called once per frame
    void Update()
    {

    }
}

