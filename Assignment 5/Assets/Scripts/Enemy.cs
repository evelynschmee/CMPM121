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

    private Animator animEnemy;

    // Start is called before the first frame update
    void Start()
    {
        animEnemy = GetComponent<Animator>();
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
            if (playerDistance > 2f)
            {
                chase();

            }
            else if (playerDistance < 2f)
            {
                attack();

                if (Input.GetKeyUp(KeyCode.Space))
                {
                   animEnemy.SetInteger("condition", 3);
                    Destroy(gameObject);
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