using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public Controlls RunSpeed;
    public Controlls FlySpeed;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                FlySpeed.Wall = true;
                RunSpeed.Run = false;
            }
    }
void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                FlySpeed.Wall = false;
                RunSpeed.Run = true;
            }
    }
}
