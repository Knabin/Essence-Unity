using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGenerator : MonoBehaviour
{
	public GameObject[] propPrefabs;
	public int count = 100;

	BoxCollider area;
	List<GameObject> props = new List<GameObject>();

    void Start()
    {
		area = GetComponent<BoxCollider>();

		for(int i = 0; i < count; ++i)
		{
			// 생성용 함수
			Spawn();
		}

		area.enabled = false;
    }

	void Spawn()
	{
		int selection = Random.Range(0, propPrefabs.Length);

		GameObject selectedPrefab = propPrefabs[selection];
		Vector3 spawnPos = GetRandomPosition();

		GameObject instance = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
		props.Add(instance);
	}

	Vector3 GetRandomPosition()
	{
		Vector3 basePosition = transform.position;
		Vector3 size = area.size;

		float posX = basePosition.x + Random.Range(-size.x * 0.5f, size.x * 0.5f);
		float posY = basePosition.y + Random.Range(-size.y * 0.5f, size.y * 0.5f);
		float posZ = basePosition.z + Random.Range(-size.z * 0.5f, size.z * 0.5f);

		Vector3 spawnPosition = new Vector3(posX, posY, posZ);

		return spawnPosition;
	}

	public void Reset()
	{
		for(int i = 0; i < props.Count; ++i)
		{
			props[i].transform.position = GetRandomPosition();
			props[i].SetActive(true);
		}
	}
}
