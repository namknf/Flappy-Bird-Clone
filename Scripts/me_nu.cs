using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class me_nu : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetPlayers(int index) //When you pressed button, change skin
    {
        PlayerPrefs.SetInt("Player", index); //each player has its index and tag "Player"
    }
}
