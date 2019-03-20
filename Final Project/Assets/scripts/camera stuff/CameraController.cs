using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;

    //"cutscene" camera
   // public GameObject cameraCS;
    public static int CameraMode;

    // Start is called before the first frame update
    void Start()
    {
        // disable the other cameras
        camera2.SetActive(false);
        camera3.SetActive(false);
        //cameraCS.SetActive(false);

        // main camera mode
        CameraMode = 1;
        //changeCamera();
    }

    // Update is called once per frame
    void Update()
    {
        changeCamera();
    }

    void changeCamera()
    {   // disable other cams
        if (CameraMode == 1)
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
        }

        // log cam
        if (CameraMode == 2)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            camera3.SetActive(false);
        }
        // if the cameramode is now 3 or the 3rd camera room
        if (CameraMode == 3)
        {
            // enable 3rd room camera and disables all the others
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(true);
        }
        /*// cutscene cam
        if(CameraMode == 4)
        {

        }
        */       
    }

}
