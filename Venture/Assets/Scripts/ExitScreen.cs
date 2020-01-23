using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScreen : MonoBehaviour
{
    public void exit()
    {
        Debug.Log("Has Quit Game");
        Application.Quit();
    }
}
