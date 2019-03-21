using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeFlower : MonoBehaviour
{
    public static Color oBaseColor;
    public static Color oEndColor;
    public Material oMaterial;

    // Start is called before the first frame update
    void Start()
    {
        // start this object off as yellow
        oBaseColor = ColorScript.yellow;
        oMaterial.color = oBaseColor;
    }

    // Update is called once per frame
    void Update()
    {
        oMaterial.color = oBaseColor;
    }
}
