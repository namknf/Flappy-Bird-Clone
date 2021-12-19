using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private Fly player; //link on script Fly
    public Transform PlayerPos; //player's position, when you choose skin
    public Fly[] players; //array of skins

    private void Awake() //objects initialisation, to avoid mistakes 
    {
       //create identity player at the same position
       player = Instantiate(players[PlayerPrefs.GetInt("Player")], PlayerPos.position, Quaternion.identity).GetComponent<Fly>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
