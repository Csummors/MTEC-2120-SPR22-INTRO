using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
   private void Start()
    {
        Enemy enemy = new Enemy();
        GameObject temp = enemy.bulletPrefab;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
