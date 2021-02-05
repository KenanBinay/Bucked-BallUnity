using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    private GameObject Resume;
    public  GameObject Menu;
    public GameObject LevelEnd1;
    void Start()
    {
        Menu.SetActive(false);
    }

    // Update is called once per frame
   public void Bas()
    {
        if (GameIsPaused)
        {
            resume();
        }
        else
        {
          
            pause();
        }
    }
    public void resume()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    private void pause()
    {     
        Menu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Levels()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }
}
