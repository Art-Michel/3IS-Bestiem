using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoucheGB : Ennemis
{    protected override void Death()
    {
        //change to GB visual
        TilesManager.Instance.ChangeTileSet(gbTiles);
        base.Death();
    }
}
