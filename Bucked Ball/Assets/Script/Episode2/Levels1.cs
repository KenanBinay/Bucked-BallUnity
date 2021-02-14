using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels1 : MonoBehaviour
{

    public void GetLevels1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
  
}
