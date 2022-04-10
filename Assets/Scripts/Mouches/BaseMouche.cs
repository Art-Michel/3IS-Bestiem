using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class BaseMouche : Ennemis
{
    public GameObject baseTiles;
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
        baseTiles = TilesManager.Instance.tileSets[0];
    }
    public override void Death()
    {
        //change to GB visual
        TilesManager.Instance.ChangeTileSet(baseTiles);
        base.Death();
    }
}
