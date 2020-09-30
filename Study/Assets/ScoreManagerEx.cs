using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerEx : MonoBehaviour
{
	public static ScoreManagerEx GetInstance()
	{
		if(instance == null)
		{
			instance = FindObjectOfType<ScoreManagerEx>();

			// 지연 생성 - 사용하려고 할 때 아무것도 없다면 생성됨
			if(instance == null)
			{
				GameObject container = new GameObject("ScoreManager");

				instance = container.AddComponent<ScoreManagerEx>();
			}
		}

		return instance;
	}
	private static ScoreManagerEx instance;

	private int score = 0;

	private void Start()
	{
		if(instance != null)
		{
			if(instance != this)
			{
				Destroy(gameObject);
			}
		}
	}

	public int GetScore()
	{
		return score;
	}

	public void AddScore(int newScore)
	{
		score += newScore;
	}
}
