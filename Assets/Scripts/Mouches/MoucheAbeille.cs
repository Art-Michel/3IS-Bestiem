using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoucheAbeille : Ennemis
{
    protected override void Death()
    {
        //Transforme Frog en abeille
        base.Death();
    }
}
