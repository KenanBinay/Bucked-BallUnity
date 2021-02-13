﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class episode2Start : MonoBehaviour
{
    public  Animator openlevel;
    public TextMeshProUGUI text;
    public static string time1Lvl;
    void Start()
    {
        openlevel.enabled = false;
        Bucked1.x = LoadManager.instance.data.bölüm2;
        time1Lvl = LoadManager.instance.data.time2;

        text.SetText("" + time1Lvl);
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        
        if (Bucked1.x == 1) // eğer 1.bölümün kovasına değer girdise 2.bölümü aç
        {
            openlevel.enabled = true;
            Sayac1.sayacAc1 = 0;
            //Bucked1.x = 0;        
        }     
    }
    public void StartGame()
    {
        Sayac1.sayacAc1 = 0;
        SceneManager.LoadScene("episode2");  
        StartPointKey.say = 0;
    }
   
}