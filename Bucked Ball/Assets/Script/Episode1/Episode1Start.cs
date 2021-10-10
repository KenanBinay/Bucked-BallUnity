using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Episode1Start : MonoBehaviour
{
    void Start()
    {
        Sayac.deger = 0;
    }

   public void EpisodeStart()
    {
        StartCoroutine(StartMap());
    }
    public IEnumerator StartMap()
    {
        yield return new WaitForSeconds(0.30f);
        SceneManager.LoadScene("episode1");
    }
}
