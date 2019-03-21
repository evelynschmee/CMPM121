using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleScript : MonoBehaviour
{
    public static Color tBaseColor;
    public static Color tEndColor;
    public Material matofobject;

    // Start is called before the first frame update
    void Start()
    {
        // give the starter color and assign it to the basecolor
        tBaseColor = ColorScript.gray;
        matofobject.color = tBaseColor;
    }

    // Update is called once per frame
    void Update()
    {
        // will always update the new base color
        matofobject.color = tBaseColor;
    }
}

