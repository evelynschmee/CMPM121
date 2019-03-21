using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2Script : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        // make the camera follow the players Z axis
        var cam  = target.transform.position.z;
        transform.position = new Vector3(290, 22, cam);
    }

}
