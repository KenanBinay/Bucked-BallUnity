using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels11 : MonoBehaviour
{
    public void GetLevels1()
    {
        Time.timeScale = 1f;
        Bucked11To12.x12 = 1;
        SceneManager.LoadScene(1);
    }
}
