using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public GameObject firstPersonCamera;
    public GameObject thirdPersonCamera;
    public int CameraMode;

    // Start is called before the first frame update
    void Start()
    {
        // assign camera mode 1 first, third person
        CameraMode = 1;
    }


    void Update()
    {
        // If the user presses C, for camera, the camera will switch to 1st or 3rd person
        if (Input.GetKeyDown(KeyCode.C))
        {
            // if the camera is already in 3rd
            if (CameraMode == 1)
            {
                // change it to 1st
                CameraMode = 0;
            }
            // if the camera is already in 1st
            else if (CameraMode == 0)
            {
                // change it to 3rd
                CameraMode = 1;
            }

            ChangeCamera();
        }
    }
    // enables/disables the corresponding cameras
    void ChangeCamera()
    {
        // if the cameramode is now 0 or 1st person
        if( CameraMode == 0)
        {
            // enable 1st person camera and disable the 3rd
            firstPersonCamera.SetActive(true);
            thirdPersonCamera.SetActive(false);
        }
        // if the cameramode is now 1 or 3rd person
        if (CameraMode == 1)
        {
            // enable 3rd person camera and disable the 1st
            firstPersonCamera.SetActive(false);
            thirdPersonCamera.SetActive(true);
        }
    }
}

// Credit to Jimmy Vegas's tutorial: https://www.youtube.com/watch?v=nR5P7AH4aHE
