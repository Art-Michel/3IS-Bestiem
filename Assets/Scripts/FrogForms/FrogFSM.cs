using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogFSM : MonoBehaviour
{
    private Dictionary<string, State> states;

    public State currentState { get; private set; }
    public State previousState { get; private set; }

    void Awake()
    {
        states = new Dictionary<string, State>();
    }

    void Start()
    {
        AddState(new FrogState());

        ChangeState(StateNames.FROG);
    }

    public void AddState(State state)
    {
        state.fsm = this;
        states[state.Name] = state;
    }

    public void ChangeState(string nextStateName)
    {
        State nextState = null;
        states.TryGetValue(nextStateName, out nextState);

        if (nextState == null)
        {
            Debug.LogError(nextStateName + " doesn't exist");
            return;
        }

        if (nextState == currentState)
            return;

        if (currentState != null)
            currentState.Exit();

        previousState = currentState;
        currentState = nextState;
        currentState.Begin();

        Debug.Log(currentState.Name + " started");
    }

    private void Update()
    {
        if (currentState != null)
            currentState.Update();
    }
}
