using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _isGameOver = false;
    public GameObject RestartGame;

    void Update()
    {
        if (Input.GetButtonDown("Cancel") && _isGameOver == true)
        {
            SceneManager.LoadScene("Game Screen");
        }
    }

    public void GameOver()
    {
        _isGameOver = true;
    }

    void Restart ()
    {
        { Debug.Log("Restart");
        RestartGame.SetActive(false);
        Time.timeScale = 1f;
        }
    }

    

}
