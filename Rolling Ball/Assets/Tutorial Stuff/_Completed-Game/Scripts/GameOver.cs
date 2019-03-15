using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverObject;
    private void Start()
    {
        gameOverObject = GameObject.Find("GameOver");
        gameOverObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Code Ammendent to fix Gameover message
        if (other.tag == "Player")
        {
            gameOverObject.SetActive(true);
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene("Game");
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("quitGame");
    }

}