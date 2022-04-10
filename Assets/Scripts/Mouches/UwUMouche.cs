using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class UwUMouche : Ennemis
{
    public GameObject uwuTiles;
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
        uwuTiles = TilesManager.Instance.tileSets[3];
    }
    public override void Death()
    {
        //Passe le monde en mode UwU
        TilesManager.Instance.ChangeTileSet(uwuTiles);
        base.Death();
    }
}
