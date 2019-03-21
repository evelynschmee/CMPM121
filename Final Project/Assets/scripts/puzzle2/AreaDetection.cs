using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDetection : MonoBehaviour
{
    public GameObject player;
    private Vector3 tempCoor, under;
    public Renderer circle;
    // is it y or b
    public static int circleColor;

    public static bool startCircle;
    float xCoor, yCoor, zCoor;

    // Start is called before the first frame update
    void Start()
    {
        circle = GetComponent<Renderer>();

        // the circle is not following the player
        startCircle = false;
    }

    // Update is called once per frame
    void Update()
    {
        // copy and follow the players center coordinates
        if (startCircle == true)
        {
            tempCoor = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            transform.position = tempCoor;
            gameObject.SetActive(true);
        }
        // if startcircle is false make the circle deactivate it
        else
        {
            //gameObject.SetActive(false);
            under = new Vector3(player.transform.position.x,-100, player.transform.position.z);
            transform.position = under;
        }

        // checks if it is red, otherwise its now blue
        if ( circleColor == 0)
        {
            circle.material.color = Color.red;
        }
        else
        {
            circle.material.color = Color.blue;
        }
    }
}
