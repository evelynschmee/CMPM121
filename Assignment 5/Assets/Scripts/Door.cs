using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private static bool haveKey;
    public GameObject door;

    // Update is called once per frame
    void Update()
    {
        haveKey = Key.playerHasKey;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("helllo?");
        Debug.Log("Key:" + haveKey);
        if ( (other.tag == "Player") && (haveKey == true) )
        {
            door.transform.position += new Vector3(0, 6, 0);
        }
    }
}
