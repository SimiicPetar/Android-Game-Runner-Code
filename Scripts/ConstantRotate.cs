using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotate : MonoBehaviour
{
    public float rotatespeed;
    void Update()
    {
        transform.Rotate(0, rotatespeed, 0 * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
