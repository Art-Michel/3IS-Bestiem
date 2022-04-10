using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class MoucheReel : Ennemis
{
    public GameObject realTiles;
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
        realTiles = TilesManager.Instance.tileSets[2];
    }
    protected override void Death()
    {
        //change to photorealistic visual
        TilesManager.Instance.ChangeTileSet(realTiles);
        base.Death();
    }
}
