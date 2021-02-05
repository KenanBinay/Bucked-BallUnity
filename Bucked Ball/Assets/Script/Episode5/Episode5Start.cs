using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Episode5Start : MonoBehaviour
{
    public Animator openLevel;
    void Start()
    {
        openLevel.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Bucket4To5.x5==1)
        {
            openLevel.enabled = true;
          
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode5");
        StartPointKey.say = 0;
    }
}
