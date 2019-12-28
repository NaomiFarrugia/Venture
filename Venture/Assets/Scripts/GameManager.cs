using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool _isGameOver = false;
    
    public void GameOver()
    {
        _isGameOver = true;
    }
}
