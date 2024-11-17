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

    private SpriteRenderer spriteR;

    public Sprite m_SpriteRenderer;
    public Sprite m_SpriteRenderer_1;
    public Sprite m_SpriteRenderer_2;
    public Sprite m_SpriteRenderer_3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        Time.timeScale = 1f;
        spriteR.sprite =  m_SpriteRenderer_3;
        switch (SkinCheck.SkinState)
        {
            case 0:
                spriteR.sprite =  m_SpriteRenderer;
                break;
            case 1:
                spriteR.sprite =  m_SpriteRenderer_1;
                break;
            case 2:
                spriteR.sprite =  m_SpriteRenderer_2;
                break;
            case 3:
                spriteR.sprite =  m_SpriteRenderer_3;
                break;
        }
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