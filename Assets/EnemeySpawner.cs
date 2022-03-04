using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 position = new Vector3(Random.Range(-5, 5), 1.0f, Random.Range(-5, 5));
            Instantiate(enemyPrefab, position, Quaternion.identity);
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
