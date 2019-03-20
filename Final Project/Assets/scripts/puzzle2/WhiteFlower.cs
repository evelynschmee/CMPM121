using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower1 : MonoBehaviour
{
    public static Color f1BaseColor; //= Color.black;
    public static Color f1EndColor; //= Color.green;

    public static Renderer flower1;

    // Start is called before the first frame update
    void Start()
    {
        // start this object off as black
        flower1 = GetComponent<Renderer>();

        f1BaseColor = ColorScript.gray;
        flower1.material.color = f1BaseColor;

    }

    // Update is called once per frame
    void Update()
    {

    }
}

