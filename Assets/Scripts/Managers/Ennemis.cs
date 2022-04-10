using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using NaughtyAttributes;

public class Ennemis : MonoBehaviour
{
    [Button]
    public virtual void Death()
    {
        //pts++
        Debug.Log("*dies from mid*");
        UIManager.Instance.score += 100;
        UIManager.Instance.UpdateScore();
        Destroy(gameObject);
    }
}
