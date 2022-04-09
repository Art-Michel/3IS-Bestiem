using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoucheEtrange : Ennemis
{
    protected override void Death()
    {
        //Inverse les contrôles
        base.Death();
    }
}
