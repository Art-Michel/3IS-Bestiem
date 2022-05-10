using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MoucheBee : Ennemis
{
    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public override void Death()
    {
        //Transforme Frog en abeille
        PlayerFormsManager.Instance.SetCurrentSprites(PlayerFormsManager.Instance.AbeilleSprites);
        base.Death();
    }
}
