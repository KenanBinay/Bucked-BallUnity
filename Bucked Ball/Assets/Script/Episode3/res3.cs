using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class res3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void Restart()
    {
        SceneManager.LoadScene("episode3");
        StartPointKey.say = 0;
    }
}
