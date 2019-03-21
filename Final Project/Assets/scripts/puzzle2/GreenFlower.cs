using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenFlower : MonoBehaviour
{
    public static Color gBaseColor;
    public static Color gEndColor;
    public Material gMaterial;

    // Start is called before the first frame update
    void Start()
    {
        // start this object off as yellow
        gBaseColor = ColorScript.yellow;
        gMaterial.color = gBaseColor;
    }

    // Update is called once per frame
    void Update()
    {
        gMaterial.color = gBaseColor;
    }
}
