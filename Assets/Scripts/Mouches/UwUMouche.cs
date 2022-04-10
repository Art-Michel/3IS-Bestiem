using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class UwUMouche : Ennemis
{
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    protected override void Death()
    {
        //Passe le monde en mode UwU
        TilesManager.Instance.ChangeTileSet(uwuTiles);
        base.Death();
    }
}
