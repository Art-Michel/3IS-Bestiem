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
        PlayerFormsManager.Instance.SetCurrentSprites(PlayerFormsManager.Instance.KermitSprites);
        Instantiate(deathVFX, transform.position, Quaternion.identity);
        base.Death();
    }
}
