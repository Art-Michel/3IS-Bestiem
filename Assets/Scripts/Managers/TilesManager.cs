using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesManager : LocalManager<TilesManager>
{   
    [HideInInspector]
    public GameObject previousTileSet;
    public GameObject currentTileSet;

    public List<GameObject> tileSets;

    public void ChangeTileSet(GameObject tileSet)
    {
        previousTileSet = currentTileSet;
        currentTileSet = tileSet;
        previousTileSet.SetActive(false);
        currentTileSet.SetActive(true);
        previousTileSet = null;
    }

}
