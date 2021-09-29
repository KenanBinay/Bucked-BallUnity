using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanMovementUp : MonoBehaviour
{
    public GameObject fan;
    public Rigidbody2D top;

    [Range(-10.0f, 10.0f)]
    public float hýz;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("EtkileþimFan");

        top.AddForce(Vector2.up * hýz);
       
    }
}
