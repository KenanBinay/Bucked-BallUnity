using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels8 : MonoBehaviour
{
    public void GetLevels1()
    {
        Time.timeScale = 1f;
        Bucket8To9.x9 = 1;
        SceneManager.LoadScene(1);
    }
}
