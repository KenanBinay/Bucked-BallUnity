using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class episode2Start : MonoBehaviour
{
    public  Animator openlevel;
 
    void Start()
    {
        openlevel.enabled = false;
        Bucked1.x = LoadManager.instance.data.bölüm2;       
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        
        if (Bucked1.x == 1) // eğer 1.bölümün kovasına değer girdise 2.bölümü aç
        {
            openlevel.enabled = true;
            //Bucked1.x = 0;        
        }     
    }
    public void StartGame()
    {
        SceneManager.LoadScene("episode2");  
        StartPointKey.say = 0;
    }
   
}
