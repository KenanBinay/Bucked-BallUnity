using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Res19 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(20);
        StartPointKey.say = 0;
    }
}
