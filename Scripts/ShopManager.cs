using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{

    public Controlls playerCon;


public void JatPackBuy()
    {
        playerCon.FlySpeed += 1;
    }
    public void helmentBuy()
    {
    }
    public void swimBuy()
    {
        playerCon.SwimSpeed += 1;
    }
    public void climbBuy()
    {
        playerCon.ClimbSpeed += 1;
    }
}
