using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Episode9Start : MonoBehaviour
{
    public Animator openlevel;
    void Start()
    {
        openlevel.enabled = false;
    }


    void FixedUpdate()
    {
        if (Bucket8To9.x9 == 1)
        {
            openlevel.enabled = true;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode9");
        StartPointKey.say = 0;
    }
}
