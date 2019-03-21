using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LBFlower : MonoBehaviour
{
    public static Color lbBaseColor;
    public static Color lbEndColor;
    public Material lbmaterial;

    // Start is called before the first frame update
    void Start()
    {
        // start this object off as white
        lbBaseColor = ColorScript.white;
        lbmaterial.color = lbBaseColor;
    }

    // Update is called once per frame
    void Update()
    {
        lbmaterial.color = lbBaseColor;
    }
}

