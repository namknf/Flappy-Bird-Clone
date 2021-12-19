using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    //When bird fly through the pipes, text change, old coin will destroy
    private void OnTriggerEnter2D(Collider2D collision) 
    {
       if (collision.CompareTag("Player")) {
           MoneyText.Coin += 1;
           Destroy(gameObject);
       }
    }
}
