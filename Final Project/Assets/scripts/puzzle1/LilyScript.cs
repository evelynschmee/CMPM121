using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyScript : MonoBehaviour
{
    public static Color lBaseColor;
    public static Color lEndColor;
    public Material matofobject;

    // Start is called before the first frame update
    void Start()
    {
        // give the starter color and assign it to the basecolor
        lBaseColor = ColorScript.black;
        matofobject.color = lBaseColor;
    }

    // Update is called once per frame
    void Update()
    {
        // will always update the new base color
        matofobject.color = lBaseColor;
    }
}
    
