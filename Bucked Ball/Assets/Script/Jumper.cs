using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody2D top;

    [Range(-10.0f, 10.0f)]
    public float hýz;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Etkileþim Top");
      
        top.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")+hýz);
        
    }
}
