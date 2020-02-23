using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Actions : MonoBehaviour
{
    public static int maxHp = 3;
    public int hpLeft = maxHp;
    public Collider collider;
    public bool living = true;
    public PlayerMovement playMove;
 
    public void TakeDmg(int dmgTaken)
	{
        hpLeft -= dmgTaken;
        if (hpLeft < 0) 
        { 
            hpLeft = 0; 
        }
        collider.material.dynamicFriction = collider.material.dynamicFriction - 0.2f;
        playMove.rotSpeed -= (10 * dmgTaken);
        playMove.force -= 2;
	}
    public void die() 
    {
        living = false;
    }
    
}