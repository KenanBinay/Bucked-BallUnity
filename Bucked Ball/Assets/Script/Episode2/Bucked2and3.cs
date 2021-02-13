using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Bucked2and3 : MonoBehaviour
{
    public GameObject LevelEnd1;
    public TextMeshProUGUI timelvl1;

    public GameObject kapatmaButonu;
    void Start()
    {
        LevelEnd1.gameObject.SetActive(false);
        kapatmaButonu.gameObject.SetActive(false);
        timelvl1.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (Bucked2and3.x1 == 1) { level1(); }
        else { return; }
    }
    public void level1()
    {
        StartCoroutine(GetEndLevel());
    }
    public static float x1 = 0;
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            //SceneManager.LoadScene("Menu");
            x1 = 1;//bölüm 3 ün açılması için gereken değer
            Bucked1.x = 1;
            StartPointKey.say = 0;
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

        if (Bucked2and3.x1 == 1)
        {
            Debug.Log("Bölüm bitti");
            timelvl1.SetText("" + Sayac1.sayaccek1);
            LevelEnd1.gameObject.SetActive(true);
            kapatmaButonu.gameObject.SetActive(true);
        }
        else { kapatmaButonu.gameObject.SetActive(false); }
    }
}
