using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower2 : MonoBehaviour
{
    public static Color f2BaseColor; //= Color.black;
    public static Color f2EndColor; //= Color.green;

    public static Renderer flower2;

    // Start is called before the first frame update
    void Start()
    {
        // start this object off as black
        flower2 = GetComponent<Renderer>();

        f2BaseColor = ColorScript.gray;
        flower2.material.color = f2BaseColor;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
