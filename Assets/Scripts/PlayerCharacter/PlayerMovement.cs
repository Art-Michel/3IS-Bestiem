using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerInputs _playerInputs;
    PlayerSpriteManager _playerSpriteManager;
    SpriteRenderer _bodySpriteRenderer;
    [SerializeField] Transform _collisionCenter;

    bool _isPressingADirection = false;
    float _movementLerpT = 0;
    [SerializeField] AnimationCurve _movementCurve = null;
    [SerializeField] float _playerMaxSpeed;
    float _currentSpeed;
    Vector2 _wantedPosition = Vector2.zero;
    [SerializeField] float _lerpSpeed;

    void Awake()
    {
        _bodySpriteRenderer = GetComponentInChildren<SpriteRenderer>();
        _playerSpriteManager = GetComponent<PlayerSpriteManager>();

    }

    void Start()
    {
        _playerInputs = GetComponent<PlayerInputsManager>().Inputs;
    }

    void Update()
    {
        _wantedPosition = _playerInputs.Movement.Move.ReadValue<Vector2>(); // Read Movement input
        if (_isPressingADirection) _movementLerpT += Time.deltaTime / _lerpSpeed;
        _currentSpeed = Mathf.Lerp(0, _playerMaxSpeed, _movementCurve.Evaluate(_movementLerpT));
        MoveFrog();
        AnimateFrog();

        if (_movementLerpT >= 1) _movementLerpT = 0;
    }

    private void AnimateFrog()
    {
        if (_movementLerpT < 0.1f) _bodySpriteRenderer.sprite = _playerSpriteManager.CurrentSprites[0];
        else if (_movementLerpT < 0.4f) _bodySpriteRenderer.sprite = _playerSpriteManager.CurrentSprites[1];
        else if (_movementLerpT < 0.7f) _bodySpriteRenderer.sprite = _playerSpriteManager.CurrentSprites[2];
        else if (_movementLerpT < 1f) _bodySpriteRenderer.sprite = _playerSpriteManager.CurrentSprites[3];

        if (_wantedPosition.x < 0) _bodySpriteRenderer.flipX = true;
        else if (_wantedPosition.x > 0) _bodySpriteRenderer.flipX = false;

        _bodySpriteRenderer.transform.position = new Vector2(transform.position.x, transform.position.y + _currentSpeed * 0.07f);
    }

    internal void StartMoving()
    {
        _isPressingADirection = true;
    }

    internal void StopMoving()
    {
        _isPressingADirection = false;
        _movementLerpT = 0;
        _bodySpriteRenderer.sprite = _playerSpriteManager.CurrentSprites[3];
    }

    private void MoveFrog()
    {
        CheckForCollisions();
        transform.position += (Vector3)_wantedPosition * _currentSpeed * Time.deltaTime;
    }

    void CheckForCollisions()
    {
        RaycastHit2D hit2D = Physics2D.Raycast(_collisionCenter.position, _wantedPosition.normalized, 0.2f);
        if (hit2D && hit2D.transform.CompareTag("Wall"))
        {
            _wantedPosition -= hit2D.normal * Vector2.Dot(_wantedPosition, hit2D.normal);
            CheckForCollisions();
        }
    }
}
