using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayFirstMode()
    {
        SceneManager.LoadScene("Game");
    }

    public void PlaySecondMode()
    {
        SceneManager.LoadScene("Game 2");
    }
}
