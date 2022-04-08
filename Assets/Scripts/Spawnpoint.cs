using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        [Header("Variables pour l'instanciation")]
        [Space(10)]
        [Tooltip("nom de l'objet")] 
        public string tag;
        [Tooltip("préfab associé à l'objet")] 
        public GameObject prefab;
        [Tooltip("nombre d'objets à instancier")] 
        [Range(0,50)]
        public int size;
    }

    private int randomTest;
    private string tempTag;
    private bool isSpawning;
    public float spawningCD = 3f;

    [Tooltip("Liste de GameObjects à instancier")] 
    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary;

    // Start is called before the first frame update
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab, new Vector3(0, -10000, 0), Quaternion.identity);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    }

    public GameObject SpawnObject (string tag, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with tag " + tag + " doesn't exist.");
            return null;
        }

        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        IPooledObject pooledObj = objectToSpawn.GetComponent<IPooledObject>();
        if(pooledObj != null)
        {
            pooledObj.OnObjectSpawn();
        }

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        randomTest = Random.Range(0,2);
        switch (randomTest)
        {
            case 0 : 
                tempTag = "Test";
                break;
            case 1 :
                tempTag = "Test2";
                break;
            
            default:
                Debug.Log("Erreur, tag invalide");
                break;
        }
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
        SpawnObject(tempTag, transform.position, Quaternion.identity);
        StopCoroutine(SpawnEnemies());
    }

    private void StopSpawning()
    {
        isSpawning = false;
    }
}
