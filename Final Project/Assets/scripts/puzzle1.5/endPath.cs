using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endPath : MonoBehaviour
{
    public GameObject door2;

    private void OnTriggerExit(Collider other)
    {
        // if the player exits the trigger
        if (other.gameObject.CompareTag("Player"))
        {
            // set puzzle2's camera active, disable the path/logs camera
            CameraController.CameraMode = 3;

            // trigger the door to close so the player cant go back into level 1
            door2.transform.position += new Vector3(0, -10, 0);
        }
    }
}
