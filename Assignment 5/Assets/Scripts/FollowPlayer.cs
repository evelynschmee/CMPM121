using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, 9, 33);

    }

    // https://gamedev.stackexchange.com/questions/110504/make-camera-follow-object-only-on-y-axis
}
