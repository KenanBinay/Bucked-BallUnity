using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Episode3Start : MonoBehaviour
{
    public Animator openlevel3;
    void Start()
    {
        openlevel3.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Bucked2and3.x1 == 1)// erğer 2.bölümdeki kovaya değer girince 3.bölümün animasyonunu aktifleştirir
        {
           
                openlevel3.enabled = true;
              //  Bucked2and3.x1 = 0;
            
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode3");
        StartPointKey.say = 0;
    }
}
