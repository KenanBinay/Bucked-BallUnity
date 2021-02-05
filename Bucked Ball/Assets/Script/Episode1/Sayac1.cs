using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sayac1 : MonoBehaviour
{
    public Text say1;
    public static string sayaccek1;
    void start()
    {
        say1.gameObject.SetActive(true);
        Debug.Log("BaşladıSüre");
        //  StartCoroutine(Sayac1Basla());
    }

    public static float kayıt1;
    float deger;
    void Update()
    {  
        if (Bucked1.x != 1)
        {           
            deger+=Time.deltaTime;
            say1.text = deger.ToString("0");
            Debug.Log("Süre = " + deger.ToString("0.#"));
          //  yield return new WaitForSeconds(1f);
        }
       else
        {
            sayaccek1 = say1.text;
            say1.gameObject.SetActive(false);
          
            if (kayıt1 < deger)
            {
                kayıt1 = deger;
            }
        }
    }

}
