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

    public AudioSource PuzzleDoneSource;

    private void Start()
    {
        Sayac.deger = 0;
        Bucked1.x = 0;
        if (LevelEnd1.gameObject == true) { LevelEnd1.gameObject.SetActive(false); }  
        LevelEnd1.gameObject.SetActive(false);

    }

    public GameObject Gud;
    public GameObject Medium;
    public GameObject Bad;
    public static float CloseOpen = 0;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
          //  SceneManager.LoadScene("Menu");
            x = 1; //episode 2 için değeri 1 yaptım
            StartPointKey.say = 0;
            ElKontrol = 1;
            CloseOpen = 1;
            LevelEnd1.gameObject.SetActive(false);
            Gud.SetActive(false);
            Medium.SetActive(false);
            Bad.SetActive(false); 
        }
    }

    void Update()
    {
        if (x == 1) { level1(); }
        else { return; }
    }

    public void level1()
    {
        StartCoroutine(GetEndLevel());
    }

    public IEnumerator GetEndLevel()
    {
        yield return new WaitForSeconds(0.50f);

        if (CloseOpen == 1)
        {
            PuzzleDoneSource.Play();
            Debug.Log("Bölüm bitti");
            LevelEnd1.gameObject.SetActive(true);
            if (Sayac.deger >= 0 && Sayac.deger <= 17) { Gud.SetActive(true); }
            if (Sayac.deger >= 17 && Sayac.deger <= 25) { Medium.SetActive(true); }
            if (Sayac.deger >= 25) { Bad.SetActive(true); }
            CloseOpen = 0;
            Time.timeScale = 0f;
        }
        else { CloseOpen = 0; }
    }
}
