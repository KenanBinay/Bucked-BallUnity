using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels1 : MonoBehaviour
{

    public void GetLevels1()
    {
        Time.timeScale = 1f;
        Bucked2and3.x1 = 1;
        SceneManager.LoadScene(1);
    }

}
