using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectManager<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    protected virtual void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = GetComponent<T>();
        DontDestroyOnLoad(Instance);
    }
}
