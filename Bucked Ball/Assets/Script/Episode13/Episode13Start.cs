using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Episode13Start : MonoBehaviour
{
    public Animator openLevel;
    void Start()
    {
        openLevel.enabled = false;
    }

    
    void FixedUpdate()
    {
        if (Bucked12To13.x13 == 1)
        {
            openLevel.enabled = true;
        }
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode13");
        StartPointKey.say = 0;
    }
}
