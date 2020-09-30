using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
	private void Awake()
	{
		Debug.Log("Start Score " + ScoreManagerEx.GetInstance().GetScore());
	}
	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			ScoreManagerEx.GetInstance().AddScore(5);
			Debug.Log(ScoreManagerEx.GetInstance().GetScore());
		}
	}
}
