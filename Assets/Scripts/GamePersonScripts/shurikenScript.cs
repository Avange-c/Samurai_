using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shurikenScript : MonoBehaviour
{
    private float speed = 50f;
    private float timeDestroy = 3f;
    public Rigidbody2D rb;
    //private Collision2D _shuriken;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        Invoke("DestroyBullet", timeDestroy);
        rb.velocity = transform.right * speed;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
		if (col.gameObject.tag == "Enemy") {
			Destroy (col.gameObject);
            Destroy (this.gameObject);
            moveGamePerson.Score = moveGamePerson.Score + 1f;
		}
	}
    
}
