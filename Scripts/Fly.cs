using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float velocity = 1; //Force with which we act on the bird
    private Rigidbody2D rigic; //Variable with type Rigidbody2D 
    private Main main;
    private GameManager gameman;

    void Start()
    {
        gameman = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        rigic = GetComponent<Rigidbody2D>(); //Returns the component which belongs to the bird
        main = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Main>();
    }

    //If we click on the left mouse button, then the bird start fly
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rigic.velocity = Vector2.up*velocity;
        }
    }
    //Collision private method (colliders or Ridgidbody)
    private void OnCollisionEnter2D(Collision2D collision)
    {
       gameman.GameOver();
    }
}
