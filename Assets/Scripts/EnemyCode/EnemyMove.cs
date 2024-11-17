using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float speed = 25f;
    private float timeDestroy = 3f;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Invoke("DestroyBullet", timeDestroy);
        rb.velocity = -transform.right * speed;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
		if (col.gameObject.tag == "Player") {
            Destroy (this.gameObject);
            moveGamePerson.Score = moveGamePerson.Score - 0.5f;
		}
	}
    

}
