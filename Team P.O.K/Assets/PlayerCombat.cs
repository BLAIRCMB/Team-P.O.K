﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{    
    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
    {
        //play an attack animation
        // Detect enemies in range of the attack
        //hurt them
    }
}
