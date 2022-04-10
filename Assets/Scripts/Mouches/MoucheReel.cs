using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class MoucheReel : Ennemis
{
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    protected override void Death()
    {
        //change to photorealistic visual
        TilesManager.Instance.ChangeTileSet(realTiles);
        base.Death();
    }
}
