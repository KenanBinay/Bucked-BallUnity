using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Time2Start : MonoBehaviour
{
    public TextMeshProUGUI text2;
    void Start()
    {
        
    }

    void Update()
    {
        if (Sayac1.deger > 0)
        {
            degis();
        }
        else { return; }
    }

   private void degis()
    {
      
      text2.SetText("" +Sayac1.deger.ToString("0.#"));
           
    }
}
