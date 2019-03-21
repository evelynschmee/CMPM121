using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerScript : MonoBehaviour
{
    public static Color fBaseColor;
    public static Color fEndColor;
    public Material fMaterial;

    // Start is called before the first frame update
    void Start()
    {
        // give the starter color and assign it to the basecolor
        fBaseColor = ColorScript.darkGray;
        fMaterial.color = fBaseColor;
    }

    // Update is called once per frame
    void Update()
    {
        // will always update the new base color
        fMaterial.color = fBaseColor;
    }
}
    
