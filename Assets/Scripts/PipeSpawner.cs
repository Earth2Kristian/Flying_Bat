using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    //public float maxTimer = 1;
    //private float timer = 0;

    // Pipe Spawn Timer
    public float spawnTimer;
    
    public GameObject trees;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = Random.Range(1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            GameObject newpipes = Instantiate(trees);
            newpipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipes, 15);
            spawnTimer = Random.Range(1, 2);
        }

        
    }
}
