using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;

    public Transform target;


    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > stoppingDistance)

        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (transform.position.z > 3)
            transform.position = new Vector3(transform.position.x , transform.position.y, 3);
        if (transform.position.z < 1.5f)
            transform.position = new Vector3(transform.position.x , transform.position.y, 1.5f);

        }
    }

}