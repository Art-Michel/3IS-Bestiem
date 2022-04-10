using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MoucheKero : Ennemis
{
    new private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    protected override void Death()
    {
        //Transforme Frog en Kero
        PlayerSpriteManager.Instance.SetCurrentSprites(PlayerSpriteManager.Instance.KeroSprites);
        base.Death();
    }
}
