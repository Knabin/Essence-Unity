using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCoroutine : MonoBehaviour
{
	void Start()
	{
		StartCoroutine("HelloUnity");
		StartCoroutine("HiCSharp");
		Debug.Log("End");
	}

	IEnumerator HelloUnity()
	{
		Debug.Log("Hello");

		yield return new WaitForSeconds(3.0f);

		Debug.Log("Unity");
	}

	IEnumerator HiCSharp()
	{
		Debug.Log("Hi");

		yield return new WaitForSeconds(5.0f);

		Debug.Log("CSharp");
	}
}
