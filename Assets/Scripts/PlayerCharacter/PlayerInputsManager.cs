using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputsManager : MonoBehaviour
{
    public PlayerInputs Inputs;

    PlayerMovement _playerMovement;
    void Awake()
    {
        Inputs = new PlayerInputs();
        Inputs.Movement.Move.started += StartMovement;
        Inputs.Movement.Move.canceled += StopMovement;

        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void StartMovement(InputAction.CallbackContext obj)
    {
        _playerMovement.StartMoving();
    }

    private void StopMovement(InputAction.CallbackContext obj)
    {
        _playerMovement.StopMoving();
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
