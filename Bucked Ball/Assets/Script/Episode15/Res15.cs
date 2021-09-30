using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Res15 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(16);
        StartPointKey.say = 0;
    }
}
