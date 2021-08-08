using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float playerspeed;
    public float jumpVelocity;
    SpriteRenderer playerSprite;

  
    bool Grounded;

    Animator anim;

   
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
      
       
    }

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        float playerdirection = Input.GetAxis("Horizontal");
       
         
            anim.SetTrigger("Run");
          
       
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Grounded)
            {
                JumpMethod();
                anim.SetTrigger("Jump");
            }

        }
        
    }
    private void JumpMethod()
    {
        Grounded = false;
        playerRB.velocity = new Vector2(0, jumpVelocity);
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            Debug.Log("Grounded");
            Grounded = true;
        }
    }
}