﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        
        if(otherObject.GetComponent<Trophy>())
        {
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }
        
        else if (otherObject.GetComponent<Defender>())
        { 
            GetComponent<Attacker>().Attack(otherObject); 
        }
    }
}
