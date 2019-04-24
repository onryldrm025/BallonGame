using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamaManager : MonoBehaviour
{
    [SerializeField] private GameObject Scene1;
    [SerializeField] private GameObject Scene;

    public void CreateNewScene( int Sceneno)
    {
        if(Sceneno == 1)
        {
            Scene.transform.position = new Vector2(Scene.transform.position.x, (Scene.transform.position.y + 19.8f));

        }
        else
        {
            Scene1.transform.position = new Vector2(Scene1.transform.position.x, (Scene1.transform.position.y + 19.8f));

        }
        



        
    }
}
