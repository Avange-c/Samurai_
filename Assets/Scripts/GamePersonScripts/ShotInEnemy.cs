using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotInEnemy : MonoBehaviour
{
    private Vector3 shift = new Vector3(1, 0, 0);

    public GameObject bullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && PauseScript._pause != 1 && EnemyMove._shootInEnemy == 1)
        {
            Instantiate(bullet, transform.position + shift, Quaternion.identity);
        }
    }

    void DestroyBullet()
    {
        Destroy(bullet);
    }
/*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet,new Vector3 (i * 2.0F, 0, 0), Quaternion.identity);
        }
    }
    */
}
