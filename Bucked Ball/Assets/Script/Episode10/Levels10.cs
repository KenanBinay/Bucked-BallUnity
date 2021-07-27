using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels10 : MonoBehaviour
{
    public void GetLevels1()
    {
        Time.timeScale = 1f;
        Bucked10To11.x11 = 1;
        SceneManager.LoadScene(1);
    }
}
