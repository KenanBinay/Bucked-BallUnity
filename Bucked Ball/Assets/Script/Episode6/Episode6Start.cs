using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Episode6Start : MonoBehaviour
{
    public Animator openLevel;
    void Start()
    {
        openLevel.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Bucked5To6.x6 == 1)
        {
            openLevel.enabled = true;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode6");
        StartPointKey.say = 0;
    }
}
