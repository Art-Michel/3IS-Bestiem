using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlurp : MonoBehaviour
{
    PlayerInputs _playerInputs;
    [SerializeField] GameObject _tongue;
    [SerializeField] Transform _tongueTip;
    [SerializeField] Transform _cursor;

    Vector3 _faceTargetDistance;
    bool _isShootingTongue;
    Vector3 _tongueTarget;
    bool _isRetractingTongue;
    float _tongueT;
    [SerializeField] float _tongueShootingTime;

    void Start()
    {
        _playerInputs = GetComponent<PlayerInputsManager>().Inputs;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        _tongue.SetActive(false);
    }

    void Update()
    {
        UpdateCursorPosition();

        if (_isShootingTongue) ShootTongue();
        if (_isRetractingTongue) RetractTongue();
    }

    void UpdateCursorPosition()
    {
        _cursor.position = Camera.main.ScreenToWorldPoint(_playerInputs.Action.Aim.ReadValue<Vector2>());
        _cursor.position = new Vector3(_cursor.position.x, _cursor.position.y, 0);
    }

    public void Slurp()
    {
        if (!_isShootingTongue && !_isRetractingTongue)
        {
            _tongue.SetActive(true);
            _tongueTarget = _cursor.position;

            _faceTargetDistance = _tongueTarget - _tongue.transform.position;
            _tongue.transform.up = _faceTargetDistance.normalized;
            _isShootingTongue = true;
        }
    }

    void Unslurp()
    {
        _tongue.SetActive(false);
        _isRetractingTongue = false;
    }

    void ShootTongue()
    {
        _tongueT += Time.deltaTime / _tongueShootingTime;
        _tongue.transform.localScale = new Vector3(1, Mathf.Lerp(0, _faceTargetDistance.magnitude * 2 - 1, _tongueT), 1);
        _tongueTip.transform.localScale = new Vector3(1, 1 / _tongue.transform.localScale.y, 1);
        if (_tongueT >= 1)
        {
            _isShootingTongue = false;
            _isRetractingTongue = true;
        }
    }

    void RetractTongue()
    {
        _tongueT -= Time.deltaTime / _tongueShootingTime;
        _tongue.transform.localScale = new Vector3(1, Mathf.Lerp(0, _faceTargetDistance.magnitude * 2 - 1, _tongueT), 1);
        _tongueTip.transform.localScale = new Vector3(1, 1 / _tongue.transform.localScale.y, 1);
        if (_tongueT <= 0)
        {
            Unslurp();
        }
    }
}
