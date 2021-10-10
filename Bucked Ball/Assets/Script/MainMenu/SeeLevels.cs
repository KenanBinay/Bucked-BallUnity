using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class SeeLevels : MonoBehaviour
{
    public void Bolumler()
    {
     
        StartCoroutine(GetLevels());
    }
    public IEnumerator GetLevels()
    {
        yield return new WaitForSeconds(0.30f);
        Debug.Log("OynaTıklandı");
        SceneManager.LoadScene("Menu");

    }
}

