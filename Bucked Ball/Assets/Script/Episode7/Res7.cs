using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Res7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void RestartGame()
    {
        SceneManager.LoadScene("episode7");
        StartPointKey.say = 0;
    }
}
