using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower4 : MonoBehaviour
{
    public static Color f4BaseColor; //= Color.black;
    public static Color f4EndColor; //= Color.green;

    public static Renderer flower4;

    // Start is called before the first frame update
    void Start()
    {
        // start this object off as black
        flower4 = GetComponent<Renderer>();

        f4BaseColor = ColorScript.gray;
        flower4.material.color = f4BaseColor;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
