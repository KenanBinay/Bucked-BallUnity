using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Episode17Start : MonoBehaviour
{
    public Animator openLevel;
    void Start()
    {
        openLevel.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Bucked16To17.x17 == 1)
        {
            openLevel.enabled = true;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode17");
        StartPointKey.say = 0;
    }
}
