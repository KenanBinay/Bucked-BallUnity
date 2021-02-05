using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Episode7Start : MonoBehaviour
{
    public Animator openLevel;
    void Start()
    {
        openLevel.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Bucked6To7.x7 == 1)
        {
            openLevel.enabled = true;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode7");
        StartPointKey.say = 0;
    }
}
