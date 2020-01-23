using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIEvents : MonoBehaviour
{
    public void LoadGameScene()
    {
        // load the game scene
        SceneManager.LoadScene("Game Screen");
    } 

    public void Controls()
    {
        // load the game scene
        SceneManager.LoadScene("Controls");
    } 

    public void MainMenu()
    {
        // load the game scene
        SceneManager.LoadScene("Main Menu");
    } 
    
}
