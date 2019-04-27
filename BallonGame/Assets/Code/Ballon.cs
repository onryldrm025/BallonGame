using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    Rigidbody2D rb;
    public float MoveSpeed = 20;
    private float Move;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    


    void Update()
    {

      

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Scene")
        {

            
            FindObjectOfType<GamaManager>().CreateNewScene(1);



        }
        else
        {
            
            FindObjectOfType<GamaManager>().CreateNewScene(2);
        }
        


    }
    //Kuşlara denk geldiğinde game over.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "birdgodie")
        {
            Debug.Log("Öldün Çık.");
        }
    }
    void AccelerometerMove()
    {
        float x = Input.acceleration.x;
        if (x < -0.1f)
        {
            MoveLeft();

        } else if(x > 0.1f){
            MoveRight();
        }

        else
        {
            SetVelocityZero();
        }
    }
    private void FixedUpdate()
    {
        float temp = Input.acceleration.x;
        if (temp < 0.1f)
        {
            MoveLeft();
        }
        else if (temp > 0.1f)
        {
            MoveRight();
        }
        else
        {
            SetVelocityZero();
        }
    }
    void MoveLeft()
    {
        //rb.AddForce(new Vector2(-15, 0));
        Move = Input.acceleration.x * MoveSpeed;
        rb.velocity = new Vector2(Move, 2f);
    }
    void MoveRight()
    {
        //rb.AddForce(new Vector2(15, 0));
        Move = Input.acceleration.x * MoveSpeed;
        rb.velocity = new Vector2(Move, 2f);
    }
    void SetVelocityZero()
    {

    }
    

}
