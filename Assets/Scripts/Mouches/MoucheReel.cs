using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoucheReel : Ennemis
{
    protected override void Death()
    {
        //change to photorealistic visual
        TilesManager.Instance.ChangeTileSet(realTiles);
        base.Death();
    }
}
