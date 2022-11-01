using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameMenu : MonoBehaviour
{
    public GameObject exitMenuUI;
    public GameObject gameOver;

    void Start(){
        exitMenuUI.SetActive(false);
        gameOver.SetActive(false);
    }

    public void GameOver(){

        gameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    public void MenuGame(){
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void VillageGame(){
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void ExitMenuGame(){
        exitMenuUI.SetActive(true);
    }
    public void NoExitGame(){
        exitMenuUI.SetActive(false);
    }

    public void ExitGame(){
        Application.Quit();
    }
}
