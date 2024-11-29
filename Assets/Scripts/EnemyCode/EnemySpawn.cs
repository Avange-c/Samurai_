using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    private float TimeSpawn;
    private Vector3 shiftEnemy = new Vector3(0, 2.5f, 0);
    void FixedUpdate()
    {
        TimeSpawn =  Time.time;
        int enemyPosition = Random.Range(0,2);
        if (TimeSpawn%2 == 0)
        {
            if (enemyPosition == 0)
            {
            Instantiate(Enemy, transform.position, Quaternion.identity);
            }

            if (enemyPosition == 1)
            {
            Instantiate(Enemy, transform.position + shiftEnemy, Quaternion.identity);
            }
        }
    }
}
