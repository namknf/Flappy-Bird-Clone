using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{
    public static int Coin;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    //int number of Coins converts to string
    void Update()
    {
        text.text = Coin.ToString();
    }
}
