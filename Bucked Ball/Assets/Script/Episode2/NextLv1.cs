using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLv1 : MonoBehaviour
{

    public void Next()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(4);
    }

}
