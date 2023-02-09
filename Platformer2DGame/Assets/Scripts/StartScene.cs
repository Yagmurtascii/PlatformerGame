using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{

    [SerializeField] GameObject pane;
    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Load next scene
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1); //Load first level
    }


    public void LoadMainPage()
    {
        SceneManager.LoadScene("StartScene"); //Load start scene
        Time.timeScale = 1f;
    }

    public void HowCanIPlayOpen()
    {
        pane.SetActive(true);
    }
    public void HowCanIPlayClose()
    {
        pane.SetActive(false);
    }
}
