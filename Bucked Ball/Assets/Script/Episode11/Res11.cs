using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Res11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Restartgame()
    {
        SceneManager.LoadScene("episode11");
        StartPointKey.say = 0;
    }
}
