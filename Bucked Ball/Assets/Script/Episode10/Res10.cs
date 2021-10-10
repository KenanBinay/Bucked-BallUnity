using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Res10 : MonoBehaviour
{
    public void Restart()
    {
        Sayac.deger = 0;
        StartPointKey.say = 0;
        StartCoroutine(RestartMap());
    }
    public IEnumerator RestartMap()
    {
        yield return new WaitForSeconds(0.30f);
        SceneManager.LoadScene("episode10");
    }
}
