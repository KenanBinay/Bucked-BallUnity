using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bucked6To7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static float x7 = 0;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            x7 = 1;
            SceneManager.LoadScene("Menu");
            StartPointKey.say = 0;
        }
    }
}
