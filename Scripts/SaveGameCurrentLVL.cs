using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameCurrentLVL : MonoBehaviour
{  

    public SaveGame curLVL;
float elapsedTime;
float timeLimit = 1.0f;

  void Update() 
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= timeLimit)
            {
                {
                        elapsedTime = 0;
                        PlayerPrefs.SetFloat("currentLVL", curLVL.level);
                        Debug.Log("asd");
            }

        }
    }
}
