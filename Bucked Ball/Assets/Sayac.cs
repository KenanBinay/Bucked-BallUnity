using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayac : MonoBehaviour
{
    public static float deger = 0;

    void start()
    {
        Debug.Log("BaþladýSüre");
        //  StartCoroutine(Sayac1Basla());

    }

    void Update()
    {
        deger += Time.deltaTime;
        Debug.Log("Süre = " + deger.ToString("0.#"));
    }
}
