using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;

    // Start is called before the first frame update
    void Start()
    {

        camera2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // player collides with trigger plate that changes cam and locks door
        if (other.gameObject.CompareTag("Player"))
        {
            camera2.SetActive(true);
            camera1.SetActive(false);
        }
    }

}
