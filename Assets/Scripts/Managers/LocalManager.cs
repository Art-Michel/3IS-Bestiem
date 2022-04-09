using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LocalManager<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    protected virtual void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(this);
            return;
        }
        Instance = GetComponent<T>();
    }

    protected virtual void OnDestroy()
    {
        Instance = null;
    }
}
