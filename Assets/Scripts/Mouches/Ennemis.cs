using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Ennemis : MonoBehaviour
{
    private void Awake() 
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected virtual void Death()
    {
        //pts++
        Destroy(gameObject);
    }
}
