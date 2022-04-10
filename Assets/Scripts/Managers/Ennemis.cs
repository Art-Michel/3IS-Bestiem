using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using NaughtyAttributes;

public class Ennemis : LocalManager<Ennemis>
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    [Button]
    protected virtual void Death()
    {
        //pts++
        UIManager.Instance.score += 100;
        UIManager.Instance.UpdateScore();
        Destroy(gameObject);
    }
}
