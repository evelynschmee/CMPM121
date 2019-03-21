using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkFlower : MonoBehaviour
{
    public static Color pinkBaseColor;
    public static Color lbEndColor;
    public Material pinkMaterial;

    // Start is called before the first frame update
    void Start()
    {
        // start this object off as white
        pinkBaseColor = ColorScript.white;
        pinkMaterial.color = pinkBaseColor;
    }

    // Update is called once per frame
    void Update()
    {
        pinkMaterial.color = pinkBaseColor;
    }
}
