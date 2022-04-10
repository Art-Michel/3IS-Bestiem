using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class Spawnpoint : MonoBehaviour
{
    private int randomTest;
    private string tempTag;
    private bool isSpawning;
    public float spawningCD = 3f;

    public List<GameObject> enemiesToSpawn;

    private GameObject objToSpawn;

    // Update is called once per frame
    void Update()
    {
        if(TilesManager.Instance.currentTileSet == TilesManager.Instance.tileSets[0])
        {
            randomTest = Random.Range(0, enemiesToSpawn.Count * 3);
            if(randomTest < enemiesToSpawn.Count - 1)
            {
                objToSpawn = enemiesToSpawn[randomTest];
            }
            else 
            {
                objToSpawn = enemiesToSpawn[0];
            }
        }
        else if(TilesManager.Instance.currentTileSet == TilesManager.Instance.tileSets[1])
        {
            randomTest = Random.Range(0, enemiesToSpawn.Count * 3);
            if(randomTest < enemiesToSpawn.Count - 1)
            {
                objToSpawn = enemiesToSpawn[randomTest];
            }
            else 
            {
                objToSpawn = enemiesToSpawn[1];
            }
        }
        else if(TilesManager.Instance.currentTileSet == TilesManager.Instance.tileSets[2])
        {
            randomTest = Random.Range(0, enemiesToSpawn.Count * 3);
            if(randomTest < enemiesToSpawn.Count - 1)
            {
                objToSpawn = enemiesToSpawn[randomTest];
            }
            else 
            {
                objToSpawn = enemiesToSpawn[2];
            }
        }
        else if(TilesManager.Instance.currentTileSet == TilesManager.Instance.tileSets[3])
        {
            randomTest = Random.Range(0, enemiesToSpawn.Count * 3);
            if(randomTest < enemiesToSpawn.Count - 1)
            {
                objToSpawn = enemiesToSpawn[randomTest];
            }
            else 
            {
                objToSpawn = enemiesToSpawn[3];
            }
        }

        if(!isSpawning)
        {
            isSpawning = true;
            Instantiate(objToSpawn, transform.position, Quaternion.identity);
            Invoke("StopSpawning", spawningCD);
        }
    }
    
    private void StopSpawning()
    {
        isSpawning = false;
    }

    [Button]
    public void Spawn0()
    {
        Instantiate(enemiesToSpawn[0], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn1()
    {
        Instantiate(enemiesToSpawn[1], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn2()
    {
        Instantiate(enemiesToSpawn[2], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn3()
    {
        Instantiate(enemiesToSpawn[3], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn4()
    {
        Instantiate(enemiesToSpawn[4], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn5()
    {
        Instantiate(enemiesToSpawn[5], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn6()
    {
        Instantiate(enemiesToSpawn[6], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn7()
    {
        Instantiate(enemiesToSpawn[7], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn8()
    {
        Instantiate(enemiesToSpawn[8], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn9()
    {
        Instantiate(enemiesToSpawn[9], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn10()
    {
        Instantiate(enemiesToSpawn[10], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn11()
    {
        Instantiate(enemiesToSpawn[11], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn12()
    {
        Instantiate(enemiesToSpawn[12], transform.position, Quaternion.identity);
    }
    [Button]
    public void Spawn13()
    {
        Instantiate(enemiesToSpawn[13], transform.position, Quaternion.identity);
    }

}
