using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapatEnd : MonoBehaviour
{
    public GameObject end1;
    public GameObject close;

    public static int kont;
    public void Kapat()
    {
        end1.gameObject.SetActive(false);        
        Time.timeScale = 1f;
        Bucked2and3.x1 = 0;
        degerVer1();
    }
    private void degerVer1() { kont = 1; }
}
