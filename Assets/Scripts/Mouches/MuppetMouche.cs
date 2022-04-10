using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MuppetMouche : Ennemis
{
    new private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    protected override void Death()
    {
        //Transforme Frog en Kermit
        //PlayerSpriteManager.Instance.SetCurrentSprites(PlayerSpriteManager.Instance.KermitSprites);
        base.Death();
    }
}
