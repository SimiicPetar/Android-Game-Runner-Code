using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbUpTrigger : MonoBehaviour
{
    public Controlls RunSpeed;
    public Controlls ClimbingUp;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                ClimbingUp.ClimbUP = true;
                RunSpeed.Climb = false;
            }
    }
void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                ClimbingUp.ClimbUP = false;
                RunSpeed.Climb = true;
            }
    }
}
