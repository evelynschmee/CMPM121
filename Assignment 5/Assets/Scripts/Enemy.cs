﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    public Transform player;
    public float playerDistance;
    public float rotationDamping = 2f;
    public float moveSpeed = 5f;
    public GameObject user;

    private Animator animEnemy;

    Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        animEnemy = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(player.position, transform.position);
        moveDirection = (transform.position - player.transform.position).normalized;
 
            if (playerDistance < 12f)
            {
                lookAtPlayer();
            }
            if (playerDistance < 8f)
            {
                if (playerDistance > 2f)
                {
                    chase();

                }
                else if (playerDistance < 2f)
                {
                    attack();


                    if (Input.GetKeyUp(KeyCode.Space) && user.gameObject.tag == "Player")
                    {
                        transform.position += Vector3.back * 400.0f * Time.deltaTime;

                        animEnemy.SetInteger("condition", 3);

                    }
                }
            }


    }

    void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);

    }

    void chase()
    {
        animEnemy.SetInteger("condition", 1);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void attack()
    {
        animEnemy.SetInteger("condition", 2);
    }

}

/* Sources:
 * https://www.youtube.com/watch?v=188SMf9f6UY
*/