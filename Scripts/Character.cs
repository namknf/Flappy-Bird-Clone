using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject ButtonSelectPlayer;
    public GameObject TextSelectPlayer;

    void Start()
    {
        
    }

    
    void Update()
    {

    }
    //When you pressed button, button turn off, text turn on 
    public void OnButtonPress()
    {
        ButtonSelectPlayer.SetActive(false);
        TextSelectPlayer.SetActive(true);
    }
}