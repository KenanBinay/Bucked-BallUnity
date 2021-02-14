using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Time2Start : MonoBehaviour
{
    public TextMeshProUGUI text2;
    private float yuksel;
    void Start()
    {
       
        Debug.Log("lvl2 süre ");
    }

    void Update()
    {
       
        Sayac1.deger = LoadManager.instance.data.time2;
        Debug.Log("süre deðiþtirildi");
        text2.SetText("" + Sayac1.deger.ToString("0"));
    }

   private void degis()
    {
      
           
    }
}
