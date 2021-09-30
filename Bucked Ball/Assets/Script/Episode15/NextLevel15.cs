using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel15 : MonoBehaviour
{
    public void Next()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(17);
    }
}
