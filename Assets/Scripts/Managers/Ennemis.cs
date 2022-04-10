using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using NaughtyAttributes;

public class Ennemis : LocalManager<Ennemis>
{
    public GameObject baseTiles;
    public GameObject gbTiles;
    public GameObject realTiles;
    public GameObject uwuTiles;


    new private void Awake() 
    {
        baseTiles = TilesManager.Instance.tileSets[0];
        gbTiles = TilesManager.Instance.tileSets[1];
        realTiles = TilesManager.Instance.tileSets[2];
        uwuTiles = TilesManager.Instance.tileSets[3];
    }

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
