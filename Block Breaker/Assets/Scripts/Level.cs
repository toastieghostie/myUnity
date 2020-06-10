﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    [SerializeField] int breakableBlocks;  //serialized for debug purposes
    
    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
}
