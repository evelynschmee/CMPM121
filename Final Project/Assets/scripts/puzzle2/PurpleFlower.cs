using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleFlower : MonoBehaviour
{
    public static Color purpBaseColor;
    public static Color purpEndColor;
    public Material purpMaterial;

    // Start is called before the first frame update
    void Start()
    {
        // start this object off as blue
        purpBaseColor = ColorScript.blue;
        purpMaterial.color = purpBaseColor;
    }

    // Update is called once per frame
    void Update()
    {
        purpMaterial.color = purpBaseColor;
    }
}
