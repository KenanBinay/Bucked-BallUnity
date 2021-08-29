using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject Fan1;
	public GameObject Fan2;
	public GameObject Fan3;
	float randX;
	Vector2 whereToSpawn;
	public float spawnRate;
	float nextSpawn = 0.0f;
	public void FixedUpdate()
	{
		if (Time.time > nextSpawn)
		{

			nextSpawn = Time.time + spawnRate;

			randX = Random.Range(-17f, 17f);

			whereToSpawn = new Vector2(randX, transform.position.y);

			Instantiate(Fan1, whereToSpawn, Quaternion.identity);
			Instantiate(Fan2, whereToSpawn, Quaternion.identity);
			Instantiate(Fan3, whereToSpawn, Quaternion.identity);

		}

			Debug.Log("CAN>=0.8f spawnRate Düþürülmüþtür.");
		
	}
}
