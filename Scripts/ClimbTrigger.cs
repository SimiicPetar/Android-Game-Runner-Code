using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbTrigger : MonoBehaviour
{
    public Controlls RunSpeed;
    public Controlls ClimbSpeed;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                RunSpeed.Run = false;
                ClimbSpeed.Climb = true;

            }
    }
void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                RunSpeed.Run = true;
                ClimbSpeed.Climb = false;
            }
    }
}
