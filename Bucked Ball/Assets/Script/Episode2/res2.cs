using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class res2 : MonoBehaviour
{
    

   
    // Update is called once per frame
    public void Restart()
    {
        Sayac.deger = 0;
        SceneManager.LoadScene("episode2");
        StartPointKey.say = 0;
    }
}
