using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Res8 : MonoBehaviour
{
    
    void Start()
    {
        
    }

  public void RestartGame()
    {
        SceneManager.LoadScene("episode8");
        StartPointKey.say = 0;
    }
}
