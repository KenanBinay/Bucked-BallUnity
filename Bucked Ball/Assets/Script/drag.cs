using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
	float uzaklık = 16f;
	public GameObject ElKendisi;
	public GameObject elEfekt;
	public GameObject yeni;
	public void OnMouseDrag()
	{
	
		Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, uzaklık);
		Vector3 objPosition = Camera.current.ScreenToWorldPoint(mousePosition);
		transform.position = objPosition;
				
			elEfekt.transform.position = ElKendisi.transform.position;
			Destroy(ElKendisi);
			Instantiate(elEfekt);
			Destroy(yeni);
		
	}
}
