using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Epsidode8Start : MonoBehaviour
{
    public Animator openlevel;
    void Start()
    {
        openlevel.enabled = false;
    }

   
    void FixedUpdate()
    {
        if (Bucked7To8.x8 == 1)
        {
            openlevel.enabled = true;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode8");
        StartPointKey.say = 0;
    }
}
