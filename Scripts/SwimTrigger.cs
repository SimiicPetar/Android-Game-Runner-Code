using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimTrigger : MonoBehaviour
{
    public Controlls RunSpeed;
    public Controlls SwimSpeed;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                SwimSpeed.Swim = true;
                RunSpeed.Run = false;
            }
    }
void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                SwimSpeed.Swim = false;
                RunSpeed.Run = true;
            }
    }
}
