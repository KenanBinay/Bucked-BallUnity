using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key11 : MonoBehaviour
{
    public Animator Diken1;
    public Animator Diken2;
    public Animator Diken3;
    public Animator Diken4;

    private void Start()
    {
        Diken1.enabled = false;
        Diken2.enabled = false;
        Diken3.enabled = false;
        Diken4.enabled = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Diken1.enabled = true;
            Diken2.enabled = true;
            Diken3.enabled = true;
            Diken4.enabled = false;
        }

    }
}
