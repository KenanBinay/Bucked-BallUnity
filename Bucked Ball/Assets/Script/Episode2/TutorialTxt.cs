using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialTxt : MonoBehaviour
{
    private float sde;
    public Text tutorial;
    void Start()
    {
        tutorial.GetComponent<Text>();
        tutorial.text = "HOLD";
        StartCoroutine(Txt());
    }
   
    public IEnumerator Txt()
    {
        yield return new WaitForSeconds(0.80f);
        tutorial.text = "DRAG";
        yield return new WaitForSeconds(1.25f);
        tutorial.text = "HOLD";
        yield return Txt();
    }

   
}
