using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody2D top;

    [Range(-10.0f, 10.0f)]
    public float hiz;

    private void OnTriggerStay2D(Collider2D collision)
    {

        top.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * hiz, ForceMode2D.Impulse);
        
    }
}
