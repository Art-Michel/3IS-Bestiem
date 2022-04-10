using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MoucheGB : Ennemis
{    
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    protected override void Death()
    {
        //change to GB visual
        TilesManager.Instance.ChangeTileSet(gbTiles);
        base.Death();
    }
}
