using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MoucheHelico : Ennemis
{
    new private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    protected override void Death()
    {
        //Fait tourner Frog autour de la mouche
        base.Death();
    }
}
