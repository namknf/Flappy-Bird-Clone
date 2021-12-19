using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    private Fly player; //link on script Fly

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Fly>();
        Time.timeScale = 1; //Time flows just like in the real world
    }

    public void GameOver () //Method called when the bird collides with other objects
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay () //Method for moving between scenes
    {
        SceneManager.LoadScene(2); 
    }
}
