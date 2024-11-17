using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotInEnemy : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && PauseScript._pause != 1)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
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
