using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class res1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartPointKey.say = 0;
    }

    // Update is called once per frame
   public void Restart()
    {
        Sayac.deger = 0;
        Time.timeScale = 1f;
        Bucked1.x = 0;
        StartPointKey.say = 0;
        
        SceneManager.LoadScene("episode1");       
    }
}
