using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    //public static Color baseColor; //= Color.black;
    public static Color black, gray, darkGray, red, green, yellow, blue, newColor;
    [SerializeField]
    public static float duration = 3f;

    // Start is called before the first frame update
    void Start()
    {
        black = new Color(0f, 0f, 0f, 0.7f);
        gray = new Color(0f, 0f, 0f, 0.3f);
        darkGray = new Color(0f, 0f, 0f, 0.5f);
        red = new Color(1, 0, 0, 0.7f);
        green = new Color(0f, 1f, 0f, 1f);
        yellow = new Color(1f, 0.92f, 0.016f, 1f);
        blue = new Color(0, 0, 1, 1);
    }


    public static void changeColor(Renderer thing, Color color1, Color color2)
    {
        //float lerp = Mathf.PingPong(Time.time, duration) / duration;
        /// endColor = Color.Lerp(color1, color2, lerp);
        newColor = color2;
        thing.material.color = newColor;
        Debug.Log("colorend: " + newColor);
    }


    // Update is called once per frame
    void Update()
    {
        //lily.material.color = color;

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("color: " + newColor);
        }
    }
}

