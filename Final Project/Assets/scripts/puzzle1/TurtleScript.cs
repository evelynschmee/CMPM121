using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleScript : MonoBehaviour
{
    public static Color tBaseColor; //= Color.black;
    public static Color tEndColor; //= Color.green;
    [SerializeField]
    public static float duration = 3f;

    public static Renderer turtle;

    // Start is called before the first frame update
    void Start()
    {
        // start this object off as black
        turtle = GetComponent<Renderer>();

        tBaseColor = ColorScript.gray;
        turtle.material.color = tBaseColor;

    }

    // Update is called once per frame
    void Update()
    {

    }
}

