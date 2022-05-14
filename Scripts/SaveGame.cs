using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
public float  level;

public GameObject Level1;
public GameObject Level2;
public GameObject Level3;
public GameObject Level4;
public GameObject Level5;

    public void NextLevel()
    {
        level += 1;
    }

public void FirstLevel()
    {
        level = 1;
    }
    public void Start() 
    {
        level = PlayerPrefs.GetFloat("currentLVL" ,1);

                
        if (level == 1)
            {
                Level1.SetActive(true);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);

            }
        
        if (level == 2)
            {
                Level2.SetActive(true);
                Level1.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
            }
        
        if (level == 3)
            {
                Level3.SetActive(true);
                Level2.SetActive(false);
                Level1.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
            }
        
        if (level == 4)
            {
                Level4.SetActive(true);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level1.SetActive(false);
                Level5.SetActive(false);
            }
        
        if (level == 5)
            {
                Level5.SetActive(true);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level1.SetActive(false);
            }
    }

    public void SaveLevel1()
    {
        PlayerPrefs.SetFloat("currentLVL",level);
    }

}
