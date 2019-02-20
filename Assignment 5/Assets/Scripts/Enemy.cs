using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    public Transform player;
    public float playerDistance;
    public float rotationDamping = 2f;
    public float moveSpeed = 5f;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(player.position, transform.position);
        if (playerDistance < 15f)
        {
            lookAtPlayer();
        }
        if (playerDistance < 12f)
        {
            //anim.SetInteger("condition", 1);
            if (playerDistance > 2f)
            {
                chase();

            }
            else if (playerDistance < 2f)
            {
                attack();
                anim.SetInteger("condition", 1);

            }
        }
        //anim.SetInteger("condition", 0);
    }

    void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);

    }

    void chase()
    {
        anim.SetInteger("condition", 1);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void attack()
    {
        anim.SetInteger("condition", 2);
        /*
        RaycastHit hit;
        if(Physics.Raycast ( transform.position, transform.forward, out hit ))
        {
            if(hit.collider.gameObject.tag == "Player")
            {
               // anim.SetInteger("condition", 2);
            }
        }*/
    }
}
