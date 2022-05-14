using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public Controlls RuningSpeed;
    public Animator anims;
    public GameObject Model;
    public GameObject Particles;

void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                RuningSpeed.r_Speed += 3;
                StartCoroutine(speedreturn());
                Model.SetActive(false);
                anims.speed = 2.5f;    
                Particles.SetActive(true);

            }

    }

    IEnumerator speedreturn()
    {
        yield return new WaitForSeconds(2);
        RuningSpeed.r_Speed -= 3;
        anims.speed = 1;    
        Particles.SetActive(false);

    }
}
