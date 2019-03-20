using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerScript : MonoBehaviour
{
    public static Color fBaseColor; //= Color.black;
    public static Color fEndColor; //= Color.green;
    [SerializeField]
    public static float duration = 3f;
    public Material fMaterial;

    //public static Renderer flower;

    // Start is called before the first frame update
    void Start()
    {
        // start this object off as black
        //flower = GetComponent<Renderer>();
    
        fBaseColor = ColorScript.darkGray;
        fMaterial.color = fBaseColor;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
    
