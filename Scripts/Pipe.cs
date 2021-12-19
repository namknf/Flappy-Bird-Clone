using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed; //Pipe speed

    void Start()
    {
  
    }

    
    void Update() //Pipes moving on the left
    {
      transform.position += Vector3.left * speed * Time.deltaTime;  
    }
}
