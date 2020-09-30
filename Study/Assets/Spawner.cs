using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public Rigidbody target;	// GameObject도 가능
	public Transform spawnPosition;

	void Start()
	{
		Rigidbody instance = Instantiate(target, spawnPosition.position, spawnPosition.rotation);
		instance.name = "테스트";
		instance.AddForce(0, 1000, 0);
		Debug.Log(instance.name);
	}

}
