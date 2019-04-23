using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    Rigidbody2D rb;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    


    void Update()
    {

        rb.AddForce(new Vector2(0, 500 * Time.deltaTime));
        
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




}
