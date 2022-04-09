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

    private GameObject spawnedObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        randomTest = Random.Range(0, enemiesToSpawn.Count * 3);
        if(randomTest < enemiesToSpawn.Count - 1)
        {
            objToSpawn = enemiesToSpawn[randomTest];
        }
        else 
        {
            objToSpawn = enemiesToSpawn[enemiesToSpawn.Count - 1];
        }

        if(!isSpawning)
        {
            isSpawning = true;
            spawnedObject = Instantiate(objToSpawn, transform.position, Quaternion.identity);
            Invoke("StopSpawning", spawningCD);
        }
    }
    
    private void StopSpawning()
    {
        isSpawning = false;
    }
}
