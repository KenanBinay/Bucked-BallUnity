using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject Fan1;
	public GameObject Fan2;
	public GameObject Fan3;
	Vector2 whereToSpawn;
	public float spawnRate;
	float nextSpawn = 0.0f;

	float RandY;
	public void FixedUpdate()
	{
		if (Time.time > nextSpawn)
		{

			nextSpawn = Time.time + spawnRate;
	
			whereToSpawn = new Vector2(transform.position.x,transform.position.y);

			Instantiate(Fan1, whereToSpawn, Quaternion.identity);
			Instantiate(Fan2, whereToSpawn, Quaternion.identity);
			Instantiate(Fan3, whereToSpawn, Quaternion.identity);

		}

		
	}
}
