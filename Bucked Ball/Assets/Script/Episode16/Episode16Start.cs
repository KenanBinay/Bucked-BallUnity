using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Episode16Start : MonoBehaviour
{
    public Animator openLevel;
    void Start()
    {
        openLevel.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Bucked15To16.x16 == 1)
        {
            openLevel.enabled = true;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode16");
        StartPointKey.say = 0;
    }
}
