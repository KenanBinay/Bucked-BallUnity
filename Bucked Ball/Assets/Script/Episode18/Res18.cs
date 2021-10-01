using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Res18 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(19);
        StartPointKey.say = 0;
    }
}
