using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    private float TimeSpawn;
    

    void FixedUpdate()
    {
        TimeSpawn =  Time.time;
        if (TimeSpawn%2 == 0)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
        }
    }
}
