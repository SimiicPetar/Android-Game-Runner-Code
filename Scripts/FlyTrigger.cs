using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyTrigger : MonoBehaviour
{
    public Controlls RunSpeed;
    public Controlls FlySpeed;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                FlySpeed.Fly = true;
                RunSpeed.Run = false;
            }
    }
void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                FlySpeed.Fly = false;
                RunSpeed.Run = true;
            }
    }
}
