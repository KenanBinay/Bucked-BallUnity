using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class episode2Start : MonoBehaviour
{
    public  Animator openlevel;
    public static string time1Lvl;
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
            Sayac.deger = 0;
            openlevel.enabled = true;
          
            //Bucked1.x = 0;        
        }     
    }

    public void StartGame()
    {
        Debug.Log("bölüm 2 başladı");
       // Bucked2and3.x1 = 0;
        StartPointKey.say = 0;

        StartCoroutine(StartMap());
    }
    public IEnumerator StartMap()
    {
        StartPointKey.say = 0;
        yield return new WaitForSeconds(0.30f);
        SceneManager.LoadScene("episode2");
    }
}
