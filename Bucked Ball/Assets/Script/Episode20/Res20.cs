using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Res20 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(21);
        StartPointKey.say = 0;
    }
}
