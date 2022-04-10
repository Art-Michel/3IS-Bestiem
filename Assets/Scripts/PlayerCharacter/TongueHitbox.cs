using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueHitbox : MonoBehaviour
{
    public List<Transform> enemyTransforms;
    [SerializeField]Transform _mouthPosition;

    PlayerSlurp _playerSlurp;

    void Awake()
    {
        _playerSlurp = GetComponentInParent<PlayerSlurp>();
    }
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Ennemy"))
        {
            other.transform.parent = transform;
            enemyTransforms.Add(other.transform);
            other.transform.GetComponent<BoxCollider2D>().enabled = false;
        }
        if (other.transform.CompareTag("Wall"))
        {
            _playerSlurp._faceTargetDistance = transform.position - _mouthPosition.position;
            _playerSlurp.Unslurp();
        }
    }
}
