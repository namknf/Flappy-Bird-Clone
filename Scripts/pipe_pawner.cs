using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_pawner : MonoBehaviour
{
    public float maxTime = 1; 
    private float timer = 0; //time with wich pipes moving
    public GameObject pipe; 
    public float height; //height between pipes

    void Start() //create this method so that our spawner work
    {
        GameObject newpipe = Instantiate(pipe); //create prefab for destroy in gametime
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0); //pipe position for spawn
    }

    
    void Update() //Spawn objects
    {
        if(timer > maxTime) 
        {
           GameObject newpipe = Instantiate(pipe);
           newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0); 
           Destroy(newpipe, 15); //traversed pipes are destroyed for 15 seconds
           timer = 0;
        }
        timer +=Time.deltaTime;
    }
}
