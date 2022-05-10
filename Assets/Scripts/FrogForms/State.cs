using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
    public FrogFSM fsm = null;

    public string Name { get; private set; }

    public State(string name)
    {
        this.Name = name;
    }

    public virtual void Begin()
    {

    }

    public virtual void Update()
    {

    }

    public virtual void Exit()
    {
        
    }
}
