using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour{
    public float runSpeed = 2;
    public float jumpSpeed = 3; 

    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;
    Animator animation;

    // Start is called before the first frame update
    void Start(){
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();  
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
        void Update(){
        Vector2 pos = transform.position;
        //animation.SetBool("Jump", false);


        if(Input.GetKey("d")  || Input.GetKey("right")){
            pos.x += runSpeed * Time.deltaTime;
            spriteRenderer.flipX = false;
            animation.SetBool("Run", true);

        }else if(Input.GetKey("a") || Input.GetKey("left")){
            pos.x -= runSpeed * Time.deltaTime;
            spriteRenderer.flipX = true;
            animation.SetBool("Run", true);
            
        }else{
            animation.SetBool("Run", false);
        }

        if((Input.GetKey("w") || Input.GetKey("space")) && CheckGround.isGrounded){
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        }else{
            animation.SetBool("Jump", false);
        }

        if(!CheckGround.isGrounded){
            animation.SetBool("Jump", true);
        }
   
        transform.position = pos;   
    }
}