using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMoveControl : MonoBehaviour
{
    Rigidbody2D physics;
    public float speedHorizontal;//yatayda hareket değişkeni
    public float speedVertical;//dikeyde hareket değişkeni
    public float time;//Ne kadar süre boyunca gideceği
    void Start()
    {
        physics = GetComponent<Rigidbody2D>();
        InvokeRepeating("MoveControl", 0.1f, time);

    }
    void Update()
    {

        physics.velocity = new Vector2(speedHorizontal, speedVertical);
    }
    void MoveControl()
    {

        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);//Kuşun terse döndüğünde transformları ile oynayarak yönünü düzeltmek

        speedHorizontal = -speedHorizontal;
        speedVertical = -speedVertical;


    }
}
