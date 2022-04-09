using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoucheTetris : Ennemis
{
    protected override void Death()
    {
        //Transforme Frog en pièce de tetris
        base.Death();
    }
}
