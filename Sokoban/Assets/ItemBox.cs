using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
	public bool isOverlapped = false;
	Renderer myRenderer;

	public Color touchColor;
	Color originalColor;

    void Start()
    {
		myRenderer = GetComponent<Renderer>();

		originalColor = myRenderer.material.color;
    }

	// trigger인 콜라이더와 충돌할 때 자동으로 실행
	// "충돌을 한 순간"
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "EndPoint")
		{
			isOverlapped = true;
			myRenderer.material.color = touchColor;
		}
	}

	// "붙어 있다가 떨어질 때"
	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "EndPoint")
		{
			isOverlapped = false;
			myRenderer.material.color = originalColor;
		}
	}

	// "충돌하고 있는, 붙어 있는 동안"
	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "EndPoint")
		{
			isOverlapped = true;
			myRenderer.material.color = touchColor;
		}
	}


	// 일반 콜라이더와 충돌할 때 자동으로 실행
	/*private void OnCollisionEnter(Collision collision)
	{
		Debug.Log("충돌했음!");
	}*/
}
