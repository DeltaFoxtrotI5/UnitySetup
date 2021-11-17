﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetStats : MonoBehaviour
{
    public int health;
    public int xp;
    public GameObject theShip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            transform.localScale *= 0.8f;
            health--;
            theShip.GetComponent<ShipMovement>().xp += xp;
            xp++;
            Destroy(collision.gameObject);
            if(health < 1)
            {
                Destroy(this.gameObject);

            }
        }


    }


}
