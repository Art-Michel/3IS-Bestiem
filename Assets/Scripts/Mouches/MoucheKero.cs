using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MoucheKero : Ennemis
{
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public override void Death()
    {
        //Transforme Frog en Kero
        PlayerSpriteManager.Instance.SetCurrentSprites(PlayerSpriteManager.Instance.KeroSprites);
        base.Death();
    }
}
