using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MoucheTron : Ennemis
{
    public GameObject deathVFX;

    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public override void Death()
    {
        //Laisse une trainée derrière Frog qui tue les mouches
        PlayerFormsManager.Instance.SetCurrentSprites(PlayerFormsManager.Instance.TronSprites);
        Instantiate(deathVFX, transform.position, Quaternion.identity);
        base.Death();
    }
}
