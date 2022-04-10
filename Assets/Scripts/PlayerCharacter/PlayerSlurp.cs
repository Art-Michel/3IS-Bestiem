using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlurp : MonoBehaviour
{
    TongueHitbox _tongueHitbox;

    Vector3 _tipBasePos;

    private const int _tongueMaxRange = 12;
    [SerializeField] GameObject _tongue;
    [SerializeField] Transform _tongueTip;
    [SerializeField] Transform _cursor;

    public Vector3 _faceTargetDistance;
    bool _isShootingTongue;
    Vector3 _tongueTarget;
    bool _isRetractingTongue;
    float _tongueT;
    [SerializeField] float _tongueShootingTime;
    PlayerInputs _playerInputs;

    void Awake()
    {
        _tongueHitbox = GetComponentInChildren<TongueHitbox>();
    }

    void Start()
    {
        _playerInputs = GetComponent<PlayerInputsManager>().Inputs;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        _tongue.SetActive(false);
        _tipBasePos = _tongueTip.transform.localPosition;
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

            ResetTongueTip();
            _faceTargetDistance = _tongueTarget - _tongue.transform.position;
            _tongue.transform.up = _faceTargetDistance.normalized;
            _isShootingTongue = true;
        }
    }

    void ShootTongue()
    {
        _tongueT += Time.deltaTime / _tongueShootingTime;
        _tongue.transform.localScale = new Vector3(1, Mathf.Lerp(0, Mathf.Clamp(_faceTargetDistance.magnitude * 2, 0, _tongueMaxRange), _tongueT), 1);
        _tongueTip.transform.localScale = new Vector3(1, Mathf.Clamp(1 / _tongue.transform.localScale.y, 0.01f, 1), 1);
        if (_tongueT >= 1)
        {
            Unslurp();
        }
    }

    public void Unslurp()
    {
        _tongueT = 1;
        _isShootingTongue = false;
        _isRetractingTongue = true;
    }

    void RetractTongue()
    {
        _tongueT -= Time.deltaTime / _tongueShootingTime;
        _tongue.transform.localScale = new Vector3(1, Mathf.Lerp(0, Mathf.Clamp(_faceTargetDistance.magnitude * 2, 0, _tongueMaxRange), _tongueT), 1);
        _tongueTip.transform.localScale = new Vector3(1, Mathf.Clamp(1 / _tongue.transform.localScale.y, 0.01f, 1), 1);
        if (_tongueT <= 0)
        {
            EndSlurp();
        }
    }

    void EndSlurp()
    {
        if (_tongueHitbox.enemyTransform)
            _tongueHitbox.enemyTransform.GetComponent<Ennemis>().Death();
        _isRetractingTongue = false;
        _tongue.SetActive(false);
    }

    void ResetTongueTip()
    {
        _tongueTip.localScale = Vector3.one;
        _tongueTip.localPosition = _tipBasePos;
    }
}
