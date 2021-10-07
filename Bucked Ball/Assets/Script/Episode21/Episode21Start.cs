using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Episode21Start : MonoBehaviour
{
    public Animator openLevel1,openLevel2,openLevel3,openLevel4,openLevel5,openLevel6,openLevel7,openLevel8,openLevel9;
    void Start()
    {
        openLevel1.enabled = false;
        openLevel2.enabled = false;
        openLevel3.enabled = false;
        openLevel4.enabled = false;
        openLevel5.enabled = false;
        openLevel6.enabled = false;
        openLevel7.enabled = false;
        openLevel8.enabled = false;
        openLevel9.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Bucked20To21.x21 == 1)
        {
            openLevel1.enabled = true;
            openLevel2.enabled = true;
            openLevel3.enabled = true;
            openLevel4.enabled = true;
            openLevel5.enabled = true;
            openLevel6.enabled = true;
            openLevel7.enabled = true;
            openLevel8.enabled = true;
            openLevel9.enabled = true;
        }
    }
    public void StartGame()
    {
      //  SceneManager.LoadScene("episode22");
        StartPointKey.say = 0;
    }
}
