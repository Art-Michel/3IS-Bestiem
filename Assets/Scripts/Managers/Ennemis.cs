using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using NaughtyAttributes;

public class Ennemis : MonoBehaviour
{
    [Button]
    protected virtual void Death()
    {
        //pts++
        UIManager.Instance.score += 100;
        UIManager.Instance.UpdateScore();
        Destroy(gameObject);
    }
}
