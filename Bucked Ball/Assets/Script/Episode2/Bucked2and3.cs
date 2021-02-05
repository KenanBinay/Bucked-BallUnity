using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bucked2and3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public static float x1 = 0;
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            SceneManager.LoadScene("Menu");
            x1 = 1;//bölüm 3 ün açılması için gereken değer
            Bucked1.x = 1;
            StartPointKey.say = 0;         
        }
    }
}
