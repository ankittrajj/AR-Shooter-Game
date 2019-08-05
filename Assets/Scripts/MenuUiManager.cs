using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUiManager : MonoBehaviour
{
    
    public void loadGame()
    {
        SceneManager.LoadScene("Play");
    }
    public void exit()
    {
        Application.Quit();
    }
}
