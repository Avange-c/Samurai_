using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveGamePerson : MonoBehaviour
{
    private float _speedX = 15f;
    private float _jumpPower = 200f;
    private bool onFloor = false;
    public static float Score = 0f;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    

    void FixedUpdate()
    {
        transform.position += transform.right * Input.GetAxis("Horizontal") * _speedX * Time.deltaTime; 

        if (Input.GetButton("Jump") && onFloor)
        {
            rb.AddForce(transform.up * _jumpPower);
        }
        if (Score == -2)
        {
            SceneManager.LoadScene(2);
            
        }
    }


    void OnCollisionEnter2D(Collision2D Ground)
    {
        onFloor = true;
    }
    void OnCollisionExit2D(Collision2D Ground)
    {
        onFloor = false;
    }
     
}