using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHitAi : MonoBehaviour
{
public GameObject ObstacleTriggerPlayer;
public GameObject ObstacleModel;
public GameObject Particles;

void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ai"))
            {
             ObstacleModel.SetActive(false);
             Particles.SetActive(true);
             ObstacleTriggerPlayer.SetActive(false);

            }
    }
}