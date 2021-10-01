using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Episode18Start : MonoBehaviour
{
    public Animator openLevel;
    void Start()
    {
        openLevel.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Bucked17To18.x18 == 1)
        {
            openLevel.enabled = true;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode18");
        StartPointKey.say = 0;
    }
}
