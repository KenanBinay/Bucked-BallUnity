using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Episode19Start : MonoBehaviour
{
    public Animator openLevel;
    void Start()
    {
        openLevel.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Bucked10To11.x11 == 1)
        {
            openLevel.enabled = true;
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
        SceneManager.LoadScene("episode19");
    }
}
