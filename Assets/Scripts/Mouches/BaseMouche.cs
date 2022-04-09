using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMouche : Ennemis
{
    protected override void Death()
    {
        //change to GB visual
        TilesManager.Instance.ChangeTileSet(baseTiles);
        base.Death();
    }
}
