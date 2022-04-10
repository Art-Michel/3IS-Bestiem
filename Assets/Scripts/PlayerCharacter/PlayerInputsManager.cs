using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputsManager : LocalManager<PlayerInputsManager>
{
    public PlayerInputs Inputs;

    PlayerSlurp _playerSlurp;
    PlayerMovement _playerMovement;
    protected override void Awake()
    {
        base.Awake();
        Inputs = new PlayerInputs();
        Inputs.Movement.Move.started += StartMovement;
        Inputs.Movement.Move.canceled += StopMovement;
        Inputs.Action.Slurp.started += StartSlurping;

        _playerSlurp = GetComponent<PlayerSlurp>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void StartMovement(InputAction.CallbackContext obj)
    {
        _playerMovement.StartPressingADirection();
    }

    private void StopMovement(InputAction.CallbackContext obj)
    {
        _playerMovement.StopPressingADirection();
    }

    private void StartSlurping(InputAction.CallbackContext obj)
    {
        _playerSlurp.Slurp();
    }

    #region disable enable inputs
    void OnEnable()
    {
        Inputs.Enable();
    }
    void OnDisable()
    {
        Inputs.Disable();
    }
    #endregion
}
