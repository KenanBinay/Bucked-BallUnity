using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Levels4 : MonoBehaviour
{
    public void GetLevels1()
    {
        Time.timeScale = 1f;
        Bucket4To5.x5 = 1;
        SceneManager.LoadScene(1);
    }
}
