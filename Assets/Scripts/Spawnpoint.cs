using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{

    private int randomTest;
    private string tempTag;
    private bool isSpawning;
    public float spawningCD = 3f;

    public List<GameObject> enemiesToSpawn;

    private GameObject objToSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        randomTest = Random.Range(0, enemiesToSpawn.Count);
        objToSpawn = enemiesToSpawn[randomTest];

        if(!isSpawning)
        {
            isSpawning = true;
            StartCoroutine(SpawnEnemies());
            Invoke("StopSpawning", spawningCD);
        }
    }

    public IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(spawningCD);
        Instantiate(objToSpawn, transform.position, Quaternion.identity);
        StopCoroutine(SpawnEnemies());
    }

    private void StopSpawning()
    {
        isSpawning = false;
    }
}
