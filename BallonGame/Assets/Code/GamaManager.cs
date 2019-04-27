using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamaManager : MonoBehaviour
{
    [SerializeField] private GameObject Scene1;
    [SerializeField] private GameObject Scene2;
    [SerializeField] private Canvas Canvas;
    [SerializeField] private GameObject Ballons;
    Animator Animation;
    Rigidbody2D rb;

    private void Start()
    {
        Animation = Canvas.GetComponent<Animator>();
        rb = Ballons.GetComponent<Rigidbody2D>();
        
    }


    public void CreateNewScene( int Sceneno)
    {
        if(Sceneno == 1)
        {
            Scene2.transform.position = new Vector2(Scene2.transform.position.x, (Scene2.transform.position.y + 19.8f));

        }
        else
        {
            Scene1.transform.position = new Vector2(Scene1.transform.position.x, (Scene1.transform.position.y + 19.8f));

        }
        



        
    }
    public void GameStart()
    {
        
        Animation.SetBool("Start", true);
        rb.constraints = RigidbodyConstraints2D.None;

    }

}
