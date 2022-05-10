using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogState : State
{
    public FrogState() : base(StateNames.FROG)
    {

    }

    public override void Begin()
    {
        PlayerFormsManager.Instance.SetCurrentSprites(PlayerFormsManager.Instance.RegularSprites);
    }
}
