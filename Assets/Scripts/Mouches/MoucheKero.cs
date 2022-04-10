using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MoucheKero : Ennemis
{
    public GameObject deathVFX;
    
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public override void Death()
    {
        //Transforme Frog en Kero
        Instantiate(deathVFX, transform.position, Quaternion.identity);
        PlayerSpriteManager.Instance.SetCurrentSprites(PlayerSpriteManager.Instance.KeroSprites);
        base.Death();
    }
}
