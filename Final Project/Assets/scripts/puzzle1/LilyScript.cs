using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyScript : MonoBehaviour
{
    public static Color lBaseColor; //= Color.black;
    public static Color lEndColor; //= Color.green;
    [SerializeField]
    public static float duration = 3f;

    public static Renderer lily;
    public Material matofobject;

    // Start is called before the first frame update
    void Start()
    {
        /*
        // start this object off as black
        lily = GetComponent<Renderer>();
    
        lBaseColor = ColorScript.black;
        //lily.material.color = lBaseColor;
        lily.material.SetColor("temp", lBaseColor);
        */
        matofobject.color = ColorScript.black;
        matofobject.color = lBaseColor;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
    
