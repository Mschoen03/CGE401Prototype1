using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Matt Schoen
 * Assignment 2
 * if player is lower than -1 gameOver is triggered
 */
public class LoseOnFall : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;//1:04:45
        }

    }
}
