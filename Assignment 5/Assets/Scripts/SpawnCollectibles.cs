using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectibles : MonoBehaviour
{
    public GameObject pickupEffect;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "Player")
        {
            Instantiate(pickupEffect, transform.position,transform.rotation);
            Destroy(gameObject);
        }
    }
}

/*Sources:
 * https://www.youtube.com/watch?v=nMQFo3E_7pU
*/