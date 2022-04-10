using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueHitbox : MonoBehaviour
{
    
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Ennemy"))
        {
            other.transform.GetComponent<Ennemis>().Death();
        }
    }
}
