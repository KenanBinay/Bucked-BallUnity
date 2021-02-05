using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Episode10Start : MonoBehaviour
{
    public Animator openlevel;
    void Start()
    {
        openlevel.enabled = false;
    }


    void FixedUpdate()
    {
        if (Bucket9To10.x10 == 1)
        {
            openlevel.enabled = true;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode10");
        StartPointKey.say = 0;
    }
}
