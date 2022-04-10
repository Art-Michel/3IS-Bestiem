using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Ennemy"))
        {
            Debug.Log("Aie");
            Time.timeScale = 0f;
        }
    }
}
