using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bucket9To10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static float x10 = 0;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Menu");
            StartPointKey.say = 0;
            x10 = 1;
        }
    }
}
