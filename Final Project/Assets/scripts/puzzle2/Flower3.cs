using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower3 : MonoBehaviour
{
    public static Color f3BaseColor; //= Color.black;
    public static Color f3EndColor; //= Color.green;

    public static Renderer flower3;

    // Start is called before the first frame update
    void Start()
    {
        // start this object off as black
        flower3 = GetComponent<Renderer>();

        f3BaseColor = ColorScript.gray;
        flower3.material.color = f3BaseColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
