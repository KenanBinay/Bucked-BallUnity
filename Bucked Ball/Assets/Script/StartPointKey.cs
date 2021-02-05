using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPointKey : MonoBehaviour
{
    public Transform Other1;
    public Transform Other2;
    public GameObject ElKendisi;
    public GameObject elEfekt;
    public GameObject Platform1;
    public GameObject Platform2;
    public static float say = 0;
    public static int b = 0;
    void Start()
    {
        /*if (Bucked1.ElKontrol == 1)
        {
            Destroy(ElKendisi);
            Destroy(elEfekt);
        }
        */
    }
 
    // Update is called once per frame
    public void Rotate()
    {
     
        if (say == 0)
        {
            Other1.Rotate(Vector3.forward * -90);
            Other2.Rotate(Vector3.forward * 90);
            b++;
            Destroy(Platform1);
            Destroy(Platform2);

           // if (b >= 1)
           if(Bucked1.ElKontrol!=1)
            {
                PatlatEfekt();
            }
            else
            {
                Destroy(elEfekt);
                Destroy(ElKendisi);
                return;
            }
            
        }
        else
        {  }
        say++;
    }
    
    public void PatlatEfekt()
    {
        elEfekt.transform.position = ElKendisi.transform.position;
        Destroy(ElKendisi);
        Instantiate(elEfekt);
    }
}
