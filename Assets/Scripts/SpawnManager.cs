using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPreFabs;
    private float spawnRangeX=20;
    private float spawnRangeDz=1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("repeatSpawn", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void repeatSpawn()
    {
        int animalIndex = Random.Range(0, animalPreFabs.Length);
        float X = Random.Range(-spawnRangeX, spawnRangeX);
        float dZ = Random.Range(-spawnRangeDz, spawnRangeDz);
        Instantiate(animalPreFabs[animalIndex], new Vector3(X, 0, 20 + dZ), animalPreFabs[animalIndex].transform.rotation);
    }
}
