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
        SoundManager.Instance.MoucheDeathSound();
        UIManager.Instance.score += 100;
        UIManager.Instance.UpdateScore();
        Destroy(gameObject);
    }
}
