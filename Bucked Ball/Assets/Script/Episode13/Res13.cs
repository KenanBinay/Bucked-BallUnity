using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Res13 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(14);
        StartPointKey.say = 0;
    }
}
