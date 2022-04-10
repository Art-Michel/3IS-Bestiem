using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MuppetMouche : Ennemis
{
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public override void Death()
    {
        //Transforme Frog en Kermit
        //PlayerSpriteManager.Instance.SetCurrentSprites(PlayerSpriteManager.Instance.KermitSprites);
        base.Death();
    }
}
