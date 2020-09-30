using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calc : MonoBehaviour
{
	private void Start()
	{
		Debug.Log(Sum(1, 1));
		Debug.Log(Sum(1, 2, 3));
		Debug.Log(Sum(1.3f, 2.3f));
		Debug.Log(Sum(1.3f, 2.3f, 3.3f));
	}

	public int Sum(int a, int b)
	{
		return a + b;
	}

	public int Sum(int a, int b, int c)
	{
		return a + b + c;
	}

	public float Sum(float a, float b)
	{
		return a + b;
	}

	public float Sum(float a, float b, float c)
	{
		return a + b + c;
	}
}
