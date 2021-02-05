using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Bucked1 : MonoBehaviour
{
    public static float x = 0;
 
    public static int ElKontrol = 0;

    public GameObject LevelEnd1;
    public TextMeshProUGUI timelvl1;

    public GameObject kapatmaButonu;
    private void Start()
    {
        Bucked1.x = 0;
        LevelEnd1.gameObject.SetActive(false);
        kapatmaButonu.gameObject.SetActive(false);
        timelvl1.GetComponent<TextMeshProUGUI>();
    }
   private void Update()
    {
      
        if (Bucked1.x == 1) { level1(); }
        else { return; }
    }
  
    public void level1()
    {
        StartCoroutine(GetEndLevel());
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
           // SceneManager.LoadScene("Menu");
            x = 1; //episode 2 için değeri 1 yaptım
            StartPointKey.say = 0;
            ElKontrol = 1;
            if (KapatEnd.kont == 1)
            {
                LevelEnd1.gameObject.SetActive(false);
                kapatmaButonu.gameObject.SetActive(false);
                KapatEnd.kont = 0;
            }
        }
    }
    public IEnumerator GetEndLevel()
    {
        yield return new WaitForSeconds(0.50f);
      
        if (Bucked1.x == 1)
        {
            Debug.Log("Bölüm bitti");   
            timelvl1.SetText("" + Sayac1.sayaccek1);
            LevelEnd1.gameObject.SetActive(true);
            kapatmaButonu.gameObject.SetActive(true);
        }
        else { kapatmaButonu.gameObject.SetActive(false); }
    }

}
