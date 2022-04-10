using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MuppetMouche : Ennemis
{
    public GameObject deathVFX;
    
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public override void Death()
    {
        //Transforme Frog en Kermit
        //PlayerSpriteManager.Instance.SetCurrentSprites(PlayerSpriteManager.Instance.KermitSprites);
        Instantiate(deathVFX, transform.position, Quaternion.identity);
        base.Death();
    }
}
