using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _isGameOver = false;
    
    public GameObject gameOverCanvas;

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    private void Start()
    {
        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {  
            if (GameIsPaused)
    {
        Resume();
    } else
    {
        Pause();
    }
        }
    }
    
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
        _isGameOver = true;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume ()
    {
        Debug.Log("resume");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
