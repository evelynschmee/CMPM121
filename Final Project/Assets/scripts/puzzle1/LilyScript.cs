using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyScript : MonoBehaviour
{
    public static Color lilyBaseColor; //= Color.black;
    public static Color lilyEndColor; //= Color.green;
    [SerializeField]
    public static float duration = 3f;

    public static Renderer lily;
    // Start is called before the first frame update
    void Start()
    {
        // start this object off as black
        lily = GetComponent<Renderer>();
    
        lilyBaseColor = ColorScript.black;
        lily.material.color = lilyBaseColor;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
    
