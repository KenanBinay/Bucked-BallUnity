using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bucked5To6 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public static float x6 = 0;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            x6 = 1;
            SceneManager.LoadScene("Menu");
            StartPointKey.say = 0;
        }
    }
}
