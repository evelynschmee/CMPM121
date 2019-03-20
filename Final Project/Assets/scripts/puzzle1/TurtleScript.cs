using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleScript : MonoBehaviour
{
    public static Color tBaseColor; //= Color.black;
    public static Color tEndColor; //= Color.green;
    [SerializeField]
    public static float duration = 3f;
    public Material matofobject;
    

    public static Renderer turtle;

    // Start is called before the first frame update
    void Start()
    {
        /*
        // start this object off as black
        turtle = GetComponent<Renderer>();

        tBaseColor = ColorScript.gray;
        turtle.material.color = tBaseColor;

        Mesh mesh = GetComponent<MeshFilter>().sharedMesh;
        */
        matofobject.color = ColorScript.gray;
        matofobject.color = tBaseColor;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.T))
        {
           tBaseColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            //turtle.material.SetColor("_Color", tBaseColor);
            matofobject.color = tBaseColor;
            Debug.Log("color:" + matofobject.color);
        }

    }
}

