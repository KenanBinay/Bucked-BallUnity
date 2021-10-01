using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Res16 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(17);
        StartPointKey.say = 0;
    }
}
