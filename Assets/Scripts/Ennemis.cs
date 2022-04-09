using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Ennemis : MonoBehaviour, IPooledObject
{
    public bool isSpawned;

    private string objectTag;

    private void Awake() 
    {
        objectTag = gameObject.tag;
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnObjectSpawn()
    {
        isSpawned = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isSpawned)
        {
            if(objectTag == "Test")
            {
                //pouvoir ennemi 1 
                //transform.position += Vector3.right * Time.deltaTime;
            }
            else if(objectTag == "Test2")
            {
                //pouvoir ennemi 2
                //transform.position += Vector3.left * Time.deltaTime;
            }
        }
    }
}
