using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Res17 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(18);
        StartPointKey.say = 0;
    }
}
