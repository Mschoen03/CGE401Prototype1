using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Matt Schoen
 * Assignment 2
 * Got repalced so score happens once
 */
public class PlayerEnterTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }

}
