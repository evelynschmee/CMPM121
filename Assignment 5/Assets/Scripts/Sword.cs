using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject sword;
    public GameObject player;
    private bool hasSword = false;

    // Update is called once per frame
    void Update()
    {
        if (hasSword == true)
        {
            transform.position = player.transform.position;
            transform.rotation = player.transform.rotation;
        }
        else
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    }

    private void OnTriggerEnter( Collider other )
    { 
        if (other.tag == "Player")
        {
            hasSword = true;
        }
    }
}
