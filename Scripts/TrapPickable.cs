using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPickable : MonoBehaviour
{
    public Controlls RuningSpeed;
    public Animator anims;
    public GameObject Model;
    public GameObject Particles;

void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                RuningSpeed.r_Speed -= 4;
                StartCoroutine(speedreturn());
                Model.SetActive(false);
                anims.speed = 0.5f;    
                Particles.SetActive(true);

            }

    }

    IEnumerator speedreturn()
    {
        yield return new WaitForSeconds(2);
        RuningSpeed.r_Speed += 4;
        anims.speed = 1;    
        Particles.SetActive(false);

    }
}



