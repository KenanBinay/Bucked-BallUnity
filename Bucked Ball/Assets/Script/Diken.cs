using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diken : MonoBehaviour
{
    public GameObject Top;
    public GameObject PatlamaEfekt;
    public Animator KameraTitreme;
    void Start()
    {
        KameraTitreme.enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {
      

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            PatlamaEfekt.transform.position = Top.transform.position;
            Instantiate(PatlamaEfekt);
            Destroy(Top);
            KameraTitreme.enabled = true;
        }
        else
        {
            PatlamaEfekt.SetActive(true);
        }
    }
}
