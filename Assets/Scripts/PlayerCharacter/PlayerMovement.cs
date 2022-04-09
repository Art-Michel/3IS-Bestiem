using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerInputs _playerInputs;

    bool _isPressingADirection = false;
    float _movementLerpT = 0;
    [SerializeField] AnimationCurve _movementCurve = null;
    [SerializeField] float _playerMaxSpeed;
    float _currentSpeed;
    Vector2 _wantedPosition = Vector2.zero;

    void Start()
    {
        _playerInputs = GetComponent<PlayerInputsManager>().Inputs;
    }

    void Update()
    {
        _wantedPosition = _playerInputs.Movement.Move.ReadValue<Vector2>(); // Read Movement input
        if (_isPressingADirection) _movementLerpT += Time.deltaTime;
        _currentSpeed = Mathf.Lerp(0, _playerMaxSpeed, _movementCurve.Evaluate(_movementLerpT));
        MoveFrog();

        if (_movementLerpT >= 1) _movementLerpT = 0;
    }

    internal void StartMoving()
    {
        _isPressingADirection = true;
    }

    internal void StopMoving()
    {
        _isPressingADirection = false;
        _movementLerpT = 0;
    }

    private void MoveFrog()
    {
        transform.position += (Vector3)_wantedPosition * _currentSpeed * Time.deltaTime;
    }
}
