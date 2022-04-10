using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class MoucheReel : Ennemis
{
    public GameObject realTiles;
    public GameObject deathVFX;

    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
        realTiles = TilesManager.Instance.tileSets[2];
    }
    public override void Death()
    {
        //change to photorealistic visual
        Instantiate(deathVFX, transform.position, Quaternion.identity);
        TilesManager.Instance.ChangeTileSet(realTiles);
        base.Death();
    }
}
