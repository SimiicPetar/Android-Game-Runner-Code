using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHit : MonoBehaviour
{
public GameObject ObstacleModel;
public GameObject Particles;
public Controlls SpeedChange;
public float sec;
public Collider col;
public Collider colControlls;

IEnumerator LateCall()
    {
        yield return new WaitForSeconds(sec);
        SpeedChange.Run = true;
        colControlls.enabled = enabled;
        SpeedChange.HitObstacle = false;

    }

void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
                ObstacleModel.SetActive(false);
                Particles.SetActive(true);
                
                col.enabled = !col.enabled;
                colControlls.enabled = !colControlls.enabled;
                SpeedChange.Run = false;
                StartCoroutine(LateCall());
                SpeedChange.HitObstacle = true;


            }
    }
}