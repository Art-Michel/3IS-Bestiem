using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoucheVer : Ennemis
{
    protected override void Death()
    {
        //Passage en mode Fishing-Game
        base.Death();
    }
}
