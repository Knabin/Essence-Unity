using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public List<int> scores = new List<int>();

	private void Start()
	{
		int score0 = 45;
		int score1 = 60;
		int score2 = 75;

		scores.Add(score0);
		scores.Add(score1);
		scores.Add(score2);

		scores.RemoveAt(1);

		Debug.Log(scores[1]);
	}

	void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			int randomNumber = Random.Range(0, 100);
			scores.Add(randomNumber);
		}

		if(Input.GetMouseButtonDown(1))
		{
			scores.RemoveAt(3);
		}

	}
}
