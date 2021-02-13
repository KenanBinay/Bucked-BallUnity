using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Bucked1 : MonoBehaviour
{
    public static float x = 0;
 
    public static int ElKontrol = 0;

    private void Start()
    {
        Bucked1.x = 0;
    
    }
   
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            SceneManager.LoadScene("Menu");
            x = 1; //episode 2 için değeri 1 yaptım
            StartPointKey.say = 0;
            ElKontrol = 1;
         
        }
    }
   

}
