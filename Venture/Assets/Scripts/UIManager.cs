using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreText;

    [SerializeField]
    private Image _livesImg;

    [SerializeField]
    private Sprite[] _liveSprites;

    [SerializeField]
    private GameObject _gameOverText;  

    void Start()
    {
        SetScoreText(0);
    }

    public void SetScoreText(int score)
    {
        // updates the score text in the Canvas UI
        _scoreText.SetText("Score: " + score);
    }
    public void UpdateLives(int lives)
    {
        // update the lives image to match the lives number
        _livesImg.sprite = _liveSprites[lives];
        // if the lives are zero
        // start the game over sequence 
        if (lives < 1);
        
    }
}
