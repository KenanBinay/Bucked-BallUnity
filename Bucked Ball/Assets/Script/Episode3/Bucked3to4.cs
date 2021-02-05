using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bucked3to4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static float x4 = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            SceneManager.LoadScene("Menu");
            Bucked2and3.x1 = 1;
            Bucked1.x = 1;
            x4 = 1;
            StartPointKey.say = 0;
        }
    }
}
