using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public Controlls RunSpeed;
    public GameObject FinishCavnas;
    public GameObject Particles;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                RunSpeed.Run = false;
                RunSpeed.Idle = true;

                Particles.SetActive(true);
                StartCoroutine(PopingUI());

            }
    }

    IEnumerator PopingUI()
    {
        yield return new WaitForSeconds(3);
        FinishCavnas.SetActive(true);
    }
}
