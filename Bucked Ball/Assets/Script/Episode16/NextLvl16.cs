using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLvl16 : MonoBehaviour
{
    public void Next()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(18);
    }
}
