using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Res14 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(15);
        StartPointKey.say = 0;
    }
}
