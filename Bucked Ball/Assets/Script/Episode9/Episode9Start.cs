using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Episode9Start : MonoBehaviour
{
    public Animator openlevel;
    void Start()
    {
        openlevel.enabled = false;
    }


    void FixedUpdate()
    {
        if (Bucket8To9.x9 == 1)
        {
            openlevel.enabled = true;
        }
    }
    public void StartGame()
    {
        StartCoroutine(StartMap());
    }
    public IEnumerator StartMap()
    {
        StartPointKey.say = 0;
        yield return new WaitForSeconds(0.30f);
        SceneManager.LoadScene("episode9");
    }
}
