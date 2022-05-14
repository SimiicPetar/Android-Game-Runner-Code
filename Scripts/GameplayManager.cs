using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public Animator CameraAnim;
    public Animator StartingAnim;
    public void StartLevel()
    {
        CameraAnim.Play("CameraAnimations");
        StartingAnim.Play("StartingGameAnimation");

    }
}
