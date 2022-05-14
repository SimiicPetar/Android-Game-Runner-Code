using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHealth : MonoBehaviour
{

public int health;
public GameObject Wall;
public GameObject WallTrigger;
public GameObject WallRigidbody;
void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Damage"))
            {
                health -= 1;
            }
    }
void Update()
{
  if (health <= 0)
        {
            Wall.SetActive(false);
            WallTrigger.transform.position = new Vector3(0, 0, 0);
            WallRigidbody.SetActive(true);
        }  
    }
}
