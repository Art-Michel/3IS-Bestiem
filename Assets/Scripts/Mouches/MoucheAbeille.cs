using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MoucheAbeille : Ennemis
{
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public override void Death()
    {
        //Transforme Frog en abeille
        PlayerSpriteManager.Instance.SetCurrentSprites(PlayerSpriteManager.Instance.AbeilleSprites);
        base.Death();
    }
}
