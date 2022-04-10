using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueHitbox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<BaseMouche>().Death();
        }
    }
}
