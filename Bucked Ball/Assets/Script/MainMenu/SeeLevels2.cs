using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class SeeLevels2 : MonoBehaviour
{
    
 public void MainMenu()
    {
        StartCoroutine(GetMainMenu());
        Debug.Log("AnaMenüDönüş");
    }

    public IEnumerator GetMainMenu()
    {
        yield return new WaitForSeconds(0.30f);
       SceneManager.LoadScene("MainMenu");
    }
}

