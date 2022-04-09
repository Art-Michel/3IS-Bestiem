using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoucheTron : Ennemis
{
    protected override void Death()
    {
        //Laisse une trainée derrière Frog qui tue les mouches
        base.Death();
    }
}
