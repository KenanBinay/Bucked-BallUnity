using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels0 : MonoBehaviour
{
    public void GetLevels1()
    {
        Time.timeScale = 1f;
        Bucked1.x = 1;
        SceneManager.LoadScene(1);
    }
}
